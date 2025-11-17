namespace PustokPB306.Models
{
    public class Slide:BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
