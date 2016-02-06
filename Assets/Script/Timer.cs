using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Timer : MonoBehaviour {
    public Image BarTimer;
    public float DecreaseAmount;
	// Update is called once per frame
	void Update () {
        BarTimer.fillAmount -= DecreaseAmount * Time.deltaTime;

        if(BarTimer.fillAmount <= 0f)
        {
            print("EndLevel");
            this.enabled = false;
        }
	
	}
}
