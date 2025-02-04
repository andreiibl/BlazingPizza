using System.Text.Json.Serialization;

namespace BlazingPizza;

/// <summary>
///    /// Represents a customized pizza as part of an order
/// </summary>
public class Pizza
{
    public enum CookingLevel
    {
        PocoHecha,       // Poco hecha
        AlPunto, // Al punto
        Hecha,     // Hecha
        MuyHecha    // Muy hecha
    }
    public CookingLevel Cooking { get; set; } = CookingLevel.AlPunto; // Valor predeterminado

    public int Id { get; set; }

    public int OrderId { get; set; }

    public PizzaSpecial? Special { get; set; }

    public int SpecialId { get; set; }

    public List<PizzaTopping> Toppings { get; set; } = new();

    public decimal GetBasePrice()
    {
        if (Special == null) throw new NullReferenceException($"{nameof(Special)} was null when calculating Base Price.");
        return Special.BasePrice;
    }

    public decimal GetTotalPrice()
    {
        if (Toppings.Any(t => t.Topping is null)) throw new NullReferenceException($"{nameof(Toppings)} contained null when calculating the Total Price.");
        return GetBasePrice() + Toppings.Sum(t => t.Topping!.Price);
    }

    public string GetFormattedTotalPrice()
    {
        return GetTotalPrice().ToString("0.00");
    }
}

[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Serialization)]
[JsonSerializable(typeof(Pizza))]
public partial class PizzaContext : JsonSerializerContext { }