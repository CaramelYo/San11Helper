using System;


namespace San11Helper
{
    public struct SpecialtyID
    {
        public static SpecialtyID root;
        public static int levelShift = 8;

        public SpecialtyID this[int childSpecialtyID]
        {
            get { return new SpecialtyID((_ID << levelShift) | (uint)childSpecialtyID); }
        }

        public SpecialtyID super
        {
            get { return new SpecialtyID(_ID >> levelShift); }
        }

        public bool isa(SpecialtyID super)
        {
            return (this != root) && ((this.super == super) || this.super.isa(super));
        }

        public static implicit operator SpecialtyID(int SpecialtyID)
        {
            if (SpecialtyID == 0)
            {
                throw new InvalidCastException("top level SpecialtyID cannot be 0");
            }
            return new SpecialtyID((uint)SpecialtyID);
        }

        public static bool operator ==(SpecialtyID a, SpecialtyID b)
        {
            return a._ID == b._ID;
        }

        public static bool operator !=(SpecialtyID a, SpecialtyID b)
        {
            return a._ID != b._ID;
        }

        public override bool Equals(object obj)
        {
            if (obj is SpecialtyID)
                return ((SpecialtyID)obj)._ID == _ID;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)_ID;
        }

        private SpecialtyID(uint SpecialtyID)
        {
            _ID = SpecialtyID;
        }

        private readonly uint _ID;
    }
}
