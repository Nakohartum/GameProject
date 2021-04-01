using Interfaces;
using Player;


namespace NPC
{
    public class NPCInitializer : IInitializable
    {
        private IController _controller;
        private NPCView _npcView;
        private INPCFactory _npcFactory;

        public NPCInitializer(INPCFactory npcFactory, PlayerView playerView)
        {
            this._npcFactory = npcFactory;
            _controller = _npcFactory.Create(playerView);
            _npcView = _npcFactory.GetNPCView();
        }

        public IController GetController()
        {
            return _controller;
        }

        public NPCView GetNPCView()
        {
            return _npcView;
        }

        public void Initialize()
        {
        }
    }
}
