using System.ComponentModel.DataAnnotations;

namespace WebAppAPI.Models
{
    public class EmpInfo
    {
        [Key]
        public string EmailId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int PassCode { get; set; }
    }

}
