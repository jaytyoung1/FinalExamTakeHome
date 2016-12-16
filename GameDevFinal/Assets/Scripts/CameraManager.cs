using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour
{
    public int startingCamera = 0;
    static int cameraIndex;
    public Camera[] mainCameras;

    void Start ()
    {
        cameraIndex = startingCamera;
        updateCamera(cameraIndex);
    }

    void Update ()
    {
        //if the user presses Tab, switch to the next camera
	    if (Input.GetKeyUp(KeyCode.Tab))
            switchCamera(cameraIndex);
    }

    //makes mainCamera[camera] visible, the rest inactive
    void updateCamera(int camera)
    {

        for (int i = 0; i < mainCameras.Length; i++)
        {
            if (i == camera)
                mainCameras[i].enabled = true;
            else
                mainCameras[i].enabled = false;
        }
        //Debug.Log("Displaying camera " + camera);
    }

    void switchCamera(int currentCamera)
    {
        switch (currentCamera)
        {
            case 4:
                cameraIndex = 0;
                updateCamera(cameraIndex);
                break;
            case 3:
                cameraIndex++;
                updateCamera(cameraIndex);
                break;
            case 2:
                cameraIndex++;
                updateCamera(cameraIndex);
                break;
            case 1:
                cameraIndex++;
                updateCamera(cameraIndex);
                break;
            case 0:
                cameraIndex++;
                updateCamera(cameraIndex);
                break;
        }
    }
}