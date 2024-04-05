using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ProgettoScuola.Models;

[Table("users")]
public class User
{
    /// <summary> User id </summary>
    [Column("id")]
    [JsonProperty("id")]
    public Guid Id { get; set; }

    /// <summary> User username </summary>
    [Column("username")]
    [JsonProperty("username")]
    public string Username { get; set; }

    /// <summary> User password </summary>
    [Column("password")]
    [JsonProperty("password")]
    public string Password { get; set; }

    /// <summary> Student key </summary>
    public Student? Student { get; set; }

    public Parent? Parent { get; set; }
}