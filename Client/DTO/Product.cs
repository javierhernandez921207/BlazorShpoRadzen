namespace BlazorShpoRadzen.Client.DTO
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public string ProductId { get; set; }   = Guid.NewGuid().ToString();
        public double Price { get; set; }
        public string image { get; set; }
    }
}
