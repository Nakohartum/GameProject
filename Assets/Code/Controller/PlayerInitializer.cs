using Moral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class PlayerInitializer : IInitializable
    {
        private IPlayerFactory _playerFactory;
        private IController _controller;
        private PlayerView _playerView;


        public PlayerInitializer(IPlayerFactory playerFactory, (IInputProvider vertical, IInputProvider horizontal, IInputProvider jump) input, MoralProvider moralProvider)
        {
            _playerFactory = playerFactory;
            _controller = _playerFactory.Create(input, moralProvider);
        }

        public IController GetController()
        {
            return _controller;
        }


        public void Initialize()
        {
            
        }
    }
}
