using System;
using System.Collections.Generic;

namespace Memos.Models
{
    public class User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string job_title { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime dob { get; set; }
		public List<Comment> comments { get; set; }
        public List<Memo> memos { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }

		public User() {}
    }
}
