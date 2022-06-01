namespace San11Helper
{
    class City
    {
        public bool Empeor { get; set; } = false;
        public string Name { get; set; }
        public SpecialtyID Specialty { get; set; } = SpecialtyID.root;
        public Nation Belong { get; set; } = null;


        public City(string name, SpecialtyID specialty, Nation belong = null, bool emperor = false)
        {
            Name = name;
            Specialty = specialty;
            Belong = belong;
            Empeor = emperor;
        }
    }
}
