using Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WorldData
{
    [CreateAssetMenu(fileName = "Player", menuName = "GameData/Player", order = 1)]
    public class PlayerData : ScriptableObject
    {
        public PlayerStruct PlayerStruct;
        public GameObject Player;
        public Vector3 SpawnPosition;
    }
}
