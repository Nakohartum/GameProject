using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Moral
{
    public class MoralModel 
    {
        public IMoral MoralStruct;

        public MoralModel(IMoral moralStruct)
        {
            MoralStruct = moralStruct;
        }
    }
}
