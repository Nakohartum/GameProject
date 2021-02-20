using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunger
{
    public enum HungerStatus { Low, Medium, High };
    [Serializable]
    public struct HungerStruct
    {
        public float HungerAmount;
        
        public HungerStatus HungerStatus;
    }
}
