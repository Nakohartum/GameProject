using Interfaces;
using Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using WorldData;
using Extensions;


namespace Moral
{
    public class MoralFactory : IMoralFactory
    {
        private MoralData _moralData;
        private MoralView _moralView;
        private IMoralProvider moralProvider;
        public MoralFactory(MoralData moralData, IMoralProvider moralProvider)
        {
            _moralData = moralData;
            this.moralProvider = moralProvider;
        }


        public IController Create(PlayerView playerView)
        {
            var moralModel = new MoralModel(_moralData.MoralStruct);
            _moralView = new GameObject(nameof(Moral)).GetOrAddComponent<MoralView>();
            _moralView.transform.parent = playerView.transform;
            var moralController = new MoralController(moralModel, _moralView, this.moralProvider);
            return moralController;
        }

        public MoralView GetMoralView()
        {
            return _moralView;
        }
    }
}
