using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FruitStack.Models.Responses.FruityviceResponse;

namespace FruitStack.Models.Responses
{
    public class FruitResponse
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Order { get; set; }
        public Nutrition Nutritions { get; set; }
        public IEnumerable<string> ImageUrls { get; set; }
    }
}
