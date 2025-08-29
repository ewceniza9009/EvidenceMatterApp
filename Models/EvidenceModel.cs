using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class EvidenceModel
    {
        [Key]
        public int EvidenceId { get; set; }
        public int MatterId { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }

        public virtual MattersModel Matter { get; set; }

    }
}
