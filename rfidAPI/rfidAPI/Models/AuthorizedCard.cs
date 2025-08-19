using System;
using System.ComponentModel.DataAnnotations;

namespace rfidAPI.Models
{
    public class Card
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string KID { get; set; } = string.Empty; // Kart UID

        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(50)]
        public string SName { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public bool Yetki { get; set; } = false; // Geçiş izni
    }
}
