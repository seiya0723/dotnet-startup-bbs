using System;

namespace StartupBBS.Models
{
    public class Comment
    {   
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public DateTime PostedAt { get; set; }
    }   
}

