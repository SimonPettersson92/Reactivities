using System;

namespace Application.Profiles
{
    public class UserActivityDTO
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Category { get; set; }
        public DateTime Date { get; set; }
    }
}