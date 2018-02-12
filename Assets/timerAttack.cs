using System;
using UnityEngine;
using UnityEngine.UI;

public class timerAttack : MonoBehaviour {

    public Text text;
    public bool GAMESTAND = true;
    // Use this for initialization
    void Start () {
		
	}
    
    // Update is called once per frame
    void Update () {

        if (GAMESTAND) {

            var t = TimeSpan.FromSeconds(Time.time);
            text.text = string.Format("{0}:{1} ", t.Seconds, (t.Milliseconds) / 10);
        }

        else {
            text.text = ("Time is Over");
        }
         
    }

    
}
