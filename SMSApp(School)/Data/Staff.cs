using System.ComponentModel.DataAnnotations;

namespace SMSApp_School_.Data
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Post {  get; set; }
        public string Address {  get; set; }
        public string Contact {  get; set; }
        public int GenderId {  get; set; }

    }
}
