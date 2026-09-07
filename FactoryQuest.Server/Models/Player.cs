namespace FactoryQuest.Server.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Level { get; set; }

        public int Experience { get; set; }

        public int Gold { get; set; }
    }
}