using System;

namespace floatingpoint
{
    public class FloatInfo : PropertyChangedBase
    {
        public const int TotalBits = 32;
        public const int SignMask = Int32.MinValue; // 0x8000000
        public const int ExponentBias = 127;
        public const int ExponentMask = 0x7F800000;
        public const int ExponentShift = 23;
        public const int SignificandBits = 23;
        public const int SignificandMask = 0x7FFFFF;

        // Outer details
        private byte[] _data;
        private Int32 _intValue;
        private float _floatValue;

        // Inner details
        private bool _sign;
        private bool _isSmallNumber;
        private int _exponent;
        private int _exponentBiased;
        private int _significand;
        private int _significandDenominator;
        private int _significandNumerator;
        private float _significandFraction;

        // Bit details
        private readonly BitArray2 _rawBits;

        // String representations
        private string _hexString;
        private string _intString;
        private string _floatString;

        // Constructor
        public FloatInfo()
        {
            _rawBits = new BitArray2(TotalBits);
            _rawBits.BitChanged += new EventHandler<BitChangedEventArgs>(SetRawBitHandler);
            SetInt32(0, true);
        }

        // Properties
        public bool Sign
        {
            get { return _sign; }
            set { SetSign(value); }
        }

        public int Exponent
        {
            get { return _exponent; }
            set { SetExponent(value); }
        }

        public int ExponentBiased
        {
            get { return _exponentBiased; }
        }

        public int Significand
        {
            get { return _significand; }
            set { SetSignificand(value); }
        }

        public bool IsSmallNumber
        {
            get { return _isSmallNumber; }
        }

        public bool IsNaN
        {
            get { return float.IsNaN(_floatValue); }
        }

        public bool IsNegativeInfinity
        {
            get { return float.IsNegativeInfinity(_floatValue); }
        }

        public bool IsPositiveInfinity
        {
            get { return float.IsPositiveInfinity(_floatValue); }
        }

        public bool IsInfinity
        {
            get { return float.IsInfinity(_floatValue); }
        }

        public bool IsEmpty
        {
            get { return _intValue == 0; }
        }

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

        public BitArray2 Bits
        {
            get { return _rawBits; }
        }

        public void ParseFloat(string floatValue)
        {
            _floatString = floatValue;
            float fValue = float.Parse(floatValue);
            SetFloat(fValue, false);
        }

        public void ParseInt(string intString)
        {
            int intValue = Int32.Parse(intString);
            SetInt32(intValue, false);
        }

        public void ParseHex(string hexValue)
        {
            // Remove the leading '0x' if present
            if (hexValue.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase))
            {
                hexValue = hexValue.Substring(2);
            }
            // Parse the hex value to int
            int intValue = Int32.Parse(hexValue, System.Globalization.NumberStyles.AllowHexSpecifier);
            SetInt32(intValue);
        }

        public void SetBytes(byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException("'data' cannot be null!", "data");
            if (data.Length != 4)
                throw new ArgumentNullException("'data' must be 4 bytes!", "data");

            data.CopyTo(_data, 0);
            ParseData();
        }

        public void SetFloat(float value)
        {
            SetFloat(value, true);
        }

        public void SetFloat(float value, bool updateString)
        {
            _floatValue = value;
            _data = BitConverter.GetBytes(value);
            if (updateString) _floatString = _floatValue.ToString();
            _intValue = BitConverter.ToInt32(_data, 0);
            _intString = _intValue.ToString();
            _hexString = _intValue.ToString("X8");
            ParseData();
        }

        public void SetInt32(int value)
        {
            SetInt32(value, true);
        }

        public void SetInt32(int value, bool updateString)
        {
            _intValue = value;
            _data = BitConverter.GetBytes(value);
            _floatValue = BitConverter.ToSingle(_data, 0);
            _floatString = _floatValue.ToString();
            if (updateString) _intString = _intValue.ToString();
            _hexString = _intValue.ToString("X8");
            ParseData();
        }

        private bool GetSign()
        {
            // Bit 31
            _sign = (_intValue & SignMask) != 0;
            return _sign;
        }

        private void SetSign(bool value)
        {
            if (_sign != value)
            {
                _sign = value;
                int newValue = _intValue;
                if (value)
                    newValue |= SignMask;
                else
                    newValue &= ~SignMask;
                SetInt32(newValue);
            }
        }

        private int GetExponent()
        {
            // Bits 30-23
            _exponent = (_intValue & ExponentMask) >> ExponentShift;
            _exponentBiased = _exponent - ExponentBias;
            return _exponent;
        }

        private void SetExponent(int value)
        {
            // Bits 30-23
            int shiftedValue = (value << ExponentShift) & ExponentMask;
            int newValue = _intValue & ~ExponentMask | shiftedValue;
            SetInt32(newValue);
        }

        private int GetSignificand()
        {
            // Bits 22-0
            //_significand = (((int)_data[2] & 0x7F) << 16) | ((int)_data[1] << 8) | ((int)_data[0]);
            _significand = _intValue & SignificandMask;
            return _significand;
        }

        private void SetSignificand(int value)
        {
            if (value < 0 || value > SignificandMask)
                throw new ArgumentOutOfRangeException("value");

            _significand = value & SignificandMask;
            int newValue = (_intValue & ~SignificandMask) | _significand;
            SetInt32(newValue);
        }

        public bool GetRawBit(int index)
        {
            if (index < 0 || index >= TotalBits)
                throw new ArgumentException("'index' must be between 0 and " + TotalBits, "index");

            return _rawBits[index];
        }

        public void SetRawBit(int index, bool value)
        {
            SetRawBit(index, value, false);
        }

        public void SetRawBit(int index, bool value, bool refresh)
        {
            if (index < 0 || index >= TotalBits)
                throw new ArgumentException("'index' must be between 0 and " + TotalBits, "index");

            if (refresh || _rawBits[index] != value)
            {
                _rawBits[index] = value;
                int newValue = _intValue;

                if (value)
                    newValue |= (0x1 << index);
                else
                    newValue &= ~(0x1 << index);

                SetInt32(newValue);
            }
        }

        private void SetRawBitHandler(object sender, BitChangedEventArgs e)
        {
            SetRawBit(e.Bits[0], e.NewValues[0], true);
        }

        private void ParseData()
        {
            // 32 bits / 4 bytes (31-0 bits)
            GetSign();
            GetExponent();
            GetSignificand();

            // Check if number is really small and not zero
            _isSmallNumber = (_exponent == -127) && ((_significand & SignificandMask) != 0);

            // Load the bit array with values
            _rawBits.BitChanged -= new EventHandler<BitChangedEventArgs>(SetRawBitHandler);
            for (int index = 0; index < TotalBits; ++index)
            {
                bool bitValue = (_intValue & (0x1 << index)) != 0;
                _rawBits[index] = bitValue;
            }

            // Check the BitArray
            for (int index = 0; index < TotalBits; ++index)
            {
                bool bitValue = _rawBits[index];
                bool debugValue = (_intValue & (0x1 << index)) != 0;
                System.Diagnostics.Debug.Assert(bitValue == debugValue, string.Format("Bit mismatch on index {0}: GetRawBit={1}, Actual={2}", index, bitValue, debugValue));
                System.Diagnostics.Debug.WriteLine("[{0:D2}]: {1}", index, bitValue);
            }
            _rawBits.BitChanged += new EventHandler<BitChangedEventArgs>(SetRawBitHandler);
            NotifyOfAllPropertiesChange();
        }
    }
}
