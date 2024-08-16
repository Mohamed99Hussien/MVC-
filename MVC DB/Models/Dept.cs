namespace MVC_DB.Models
{
    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }

        public virtual ICollection<INS> Instructors { get; set; }
    }
}
