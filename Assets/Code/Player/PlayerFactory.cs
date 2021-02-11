
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Extesnsions;

namespace Player
{
    public class PlayerFactory : IPlayerFactory
    {
        private PlayerData _playerData;

        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
        }
        public IController Create((IInputProvider vertical, IInputProvider horizontal, IInputProvider jump) input)
        {
            var camera = Camera.main;
            var model = new PlayerModel(_playerData.PlayerStruct);
            var player = Object.Instantiate(_playerData.PlayerObject, _playerData.PlayerSpawnPosition, Quaternion.identity);
            var view = player.GetOrAddComponent<PlayerView>();
            camera.transform.parent = view.transform;
            camera.transform.position += new Vector3(0, 8, -5);
            camera.transform.LookAt(view.transform);
            var rigidbody = player.GetOrAddComponent<Rigidbody>();
            rigidbody.freezeRotation = true;
            var controller = new PlayerController(model, view, input);
            return controller;
        }
    }
}
