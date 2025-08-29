using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Dtos;

public class MatterDto
{
    public int MatterId { get; set; }

    [Required(ErrorMessage = "Matter name is required")]
    public string MatterName { get; set; }

    [Required(ErrorMessage = "Client name is required")]
    public string ClientName { get; set; }
}