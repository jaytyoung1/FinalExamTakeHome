using UnityEngine;
using System.Collections;

public class WindManager : MonoBehaviour
{
    public WindZone windZone;

	// Use this for initialization
	void Start ()
    {
        windZone.windMain = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyUp(KeyCode.W))
        {
            if (windZone.windMain == 0)
                windZone.windMain = 1;
            else
                windZone.windMain = 0;
        }
	}
}
