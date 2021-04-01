using Interfaces;


namespace NPC
{
    public class NPCController : IExecutable, ICleanable, IInitializable
    {
        private NPCModel nPCModel;
        private NPCView npcView;

        public NPCController(NPCModel nPCModel, NPCView npcView)
        {
            this.nPCModel = nPCModel;
            this.npcView = npcView;
        }

        public void Execute(float deltaTime)
        {
            throw new System.NotImplementedException();
        }


        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public void Clean()
        {
            throw new System.NotImplementedException();
        }
    }
}
