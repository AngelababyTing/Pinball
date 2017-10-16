using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bonus : MonoBehaviour {

    public GameObject tt;
    public float force = 500.0f;
    public float forceRadius = 1.0f;

    private Text text;
    private score s;
    private Rigidbody colRig;

    void Start()
    {
        text = tt.GetComponent<Text>();
        s = tt.GetComponent<score>();
    }
    void OnCollisionEnter(Collision collision)
    {
        s.totalscore += 100;
        text.text = "" + s.totalscore;

        foreach (Collider col in Physics.OverlapSphere(transform.position, forceRadius))
        {
            colRig = col.GetComponent<Rigidbody>();
            if (colRig)
            {
                colRig.AddExplosionForce(force, transform.position, forceRadius);
            }
        }
    }
}