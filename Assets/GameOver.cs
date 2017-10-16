using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public GameObject End;      
    private Rigidbody EndRig;

    void Start()
    {
         EndRig = End.GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        Application.LoadLevel(2);
        
    }
}

