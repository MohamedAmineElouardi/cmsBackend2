using System.Data;

namespace CmsBackend.Model
{
    public class User
    {
       


            public int Id { get; set; }
            public string Name { get; set; }
            public Role Role { get; set; }
            public int? RoleId { get; set; } // Foreign key to Role
            public string Cin { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public string Matricule { get; set; }
            public string Password { get; set; }
            public string Username { get; set; }
        }
   
}
