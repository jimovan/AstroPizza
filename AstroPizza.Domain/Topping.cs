using AstroPizza.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace AstroPizza.Domain
{
    public class Topping : BaseEntity
    {
        [MinLength(3)]
        public string Name { get; set; }
        public bool IsVegetarian { get; set; }
    }
}
