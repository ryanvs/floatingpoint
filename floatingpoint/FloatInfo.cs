using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace floatingpoint
{
    public class FloatInfo
    {
        private Int32 _intValue;
        private float _floatValue;
        private string _hexString;
        private string _intString;
        private string _floatString;
        private byte[] _data;

        public bool Sign { get; private set; }
        public int Exponent { get; private set; }
        public int Mantissa { get; private set; }

        public float FloatValue
        {
            get { return _floatValue; }
            set { SetFloat(value); }
        }

        public Int32 IntValue
        {
            get { return _intValue; }
            set { SetInt32(value); }
        }

        public string HexString
        {
            get { return _hexString; }
            set { ParseHex(value); }
        }

        public string IntString
        {
            get { return _intString; }
            set { ParseInt(value); }
        }

        public string FloatString
        {
            get { return _floatString; }
            set { ParseFloat(value); }
        }

        public void ParseFloat(string floatValue)
        {
            float fValue = float.Parse(floatValue);
            SetFloat(fValue);
        }

        public void ParseInt(string intString)
        {
            int intValue = Int32.Parse(intString);
            SetInt32(intValue);
        }

        public void ParseHex(string hexValue)
        {
            if (hexValue.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase))
                hexValue = hexValue.Substring(2);
            int intValue = Int32.Parse(hexValue, System.Globalization.NumberStyles.AllowHexSpecifier);
            SetInt32(intValue);
        }

        public void SetFloat(float value)
        {
            _floatValue = value;
            _data = BitConverter.GetBytes(value);
            ParseData(_data);
            _intValue = BitConverter.ToInt32(_data, 0);
            _intString = _intValue.ToString();
            _hexString = _intValue.ToString("X8");
        }

        public void SetInt32(int value)
        {
            _intValue = value;
            _data = BitConverter.GetBytes(value);
            ParseData(_data);
            _floatValue = BitConverter.ToSingle(_data, 0);
            _floatString = _floatValue.ToString();
            _hexString = _intValue.ToString("X8");
        }

        private void ParseData(byte[] data)
        {
            // 32 bits / 4 bytes (31-0 bits)
            //_data = data;
            // Bit 31
            Sign = ((_data[3] & 0x80) != 0);
            // Bits 30-23
            Exponent = (((int)_data[3] & 0x7F) << 1) | (((int)_data[2] & 0x80) >> 7);
            // Bits 22-0
            Mantissa = (((int)_data[2] & 0x7F) << 16) | ((int)_data[1] << 8) | ((int)_data[0]);
        }
    }
}
