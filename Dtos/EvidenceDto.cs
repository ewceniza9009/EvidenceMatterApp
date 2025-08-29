using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Dtos;

public class EvidenceDto
{
    public int EvidenceId { get; set; }
    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Serial number is required")]
    public string SerialNumber { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "You must select a matter")]
    public int MatterId { get; set; }

    public string MatterName { get; set; }
}