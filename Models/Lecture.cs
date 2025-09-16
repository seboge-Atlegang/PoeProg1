namespace ProgPoe.Models
{
    public class Lecture
    {

        public string LecturerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation
        public List<MonthlyClaim> Claims { get; set; }
    }
    }

