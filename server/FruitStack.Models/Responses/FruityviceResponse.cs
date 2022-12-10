namespace FruitStack.Models.Responses
{
    public class FruityviceResponse
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Order { get; set; }
        public NutritionResponse Nutritions { get; set; }


    }
}
