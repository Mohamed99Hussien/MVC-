namespace MVC_DB.Models
{
    public class CrsRes
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        public int TraineeId { get; set; }
        public virtual Trainee Trainee { get; set; }

        public int CrsId { get; set; }
        public virtual Crs Courses { get; set; }
    }

}
