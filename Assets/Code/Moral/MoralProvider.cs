using Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Moral
{
    public class MoralProvider : IInitializable
    {
        public float MoralAmountChange;

        public void SetMoralChange(float changer)
        {
            MoralAmountChange = changer;
        }

        public float GetMoralChange()
        {
            return MoralAmountChange;
        }

        public void Initialize()
        {
            
        }
    }
}
