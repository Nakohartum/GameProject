using UnityEngine;


namespace Interfaces
{
    public interface ICameraFactory : IController
    {
        CameraController CreateCamera();
    }
}
