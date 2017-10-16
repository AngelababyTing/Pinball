using UnityEngine;
using System.Collections;

public class PaddleForce : MonoBehaviour {

    public float force = 1000.0f;
    public Vector3 forceDirection = Vector3.forward;
    public string buttonName1 = "LeftPaddleAxis";
    public string buttonName2 = "RightPaddleAxis";
    public Vector3 offset;

    private Rigidbody body;

    // Use this for initialization
    void Start () {
        body = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton(buttonName1))
        {
            body.AddForceAtPosition(forceDirection.normalized * force, transform.position + offset);
        }
        else {
            body.AddForceAtPosition(forceDirection.normalized * -force, transform.position + offset);
        }
        if (Input.GetButton(buttonName2))
        {
            body.AddForceAtPosition(forceDirection.normalized * force, transform.position + offset);
        }
        else
        {
            body.AddForceAtPosition(forceDirection.normalized * -force, transform.position + offset);
        }

    }
}
