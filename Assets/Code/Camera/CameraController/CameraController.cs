using CameraSpace;
using Interfaces;
using Player;
using UnityEngine;
using Extensions;


public class CameraController : IExecutable, ICleanable, IInitializable
{
    #region Fields

    private CameraModel cameraModel;
    private CameraView cameraView;
    private PlayerView playerView;
    private Camera _camera;

    #endregion

    #region Constructor

    public CameraController(CameraModel cameraModel, CameraView cameraView, PlayerView playerView)
    {
        this.cameraModel = cameraModel;
        this.cameraView = cameraView;
        this.playerView = playerView;
        _camera = cameraView.gameObject.GetOrAddComponent<Camera>();
    }

    #endregion

    #region Methods 

    public void Clean()
    {
        
    }

    public void Execute(float deltaTime)
    {
        RaycastHit hit;
        Ray ray = new Ray(cameraView.transform.position, playerView.transform.position);
        Physics.Raycast(cameraView.transform.position, playerView.transform.position, out hit, (cameraView.transform.position - playerView.transform.position).magnitude);
        if (hit.collider != null)
        {
            hit.collider.gameObject.GetComponent<MeshRenderer>().material.color.a = 0.5f;
        }
        Debug.DrawRay(cameraView.transform.position, playerView.transform.position, Color.red);
        _camera.transform.position = this.playerView.transform.position + cameraModel.CameraStruct.Offset;
        _camera.transform.LookAt(this.playerView.transform);
    }

    public void Initialize()
    {
        
    }

    #endregion
}
