namespace ProductSystem;

public class ProductManager
{
    private const decimal ElectronicsTaxRate = 0.10m;
    private const decimal FoodTaxRate = 0.05m;

    public List<Product> ProductsList = [];

    public void AddProduct(Product product)
    {
        ArgumentNullException.ThrowIfNull(product);

        if (product.Price < 0)
        {
            throw new ArgumentOutOfRangeException("No se puede agregar un producto con precio negativo.");
        }

        ProductsList.Add(product);
    }

    public decimal CalculateTotalPrice(Product product)
    {
        ArgumentNullException.ThrowIfNull(product);

        decimal taxRate = product.Category switch
        {
            Product.CategoryElectronics => ElectronicsTaxRate,
            Product.CategoryFood => FoodTaxRate,
            _ => throw new ArgumentException("El producto tiene una categoría no permitida.")
        };

        return product.Price * (1 + taxRate);
    }

    public Product? FindProductByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return null;
        }

        string searchedName = name.Trim();

        return ProductsList.FirstOrDefault(
            product => string.Equals(product.Name, searchedName, StringComparison.OrdinalIgnoreCase)
        );
    }
}
