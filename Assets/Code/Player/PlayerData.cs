using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Player", menuName = "GameData/Player", order = 0)]
    public class PlayerData : ScriptableObject
    {
        public PlayerStruct PlayerStruct;
        public Vector3 PlayerSpawnPosition;
        public GameObject PlayerObject;
    }
}
