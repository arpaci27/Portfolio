using System.ComponentModel.DataAnnotations;

namespace Portfolio.DAL.Entities
{
    public class Skills
    {
        [Key]

        public int SkillID { get; set; }
        public int Value { get; set; }
        public string Title { get; set; }
    }
}
