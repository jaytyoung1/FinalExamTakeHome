using UnityEngine;
using System.Collections;

public class FogManager : MonoBehaviour
{
	void Update ()
    {
	    if (Input.GetKeyUp(KeyCode.F))
            RenderSettings.fog = !RenderSettings.fog;
	}
}
