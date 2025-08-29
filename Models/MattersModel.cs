using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class MattersModel
    {
        [Key]
        public int MatterId { get; set; }
        public string MatterName { get; set; }
        public string ClientName { get; set; }

        public virtual ICollection<EvidenceModel> Evidence { get; set; }
    }
}
