using System.Text.Json.Serialization;

namespace ExpenseTracker.API.Model;

public class Category
{
    public int Id{ get; set;}
    public string? Name { get; set;}

    [JsonIgnore]
    public List<Expense> Expenses { get; set; } = [];
}
