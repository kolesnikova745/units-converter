using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Value convertingValue;
        Value convertedValue;

        Converter converter = new Converter();      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
        }

        private void lengthInitgroupBox_Enter(object sender, EventArgs e)
        {
            lengthResGroupBox.Enabled = true;
            massResGroupBox.Enabled = false;
            timeResGroupBox.Enabled = false;        

            var massRadioButtons = massInitGroupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in massRadioButtons)
            {
                rb.Checked = false;
            }

            var timeRadioButtons = timeInitGroupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in timeRadioButtons)
            {
                rb.Checked = false;
            }
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputTextBox.Text.StartsWith(".") || inputTextBox.Text.StartsWith(","))
            {
                inputTextBox.Text = new string(inputTextBox.Text.SkipWhile(c => c == '.' || c == ',').ToArray());
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            String convertFromRadioButton = GetConvertingFromRadioButton();
            String convertToRadioButton = GetConvertingToRadioButton();           

            if (convertFromRadioButton == null || convertToRadioButton == null) 
             {
                 errorLabel.Text = "Ошибка!!! Нужно указать единицы измерения";
                 saveButton.Enabled = false;
                
                 return;
             }

            try {
                Double initialValue = Convert.ToDouble(inputTextBox.Text.Replace('.', ','));                              
                      
                convertingValue = new Value(initialValue, getConvetingFromUnitType(convertFromRadioButton));
                convertedValue = converter.Convert(convertingValue, getConvetingToUnitType(convertToRadioButton));
                resultTextBox.Text = convertedValue.GetVal().ToString();
                saveButton.Enabled = true;
            } catch (FormatException) {
                errorLabel.Text = "Ошибка!!!";
                saveButton.Enabled = false;
            }
            
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            resultTextBox.Text = "";
            saveButton.Enabled = false;        
        }

        private void massInitGroupBox_Enter(object sender, EventArgs e)
        {
            massResGroupBox.Enabled = true;
            lengthResGroupBox.Enabled = false;            
            timeResGroupBox.Enabled = false;

            var lengthRadioButtons = lengthInitGroupBox.Controls.OfType<RadioButton>(); 
            foreach (RadioButton rb in lengthRadioButtons)
            {
                rb.Checked = false;
            }

            var timeRadioButtons = timeInitGroupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in timeRadioButtons)
            {
                rb.Checked = false;
            }
        }

        private void timeInitGroupBox_Enter(object sender, EventArgs e)
        {
            timeResGroupBox.Enabled = true;
            massResGroupBox.Enabled = false;
            lengthResGroupBox.Enabled = false;  
            

            var massRadioButtons = massInitGroupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in massRadioButtons)
            {
                rb.Checked = false;
            }

            var lengthRadioButtons = lengthInitGroupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in lengthRadioButtons)
            {
                rb.Checked = false;
            }

        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.' || e.KeyChar == ',') && 
                ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private String GetConvertingFromRadioButton()
        {           
            var lengthRadioButtons = lengthInitGroupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in lengthRadioButtons)
            {
                if (rb.Checked)
                {
                    return rb.Name;
                }
            }

            var massRadioButtons = massInitGroupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in massRadioButtons)
            {
                if (rb.Checked)
                {
                    return rb.Name;
                }
            }

            var timeRadioButtons = timeInitGroupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in timeRadioButtons)
            {
                if (rb.Checked)
                {
                    return rb.Name;
                }
            }

            return null;
        }

        private UnitTypes getConvetingFromUnitType(String checkedRadioButtinName)
        {
            switch (checkedRadioButtinName)
            {
                case "mmInitRadioButton":
                    return UnitTypes.Millimeter;
                case "cmInitRadioButton": 
                    return UnitTypes.Centimeter;
                case "dmInitRadioButton": 
                    return UnitTypes.Decimeter;
                case "mInitRadioButton":
                    return UnitTypes.Meter;
                case "kmInitRadioButton":
                    return UnitTypes.Kilometer;
                case "gInitRadioButton":
                    return UnitTypes.Gramm;
                case "kgInitRadioButton":
                    return UnitTypes.Kilogramm;
                case "centnerInitRadioButton":
                    return UnitTypes.Centner;
                case "tInitRadioButton":
                    return UnitTypes.Ton;
                case "secInitRadioButton":
                    return UnitTypes.Second;
                case "minInitRadioButton":
                    return UnitTypes.Minute;
                case "hourInitRadioButton":
                    return UnitTypes.Hour;
                default: return UnitTypes.Nothing;

            }

        }

        private String GetConvertingToRadioButton()
        {
            if (lengthResGroupBox.Enabled == true)
            {
                var lengthRadioButtons = lengthResGroupBox.Controls.OfType<RadioButton>();
                foreach (RadioButton rb in lengthRadioButtons)
                {
                    if (rb.Checked)
                    {
                        return rb.Name;
                    }
                }
            }
            
            if (massResGroupBox.Enabled == true)
            {
                var massRadioButtons = massResGroupBox.Controls.OfType<RadioButton>();
                foreach (RadioButton rb in massRadioButtons)
                {
                    if (rb.Checked)
                    {
                        return rb.Name;
                    }
                }
            }
            
            if (timeResGroupBox.Enabled == true)
            {
                var timeRadioButtons = timeResGroupBox.Controls.OfType<RadioButton>();
                foreach (RadioButton rb in timeRadioButtons)
                {
                    if (rb.Checked)
                    {
                        return rb.Name;
                    }
                }
            }
            
            return null;
        }

        private UnitTypes getConvetingToUnitType(String checkedRadioButtinName)
        {
            switch (checkedRadioButtinName)
            {
                case "mmResRadioButton":
                    return UnitTypes.Millimeter;
                case "cmResRadioButton":
                    return UnitTypes.Centimeter;
                case "dmResRadioButton":
                    return UnitTypes.Decimeter;
                case "mResRadioButton":
                    return UnitTypes.Meter;
                case "kmResRadioButton":
                    return UnitTypes.Kilometer;
                case "gResRadioButton":
                    return UnitTypes.Gramm;
                case "kgResRadioButton":
                    return UnitTypes.Kilogramm;
                case "centnerResRadioButton":
                    return UnitTypes.Centner;
                case "tResRadioButton":
                    return UnitTypes.Ton;
                case "secResRadioButton":
                    return UnitTypes.Second;
                case "minResRadioButton":
                    return UnitTypes.Minute;
                case "hourResRadioButton":
                    return UnitTypes.Hour;
                default: return UnitTypes.Nothing;

            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    try
                    {
                        myWritet.Write(inputTextBox.Text + " " + resultTextBox.Text + " \r\n");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }
                    myWritet.Close();
                }
            }

        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
