using System.ComponentModel.DataAnnotations;

namespace SMSApp_School_.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }    
        public int Grade {  get; set; }
        public int GenderId {  get; set; }
        public string ParentsName {  get; set; }
        public string Address {  get; set; }
        public int CourseId {  get; set; }
        public int BatchId {  get; set; }

    }
}
