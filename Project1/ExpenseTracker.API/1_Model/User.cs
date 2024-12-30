using System.Text.Json.Serialization;

namespace ExpenseTracker.API.Model;
public class User
{
    public int UserId{ get; set;}
    public string? Name{ get; set;} = "";
    public string? PhoneNumber{ get; set;}

    [JsonIgnore]
    public List<Expense> Expenses { get; set; } = [];
}