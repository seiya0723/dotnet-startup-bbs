using System;

namespace StartupBBS.Models
{
    public class Comment
    {   
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Content { get; set; }
        public DateTime PostedAt { get; set; }
    }   
}

