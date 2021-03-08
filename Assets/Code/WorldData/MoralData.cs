using UnityEngine;
using Interfaces;
using Moral;


namespace WorldData
{
    [CreateAssetMenu(fileName = "MoralData", menuName = "GameData/Moral", order = 3)]
    public class MoralData : ScriptableObject
    {
        public MoralStruct MoralStruct;
    }
}
