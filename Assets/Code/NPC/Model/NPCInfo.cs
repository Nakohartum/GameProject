using System;
using Interfaces;
using UnityEngine;


namespace NPC
{
    [Serializable]
    public struct NPCInfo : INPC
    {
        public IQuest Quest;
        IQuest INPC.Quest { get => Quest; set => Quest = value; }
    }
}

