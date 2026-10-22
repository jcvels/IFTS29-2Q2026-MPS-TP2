namespace ProductSystem;

public class Product
{
    public const string CategoryElectronics = "Electrónica";
    public const string CategoryFood = "Alimentos";

    public static Boolean IsValidCategory(string category)
    {
        Boolean check = category == CategoryElectronics || category == CategoryFood;
        return check;
    }

    public int Id { get; }

    public string Name { get; }

    public decimal Price { get; }

    public string Category { get; }

    public Product(int id, string name, decimal price, string category)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("El nombre del producto es obligatorio.");
        }

        if (price < 0)
        {
            throw new ArgumentOutOfRangeException("El precio base no puede ser negativo.");
        }

        if (!IsValidCategory(category))
        {
            throw new ArgumentException("La categoria indicada es invalida.");
        }

        Id = id;
        Name = name.Trim();
        Price = price;
        Category = category;
    }
}
