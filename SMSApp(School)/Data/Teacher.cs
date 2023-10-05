using System.ComponentModel.DataAnnotations;

namespace SMSApp_School_.Data
{
    public class Teacher
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public string Address {  get; set; }
        public string Department {  get; set; }
        public string Contact { get; set; }
        public string SubjectId { get; set; }


    }
}
