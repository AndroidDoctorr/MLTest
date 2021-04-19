using System.ComponentModel.DataAnnotations;

namespace MLTest.Models
{
    public class TextSampleCreate
    {
        [Required]
        public string Lang { get; set; }
        [Required]
        public string Text { get; set; }
    }
}