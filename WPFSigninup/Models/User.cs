using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace WPFSigninup.Models
{
    [Index(nameof(Identity), IsUnique = true)]
    [Index(nameof(Username), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public partial class User
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(10)]
        public string Identity { get; set; }

        [Required, StringLength(25)]
        public string FirstName { get; set; }
        [Required, StringLength(25)]
        public string LastName { get; set; }

        [Required, StringLength(25)]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required, StringLength(25, MinimumLength = 6, ErrorMessage = "Min 6, Max 25 letters")]
        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTimeOffset Created_at { get; set; } = DateTimeOffset.Now;

        public User() { }
        public User(string Identity, string FirstName, string LastName, string Username, string Email, string Password, DateTime dateOfBirth)
        {
            this.Identity = Identity;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.DateOfBirth = dateOfBirth;
        }
    }

    public partial class User
    {
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public override string ToString() => $"{ID}: {FullName} => Username: {Username} | Password: {Password}";
    }
}
