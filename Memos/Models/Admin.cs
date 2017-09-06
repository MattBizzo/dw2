using System;

namespace Memos.Models
{
    public class Admin
    {
		public int id { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }

        public Admin() {}
    }
}
