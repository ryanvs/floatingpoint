using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace floatingpoint
{
    public partial class MainForm : Form
    {
        private bool _blockTextEvent;

        public MainForm()
        {
            InitializeComponent();
        }

        private void textBoxFloat_TextChanged(object sender, EventArgs e)
        {
            if (_blockTextEvent)
                return;
            try
            {
                _blockTextEvent = true;
                float fValue = float.Parse(textBoxFloat.Text);
                byte[] data = BitConverter.GetBytes(fValue);
                int intValue = BitConverter.ToInt32(data, 0);
                textBoxInt.Text = intValue.ToString();
                textBoxHex.Text = "0x" + intValue.ToString("X8");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            finally
            {
                _blockTextEvent = false;
            }
        }

        private void textBoxHex_TextChanged(object sender, EventArgs e)
        {
            if (_blockTextEvent)
                return;
            try
            {
                _blockTextEvent = true;
                string sValue = textBoxHex.Text.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase) ? textBoxHex.Text.Substring(2) : textBoxHex.Text;
                int intValue = Int32.Parse(sValue, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] data = BitConverter.GetBytes(intValue);
                float fValue = BitConverter.ToSingle(data, 0);
                textBoxFloat.Text = fValue.ToString();
                textBoxInt.Text = intValue.ToString();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            finally
            {
                _blockTextEvent = false;
            }
        }

        private void textBoxInt_TextChanged(object sender, EventArgs e)
        {
            if (_blockTextEvent)
                return;
            try
            {
                _blockTextEvent = true;
                int intValue = Int32.Parse(textBoxInt.Text);
                byte[] data = BitConverter.GetBytes(intValue);
                float fValue = BitConverter.ToSingle(data, 0);
                textBoxFloat.Text = fValue.ToString();
                textBoxHex.Text = "0x" + intValue.ToString("X8");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            finally
            {
                _blockTextEvent = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxFloat.Text = "1.0";
        }
    }
}
