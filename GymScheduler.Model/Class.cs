using System.ComponentModel.DataAnnotations;

namespace GymScheduler.Model
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DayOfTheWeek { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int TeacherId { get; set; }

        [Required]
        public int MatRoomId { get; set; }

        [Required]
        public int ClassTypeId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public Teacher Teacher { get; set; }

        [Required]
        public MatRoom MatRoom { get; set; }

        [Required]
        public ClassType ClassType { get; set; }
    }
}
