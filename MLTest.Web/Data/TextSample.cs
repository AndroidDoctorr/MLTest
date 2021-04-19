using System.ComponentModel.DataAnnotations;

namespace MLTest.Data
{
    public class TextSample
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Lang { get; set; }
        [Required]
        public string Text { get; set; }
    }
}