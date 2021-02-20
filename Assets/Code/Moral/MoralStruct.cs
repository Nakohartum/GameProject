using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moral
{
    public enum MoralStatus { Low, Medium, High };
    [Serializable]
    public struct MoralStruct
    {
        public float MoralAmount;
        public MoralStatus MoralStatus;
    }
}
