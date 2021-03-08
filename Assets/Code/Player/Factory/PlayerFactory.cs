using Interfaces;
using UnityEngine;
using WorldData;
using Extensions;

namespace Player
{
    public class PlayerFactory : IPlayerFactory
    {
        private PlayerData _playerData;
        private PlayerView _playerView;
        private IMoralProvider moralProvider;
        public PlayerFactory(PlayerData playerData, IMoralProvider moralProvider)
        {
            _playerData = playerData;
            this.moralProvider = moralProvider;
        }
        public IController Create((IInputProvider horizontal, IInputProvider vertical) input)
        {
            var playerModel = new PlayerModel(_playerData.PlayerStruct);
            _playerView = Object.Instantiate(_playerData.Player, _playerData.SpawnPosition, Quaternion.identity).GetOrAddComponent<PlayerView>();
            PlayerController playerController = new PlayerController(playerModel, _playerView, input, this.moralProvider);
            return playerController;
        }

        public PlayerView GetPlayerView()
        {
            return _playerView;
        }
    }
}
