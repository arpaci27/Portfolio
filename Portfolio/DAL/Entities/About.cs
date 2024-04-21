using System.ComponentModel.DataAnnotations;

namespace Portfolio.DAL.Entities
{
    public class About
    {
        [Key]

        public int AboutID { get; set; }
        public string  Title { get; set; }
        public string SubDescription { get; set; }
        public string Details { get; set; }
    }
}
