using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
  public class UserDTO
  {
    public int ID { get; set; }
    [Required(ErrorMessage = "Please fill the Username area")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Please fill the Password area")]
    public string Password { get; set; }
    public string email { get; set; }
    public string Imagepath { get; set; }
    [Required(ErrorMessage = "Please fill the name area")]
    public string Name { get; set; }
    public bool isAdmin { get; set; }
    [Display(Name="User Image")]
    public HttpPostedFileBase UserImage { get; set; }
  }
}
