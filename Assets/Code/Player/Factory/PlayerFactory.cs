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
        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
        }
        public IController Create((IInputProvider horizontal, IInputProvider vertical) input)
        {
            PlayerModel playerModel = new PlayerModel(_playerData.PlayerStruct);
            _playerView = Object.Instantiate(_playerData.Player, _playerData.SpawnPosition, Quaternion.identity).GetOrAddComponent<PlayerView>();
            PlayerController playerController = new PlayerController(playerModel, _playerView, input);
            return playerController;
        }

        public PlayerView GetPlayerView()
        {
            return _playerView;
        }
    }
}
