using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeCounter : MonoBehaviour {

    Text timeDisplay;
    float time;
	// Use this for initialization
	void Start () {
        timeDisplay = GetComponent<Text>();
        time = 0;
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(time);
        time += Time.deltaTime;
        timeDisplay.text = "" + (int)time;
    }
}
