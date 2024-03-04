using api.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace api.Data
{
    public class ApplicationDbContext
    {
        public List<User> User = new() {

               new User() { Id = 1, Name = "jean"},
               new User() { Id = 2, Name = "Manu"},
               new User() { Id = 3, Name = "Chrichri"}, };


    }
}
