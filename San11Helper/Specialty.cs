namespace San11Helper
{
    public /*static*/ sealed class Specialty
    {
        public static readonly SpecialtyID weapon = 1;
        public static class weapons
        {
            public static readonly SpecialtyID spear = weapon[0];
            public static readonly SpecialtyID sword = weapon[1];
            public static readonly SpecialtyID crossbow = weapon[2];
            public static readonly SpecialtyID horse = weapon[3];
            public static readonly SpecialtyID ram = weapon[4];
            public static readonly SpecialtyID escalade = weapon[5];
            public static readonly SpecialtyID ark = weapon[6];
        }


        public static readonly SpecialtyID citySpecialty = 2;
        public static class citySpecialties
        {
            public static readonly SpecialtyID metropolis = citySpecialty[0];
        }


        private Specialty()
        {
        }
    }
}
