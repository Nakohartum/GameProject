using CameraSpace;
using Interfaces;
using Player;
using UnityEngine;
using Extensions;
using System;

public class CameraController : IExecutable, ICleanable, IInitializable
{
    #region Fields

    private CameraModel cameraModel;
    private CameraView cameraView;
    private PlayerView playerView;
    private Camera _camera;
    private ICameraProvider _cameraProvider;

    #endregion

    #region Constructor

    public CameraController(CameraModel cameraModel, CameraView cameraView, PlayerView playerView, ICameraProvider cameraProvider)
    {
        this.cameraModel = cameraModel;
        this.cameraView = cameraView;
        this.playerView = playerView;
        _camera = cameraView.gameObject.GetOrAddComponent<Camera>();
        _cameraProvider = cameraProvider;
        _cameraProvider.OnPlayerTeleport += CameraBackgroundChange;
    }

    private void CameraBackgroundChange()
    {
        
    }

    #endregion

    #region Methods 

    public void Clean()
    {
        
    }

    public void Execute(float deltaTime)
    {
        RaycastHit hit;
        Ray ray = new Ray(cameraView.transform.position, playerView.transform.position - cameraView.transform.position);
        Physics.Raycast(ray, out hit, (cameraView.transform.position - playerView.transform.position).magnitude);
        _camera.transform.position = new Vector3(this.playerView.transform.position.x + cameraModel.CameraStruct.Offset.x, this.playerView.transform.position.y + cameraModel.CameraStruct.Offset.y, cameraModel.CameraStruct.Offset.z);
        
        
    }

    

    public void Initialize()
    {
        
    }

    #endregion
}
