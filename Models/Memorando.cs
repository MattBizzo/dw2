using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memos.Models
{
    public class Memorando
    {

        public string Logo { get; set; }

        public string Local { get; set; }

        public  string Data { get; set; }

        public int Id { get; set; }

        public string Setor { get; set; }

        public string Assunto { get; set; }
    }
}