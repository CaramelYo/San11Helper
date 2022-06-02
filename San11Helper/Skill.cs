namespace San11Helper
{
    public enum SkillRank
    {
        useless,
        normal,
        good,
        great,
        god
    }

    public enum SkillType
    {
        attack,
        strategy,
        support,
        affair,
        other
    }

    public class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillRank Rank { get; set; }
        public SkillType Type { get; set; }


        public Skill(string n, string d, SkillRank r)
        {
            Name = n;
            Description = d;
            Rank = r;
        }

        public Skill(string n) : this(n, string.Empty, SkillRank.useless) { }
        
        public Skill() : this(string.Empty, string.Empty, SkillRank.useless) { }
    }
}
