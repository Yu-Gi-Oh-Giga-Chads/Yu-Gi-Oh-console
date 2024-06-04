using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Deck> Decks { get; set; }
        public User()
        {
            Decks = new List<Deck>();
        }

        public User(string? username, string? email, string? password)
            : this()
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
