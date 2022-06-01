using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace San11Helper
{
    class General
    {
        string _recommendArm = string.Empty;

        public bool Animation { get; set; } = false;
        public int Rank { get; set; } = 0;
        public string RankName { get; set; } = string.Empty;
        public string RecommendArm {
            get {
                if (string.IsNullOrEmpty(_recommendArm))
                {
                    SpecialtyID s = Specialty.weapon;
                    return s[Arm.IndexOf(Arm.Max())].ToString<Specialty>();
                }

                return _recommendArm;
            }
            set
            {
                _recommendArm = value;
            }
        }
        public City City { get; set; } = null;
        public Nation Belong { get; set; } = null;

        public List<int> Dimensions { get; set; } = new List<int>(5);
        public List<int> Arm { get; set; } = new List<int>(6);
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
