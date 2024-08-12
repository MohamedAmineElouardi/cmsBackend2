using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CmsBackend.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public Role Role { get; set; }

        [Required(ErrorMessage = "RoleId is required")]
        public int? RoleId { get; set; } // Foreign key to Role

        [Required(ErrorMessage = "CIN is required")]
        [StringLength(20, ErrorMessage = "CIN can't be longer than 20 characters")]
        public string Cin { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(50, ErrorMessage = "Matricule can't be longer than 50 characters")]
        public string Matricule { get; set; }

        
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters")]
        public string Password { get; set; }


        [StringLength(50, ErrorMessage = "Username can't be longer than 50 characters")]
        public string Username { get; set; }
    }

}
