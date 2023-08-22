using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class Job
    {
        [Key]
        public int JobID { get; set; }
        public string JobName { get; set; }
    }
}