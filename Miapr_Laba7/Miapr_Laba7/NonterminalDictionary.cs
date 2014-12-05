using System.Collections.Generic;

namespace Miapr_Laba7
{
    public class NonterminalDictionary
    {
        public NonterminalDictionary()
        {
            Items = new List<CustomLine>();
        }

        public List<CustomLine> Items { get; set; }
    }
}