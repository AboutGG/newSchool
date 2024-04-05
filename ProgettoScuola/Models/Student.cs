using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ProgettoScuola.Models;

[Table("students")]
public class Student
{
    /// <summary> User id </summary>
    [Column("id")]
    [JsonProperty("id")]
    public Guid Id { get; set; }
    
    [Column("classe")]
    [JsonProperty("classe")]
    public string Classe { get; set; }
    
    [Column("user_id")]
    [JsonIgnore]
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    
    [Column("registry_id")]
    [JsonIgnore]
    public Guid RegistryId { get; set; }
    public Registry Registry { get; set; } = null!;
    
    public Parent? Parent { get; set; }
}