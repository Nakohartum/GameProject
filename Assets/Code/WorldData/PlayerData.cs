using Player;
using UnityEngine;


namespace WorldData
{
    [CreateAssetMenu(fileName = "Player", menuName = "GameData/Player", order = 1)]
    public class PlayerData : ScriptableObject
    {
        #region Fields

        public PlayerStruct PlayerStruct;
        public GameObject Player;
        public Vector3 SpawnPosition;

        #endregion
    }
}
