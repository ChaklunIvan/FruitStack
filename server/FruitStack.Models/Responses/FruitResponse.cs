namespace FruitStack.Models.Responses
{
    public class FruitResponse
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Order { get; set; }
        public FruitNutritionsResponse Nutritions { get; set; }
    }
}
