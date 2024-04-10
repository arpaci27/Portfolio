using System.ComponentModel.DataAnnotations;

namespace Portfolio.DAL.Entities
{
    public class Portfolios
    {
        public int PorftolioID { get; set; }
        public string Title { get; set; }
        public string SubTitle {  get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Description {  get; set; }

    }
}
