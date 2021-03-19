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

        public CameraInitializer(ICameraFactory cameraFactory, ICameraProvider cameraProvider)
        {
            _cameraFactory = cameraFactory;
            _controller = _cameraFactory.CreateCamera(cameraProvider);
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
