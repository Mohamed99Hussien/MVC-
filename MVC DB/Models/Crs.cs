namespace MVC_DB.Models
{
    public class Crs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }

        public int INSId { get; set; }
        public virtual INS Instructor { get; set; }

        public virtual ICollection<CrsRes> CrsResults { get; set; }
    }

}
