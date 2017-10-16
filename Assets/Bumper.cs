using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bumper : MonoBehaviour {

    public GameObject nn;
    public float force = 500.0f;
    public float forceRadius = 1.0f;

    private Text text;
    private score s;
    private Rigidbody colRig;

    void Start()
    {
        text = nn.GetComponent<Text>();
        s = nn.GetComponent<score>();
    }
    void OnCollisionEnter(Collision  collision) {
        s.totalscore += 10;
        text.text = ""+s.totalscore;

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
