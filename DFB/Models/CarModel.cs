namespace DFB.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
