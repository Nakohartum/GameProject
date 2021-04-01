using Interfaces;


namespace NPC
{
    public class NPCModel
    {
        public INPC NPCInfo;

        public NPCModel(INPC NPCInfo, IQuest quest)
        {
            this.NPCInfo = NPCInfo;
            this.NPCInfo.Quest = quest;
        }
    }
}
