using System.ComponentModel.DataAnnotations;

namespace Portfolio.DAL.Entities
{
    public class Feature
    {
        [Key]

        public int FeatureID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
