using System.ComponentModel.DataAnnotations;

namespace Portfolio.DAL.Entities
{
    public class SocialMedia
    {
        [Key]

        public int SocialMediaID { get; set; }
        public string SocialMediaTitle { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
