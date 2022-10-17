using Microsoft.AspNetCore.Authentication;

namespace MvcAssignment4.Models
{
    public class Entry
    {
        public int  Id { get; set; }
        public string? Category { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
