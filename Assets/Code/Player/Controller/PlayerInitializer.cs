using Interfaces;

namespace Player
{
    class PlayerInitializer : IInitializable
    {
        private IPlayerFactory _playerFactory;
        private IController _playerController;
        private PlayerView _playerView;

        public PlayerInitializer(IPlayerFactory playerFactory, (IInputProvider horizontal, IInputProvider vertical) input)
        {
            _playerFactory = playerFactory;
            _playerController = _playerFactory.Create(input);
            _playerView = _playerFactory.GetPlayerView();
        }

        public PlayerView GetPlayerView()
        {
            return _playerView;
        }

        public IController GetController()
        {
            return _playerController;
        }

        public void Initialize()
        {
            
        }
    }
}
