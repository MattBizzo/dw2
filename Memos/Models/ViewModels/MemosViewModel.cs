using System.Collections.Generic;

namespace Memos.Models.ViewModels
{
    public class MemosViewModel
    {
		public User User { get; set; }
		public List<Memo> Memos { get; set; }

        public MemosViewModel() {}
    }
}
