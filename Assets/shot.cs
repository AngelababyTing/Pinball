using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour {
    public GameObject ball;
    private Rigidbody ballrig;

    

	// Use this for initialization
	void Start () {
        GameObject instant = Instantiate(ball, transform.position, Quaternion.identity) as GameObject;
        ballrig = instant.GetComponent<Rigidbody>();
        ballrig.AddForce(new Vector3(0,0,8) * 250);

        
    }
    
	// Update is called once per frame
	void Update () {
	
	}
}
