using System;

namespace floatingpoint
{
    public class BitChangedEventArgs : EventArgs
    {
        private readonly int[] _bits;
        private readonly bool[] _newValues;
        private readonly bool[] _oldValues;

        public int[] Bits { get { return _bits; } }
        public bool[] NewValues { get { return _newValues; } }
        public bool[] OldValues { get { return _oldValues; } }

        public BitChangedEventArgs(int index, bool newValue, bool oldValue)
        {
            _bits = new int[1] { index };
            _newValues = new bool[1] { newValue };
            _oldValues = new bool[1] { oldValue };
        }
        public BitChangedEventArgs(int[] indices)
        {
            if (indices == null)
            {
                _bits = new int[32];
                for (int ii = 0; ii < _bits.Length - 1; ii++)
                {
                    _bits[ii] = ii;
                }
            }
            else
            {
                if (indices.Length > 32) throw new ArgumentException("indices cannot be larger than 32");
                _bits = new int[indices.Length];
                for (int ii = 0; ii < indices.Length; ii++)
                {
                    int index = indices[ii];
                    if (index < 0) throw new ArgumentException("indices cannot be less than 0");
                    if (index >= 32) throw new ArgumentException("indices cannot be greater than or equal to 32");
                    _bits[ii] = index;
                }
            }
        }
    }
}
