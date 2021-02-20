using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Hunger
{
    [CreateAssetMenu(fileName = "Hunger", menuName = "GameData/Hunger", order = 2)]
    public class HungerData : ScriptableObject
    {
        public HungerStruct HungerStruct;
    }
}
