namespace EF21MigrationsIssue
{
    public class Bonus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool MultipliesPoints { get; set; }
        public int? MultiplyFactor { get; set; }
        public bool ConquerorsPoints { get; set; }
        public int? ConquerorAmount { get; set; }
        public bool RequireSuccess { get; set; }
        public double? Price { get; set; }
    }
}