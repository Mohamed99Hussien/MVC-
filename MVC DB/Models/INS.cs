namespace MVC_DB.Models
{
    public class INS
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        //1
        public int DeptId { get; set; }
        public virtual Dept Department { get; set; }

        public virtual ICollection<Crs> Course { get; set; }
    }

}
