using Interfaces;


namespace CameraSpace
{
    class CameraInitializer
    {
        private ICameraFactory _cameraFactory;
        private IController _controller;

        public CameraInitializer(ICameraFactory cameraFactory)
        {
            _cameraFactory = cameraFactory;
            _controller = _cameraFactory.CreateCamera();
        }

        public IController GetController()
        {
            return _controller;
        }
    }
}
