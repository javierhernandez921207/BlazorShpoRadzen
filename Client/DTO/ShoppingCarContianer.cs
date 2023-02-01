namespace BlazorShpoRadzen.Client.DTO
{
    public class ShoppingCarContainer
    {
        public List<ProductCar> Products { get; set; } = new List<ProductCar>();

        public event Action ProductsChangeEvent;
        public void AddProduct(Product p, int c) {
            if (!Products.Any(pr => pr.product?.ProductId == p.ProductId))
                Products.Add(new ProductCar { product = p, count = c});
            else
                Products.FirstOrDefault(pr => pr.product.ProductId == p.ProductId).count += c;
            ProductsChangeEvent?.Invoke();
        }
        public void RemoveProduct(Product p)
        {
            foreach (var pr in Products) {
                if (pr.product.Equals(p))
                {
                    Products.Remove(pr);                    
                    ProductsChangeEvent?.Invoke();
                }
            }            
        }
        public void Notifi()
        {
            ProductsChangeEvent?.Invoke();
        }
    }
}
