using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Moral
{
    [CreateAssetMenu(fileName = "Moral", menuName = "GameData/Moral", order = 3)]
    public class MoralData : ScriptableObject
    {
        public MoralStruct MoralStruct;
    }
}
