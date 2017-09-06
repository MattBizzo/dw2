using System;
using System.Collections.Generic;

namespace Memos.Models
{
    public class Memo
    {
		public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public User user { get; set; }
        public MemoCategory category { get; set; }
        public List<Comment> comments { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }

		public Memo() {}
    }
}
