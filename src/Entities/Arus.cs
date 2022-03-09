namespace abstraindo_rpg_dotnet.Entities
{
    public class Arus
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Arus(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Arus()
        {
            
        }
    }
}