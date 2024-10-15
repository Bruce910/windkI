using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandK.Model
{
    public class CMatch
    {
        //public int fMatchId { get; }
        public int fHelpId { get; set; }
        public string fMemberId { get; set; }

        public int fPoint { get; set; }
        public int fMatchStatus { get; set; }
        public int fGrade { get; set; }
        public string fMessage { get; set; }
        
    }
}
