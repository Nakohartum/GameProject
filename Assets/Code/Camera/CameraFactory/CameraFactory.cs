using Interfaces;
using UnityEngine;
using Extensions;
using Player;
using WorldData;


namespace CameraSpace
{
    public class CameraFactory : ICameraFactory
    {
        #region Fields

        private CameraData _cameraData;
        private PlayerView _playerView;

        #endregion

        #region Constructor

        public CameraFactory(CameraData cameraData, PlayerView playerView)
        {
            _cameraData = cameraData;
            _playerView = playerView;
        }

        #endregion

        #region Methods

        public CameraController CreateCamera()
        {
            var cameraModel = new CameraModel(_cameraData.CameraStruct);
            var cameraView = Object.Instantiate(_cameraData.Camera, Vector3.zero, Quaternion.identity).GetOrAddComponent<CameraView>();
            var controller = new CameraController(cameraModel, cameraView, _playerView);
            return controller;
        }

        #endregion
    }
}
