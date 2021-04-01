using NPC;
using UnityEngine;


namespace WorldData
{
    [CreateAssetMenu(fileName = "NPC", menuName = "GameData/NPC")]
    public class NPCData : ScriptableObject
    {
        public NPCInfo NPCInfo;
        public GameObject NPCObject;
        public Vector3 SpawnPosition;
    }
}
