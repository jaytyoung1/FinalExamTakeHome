using UnityEngine;
using System.Collections;

public class SunManager : MonoBehaviour
{
    public Light sun;
    public float startingXRotation = 0;
    static float currentXRotation;
    float thirtyMinutesInDegrees = 7.5f;

	void Start ()
    {
        currentXRotation = startingXRotation;
    }

    void Update ()
    {
	    if (Input.GetKeyUp(KeyCode.Space))
        {
            currentXRotation += thirtyMinutesInDegrees;
            sun.transform.eulerAngles = new Vector3(currentXRotation, 0, 0);
        }
	}
}
