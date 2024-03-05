using MVC.Models;

namespace MVC.Data
{
    public class FakeDb
    {
        public List<User> Users { get; set; } = new List<User>()
        {
            new User(){Id = 1, Name="coco"},
            new User(){Id = 2, Name="jean"},
            new User(){Id = 3, Name="manu"},
            new User(){Id = 4, Name="chrichri"},
        };
    }
}
