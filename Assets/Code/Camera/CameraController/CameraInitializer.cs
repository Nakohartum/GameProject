using Interfaces;


namespace CameraSpace
{
    class CameraInitializer
    {
        #region Fields

        private ICameraFactory _cameraFactory;
        private IController _controller;

        #endregion

        #region Constructor

        public CameraInitializer(ICameraFactory cameraFactory)
        {
            _cameraFactory = cameraFactory;
            _controller = _cameraFactory.CreateCamera();
        }

        #endregion

        #region Methods

        public IController GetController()
        {
            return _controller;
        }

        #endregion
    }
}
