using Interfaces;
using UnityEngine;

namespace Quests
{
    public class Quest : IQuest
    {
        public GameObject QuestObject { get; set; }
    }
}
