using Interfaces;
using Player;


namespace Moral
{
    public class MoralInitializer : IInitializable
    {
        private IMoralFactory _moralFactory;
        private IController _moralController;
        private MoralView _moralView;
        private IMoralProvider moralProvider;
        public MoralInitializer(IMoralFactory moralFactory, PlayerView playerView, IMoralProvider moralProvider)
        {
            _moralFactory = moralFactory;
            this.moralProvider = moralProvider;
            _moralController = _moralFactory.Create(playerView);
            _moralView = _moralFactory.GetMoralView();
        }

        public IController GetController()
        {
            return _moralController;
        }

        public MoralView GetMoralView()
        {
            return _moralView;
        }

        public void Initialize()
        {
            
        }
    }
}
