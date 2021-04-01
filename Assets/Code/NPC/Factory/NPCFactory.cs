using Extensions;
using Interfaces;
using Player;
using UnityEngine;
using WorldData;


namespace NPC
{
    public class NPCFactory : INPCFactory
    {
        private NPCView _npcView;
        private NPCData _npcData;

        public NPCFactory(NPCData npcData)
        {
            this._npcData = npcData;
        }

        public IController Create(PlayerView playerView)
        {
            var NPCModel = new NPCModel(_npcData.NPCInfo, );
            _npcView = Object.Instantiate(_npcData.NPCObject, _npcData.SpawnPosition, Quaternion.identity).GetOrAddComponent<NPCView>();
            var controller = new NPCController(NPCModel, _npcView);
            return controller;
        }

        public NPCView GetNPCView()
        {
            return _npcView;
        }
    }
}
