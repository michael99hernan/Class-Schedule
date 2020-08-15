
using System.ComponentModel.DataAnnotations;

namespace SchedulePicker.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
