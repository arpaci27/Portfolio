using System.ComponentModel.DataAnnotations;

namespace Portfolio.DAL.Entities
{
    public class Testimonial
    {
        [Key]

        public int TestimonialID { get; set; }
        public string TestimonialName { get; set; }
        public string  Title {  get; set; }
    }
}
