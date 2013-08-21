using System;
using System.Collections;

namespace floatingpoint
{
    public class BitArray2
    {
        private BitArray _data;
        public EventHandler<BitChangedEventArgs> BitChanged;

        public BitArray2(int bits)
        {
            _data = new BitArray(bits);
        }

        public bool this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
                if (_data[index] != value)
                {
                    bool oldValue = _data[index];
                    _data[index] = value;
                    var evt = BitChanged;
                    if (evt != null)
                    {
                        evt(this, new BitChangedEventArgs(index, value, oldValue));
                    }
                }
            }
        }
    }
}
