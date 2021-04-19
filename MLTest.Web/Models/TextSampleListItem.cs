using System.ComponentModel.DataAnnotations;

namespace MLTest.Models
{
    public class TextSampleListItem
    {
        public int Id { get; set; }
        [Display(Name = "Language")]
        public string Lang { get; set; }
        [Display(Name = "Language")]
        public string Text { get; set; }
    }
}