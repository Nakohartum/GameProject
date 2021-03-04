using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WorldData
{
    [CreateAssetMenu(fileName = "WorldData", menuName = "GameData/WorldData", order = 0)]
    public class Data : ScriptableObject
    {
        public CameraData CameraData;
        public PlayerData PlayerData;
    }
}
