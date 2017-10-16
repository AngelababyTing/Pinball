using UnityEngine;
using System.Collections;

public class LeftPaddle : MonoBehaviour {

    public float maxAngle = -45.0f;
    public float flipTime = 0.01f;
    public string buttonName = "LeftPaddleAxis";

    private Quaternion initialOrientation;
    private Quaternion finalOrientation;
    private float t;

	// Use this for initialization
	void Start () {
        initialOrientation = transform.rotation;
        finalOrientation.eulerAngles = new Vector3(initialOrientation.eulerAngles.x, initialOrientation.eulerAngles.y + maxAngle, initialOrientation.eulerAngles.z);
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetButton(buttonName))
        {
            transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t / flipTime);
            t += Time.deltaTime;
            if (t > flipTime)
            {
                t = flipTime;
            }
        }
        else {
            transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t / flipTime);
            t -= Time.deltaTime;
            if (t < 0)
            {
                t = 0;
            }
        }
	
	}
}
