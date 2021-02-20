using Moral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Data", menuName = "GameData/Data", order = 1 )]
    class Data : ScriptableObject
    {
        public PlayerData PlayerData;
        public MoralData MoralData;
    }
}
