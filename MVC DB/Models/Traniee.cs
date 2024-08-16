namespace MVC_DB.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Address { get; set; }
        public string Grade { get; set; }

        public virtual ICollection<CrsRes> CrsResults { get; set; }
    }

}
