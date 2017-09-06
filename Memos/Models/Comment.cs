using System;

namespace Memos.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string content { get; set; }
        public User user { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public Comment() {}
    }
}
