using BlazingLego.Data.Services;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BlazingLego.Data.Models;

public class LegoSet
{
    public int Id { get; set; }
    [Required]
    [JsonProperty("set_num")]
    [SetnumberValidator]
    public string? SetNumber { get; set;}

    [JsonProperty("name")]
    public string? Description { get; set; }
    public string? Image {get; set;}

    [JsonProperty("num_parts")]
    public string? TotalParts {get; set;}
    public string? Price { get; set; } = "€ 0.00";
    public string? Link {get; set;}
    public string? YearAcquired { get; set; } = DateTime.Now.Year.ToString();
    
    [JsonProperty("year")]
    public string? YearReleased { get; set; }
    public string? IsOnDisplay { get; set; }
}