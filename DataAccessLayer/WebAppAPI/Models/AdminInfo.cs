using System.ComponentModel.DataAnnotations;
using WebAppAPI.Data;

namespace WebAppAPI.Models
{
    public class AdminInfo
    {
        [Key]
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}



       

