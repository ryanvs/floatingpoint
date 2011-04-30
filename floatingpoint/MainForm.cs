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
        private FloatInfo _floatInfo = new FloatInfo();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxFloat.Text = "1.0";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (_blockTextEvent)
                return;
            try
            {
                _blockTextEvent = true;
                if (sender == textBoxInt)
                    _floatInfo.ParseInt(textBoxInt.Text);
                else if (sender == textBoxHex)
                    _floatInfo.ParseHex(textBoxHex.Text);
                else if (sender == textBoxFloat)
                    _floatInfo.ParseFloat(textBoxFloat.Text);

                if (sender != textBoxInt)
                    textBoxInt.Text = _floatInfo.IntString;
                if (sender != textBoxHex)
                    textBoxHex.Text = _floatInfo.HexString;
                if (sender != textBoxFloat)
                    textBoxFloat.Text = _floatInfo.FloatString;

                textBoxSign.Text = _floatInfo.Sign.ToString();
                textBoxExponent.Text = _floatInfo.Exponent.ToString();
                textBoxMantissa.Text = _floatInfo.Mantissa.ToString();
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
    }
}
