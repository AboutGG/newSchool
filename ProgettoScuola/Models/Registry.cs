using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProgettoScuola.Models;

[Table("registries")]
public class Registry
{
    [Column("id")]
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [Column("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [Column("surname")]
    [JsonPropertyName("surname")]
    public string Surname { get; set; }

    [Column("gender")]
    [JsonPropertyName("gender")]
    public String Gender { get; set; } 

    [Column("birth")]
    [JsonPropertyName("birth")]
    public DateOnly? Birth { get; set; }

    [Column("email")]
    [JsonPropertyName("email")]
    [EmailAddress]
    public string? Email { get; set; }

    [Column("address")]
    public string? Address { get; set; }

    [Column("telephone")]
    [JsonPropertyName("telephone")]
    [DataType(DataType.PhoneNumber)]
    [Phone]
    [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Invalid phone format")]
    public string? Telephone { get; set; }

    
    public Student? Student { get; set; }
    

    public Parent? Parent { get; set; }
}