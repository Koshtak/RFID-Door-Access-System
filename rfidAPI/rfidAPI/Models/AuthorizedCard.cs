using System;
namespace rfidAPI.Models
{
    public class AuthorizedCard
    {
        public int Id { get; set; }
        public string CardUID { get; set; } = string.Empty; // Default value added
        public string UserName { get; set; } = string.Empty; // Default value added
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
