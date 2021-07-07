using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager manager;
    private Camera _camera;
    [SerializeField] Transform _player;
    [SerializeField] Transform _camPos;
    [SerializeField] Transform _introCam;
    [SerializeField] Transform _gameCam;
    [SerializeField] Transform _finishCam;
    private void Awake() 
    {
        manager = this;
    }
    private void Start() 
    {
        _camera = Camera.main;    
    }
    public void IntroCam()
    {
        CamFollow();
        if(_camera.transform.parent != _introCam)
        {
            _camera.transform.SetParent(_introCam);
        }
        CamLerp();
    }
    public void GameCam()
    {
        CamFollow();
        if(_camera.transform.parent != _gameCam)
        {
            _camera.transform.SetParent(_gameCam);
        }
        CamLerp();
    }
    public void FinishCam()
    {
        CamFollow();
        if(_camera.transform.parent != _finishCam)
        {
            _camera.transform.SetParent(_finishCam);
        }
        CamLerp();
    }
    private void CamLerp()
    {
        _camera.transform.localPosition = Vector3.Lerp(_camera.transform.localPosition, Vector3.zero, 
        Time.deltaTime *2);

        _camera.transform.localRotation = Quaternion.Lerp(_camera.transform.localRotation, Quaternion.identity,
        Time.deltaTime*2);
    }
    private void CamFollow()
    {
        _camPos.position = Vector3.Lerp(_camPos.position, _player.position, Time.deltaTime*5);
    }
    


}
