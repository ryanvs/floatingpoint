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
            floatControl1.FloatValueChanged += new System.EventHandler(this.RefreshFloatInfo);
            floatControl1.FloatValue = _floatInfo;
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
                textBoxMantissa.Text = _floatInfo.Significand.ToString();
                floatControl1.RefreshFloatInfo();
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

        public void RefreshFloatInfo(object sender, EventArgs e)
        {
            try
            {
                _blockTextEvent = true;

                textBoxInt.Text = _floatInfo.IntString;
                textBoxHex.Text = _floatInfo.HexString;
                textBoxFloat.Text = _floatInfo.FloatString;

                textBoxSign.Text = _floatInfo.Sign.ToString();
                textBoxExponent.Text = _floatInfo.Exponent.ToString();
                textBoxMantissa.Text = _floatInfo.Significand.ToString();
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
