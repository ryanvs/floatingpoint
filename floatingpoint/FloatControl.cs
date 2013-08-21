using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace floatingpoint
{
    public partial class FloatControl : UserControl
    {
        private bool isRefreshing;

        private FloatInfo _floatValue;
        public FloatInfo FloatValue
        {
            get { return _floatValue; }
            set { _floatValue = value; RefreshFloatInfo(); }
        }

        private CheckBox[] bitCheckBoxes = new CheckBox[] {};

        public EventHandler FloatValueChanged;

        public FloatControl()
        {
            InitializeComponent();
            bitCheckBoxes = new CheckBox[] {
                checkBox00, checkBox01, checkBox02, checkBox03, 
                checkBox04, checkBox05, checkBox06, checkBox07, 
                checkBox08, checkBox09, checkBox10, checkBox11, 
                checkBox12, checkBox13, checkBox14, checkBox15, 
                checkBox16, checkBox17, checkBox18, checkBox19, 
                checkBox20, checkBox21, checkBox22, checkBox23, 
                checkBox24, checkBox25, checkBox26, checkBox27, 
                checkBox28, checkBox29, checkBox30, checkBox31,
            };
        }

        private void BitCheckBoxChanged(object sender, EventArgs e)
        {
            if (isRefreshing)
                return;

            var checkBox = sender as CheckBox;
            int index = int.Parse(checkBox.Text);
            FloatValue.SetRawBit(index, checkBox.Checked);
            var boldFont = new Font(this.Font, FontStyle.Bold);
            checkBox.Font = checkBox.Checked ? boldFont : this.Font;
            RefreshHexCharacters();

            // Notify subscribers that the value has changed
            if (FloatValueChanged != null)
            {
                FloatValueChanged(this, new EventArgs());
            }
        }

        public void RefreshFloatInfo()
        {
            if (_floatValue == null)
                return;

            try
            {
                isRefreshing = true;
                var boldFont = new Font(this.Font, FontStyle.Bold);
                int rawIntValue = _floatValue.IntValue;
                for (int index = 0; index < FloatInfo.TotalBits; ++index)
                {
                    bool value = _floatValue.GetRawBit(index);
                    bool debugValue = (rawIntValue & (0x1 << index)) != 0;
                    System.Diagnostics.Debug.Assert(value == debugValue, string.Format("Bit mismatch on index {0}: GetRawBit={1}, Actual={2}", index, value, debugValue));
                    bitCheckBoxes[index].Checked = value;
                    bitCheckBoxes[index].Font = value ? boldFont : this.Font;
                }

                RefreshHexCharacters();
            }
            finally
            {
                isRefreshing = false;
            }
        }

        private void RefreshHexCharacters()
        {
            if (_floatValue == null)
                return;

            try
            {
                if (_floatValue.IsEmpty)
                    labelSign.Text = string.Empty;
                else if (_floatValue.Sign == false)
                    labelSign.Text = "Positive";
                else
                    labelSign.Text = "Negative";

                string hexValue = _floatValue.HexString;
                if (!string.IsNullOrEmpty(hexValue))
                {
                    textBoxHex00.Text = hexValue.Substring(7, 1);
                    textBoxHex01.Text = hexValue.Substring(6, 1);
                    textBoxHex02.Text = hexValue.Substring(5, 1);
                    textBoxHex03.Text = hexValue.Substring(4, 1);
                    textBoxHex04.Text = hexValue.Substring(3, 1);
                    textBoxHex05.Text = hexValue.Substring(2, 1);
                    textBoxHex06.Text = hexValue.Substring(1, 1);
                    textBoxHex07.Text = hexValue.Substring(0, 1);
                }
                else
                {
                    textBoxHex00.Text = string.Empty;
                    textBoxHex01.Text = string.Empty;
                    textBoxHex02.Text = string.Empty;
                    textBoxHex03.Text = string.Empty;
                    textBoxHex04.Text = string.Empty;
                    textBoxHex05.Text = string.Empty;
                    textBoxHex06.Text = string.Empty;
                    textBoxHex07.Text = string.Empty;
                }
            }
            finally
            {
                //isRefreshing = false;
            }
        }
    }
}
