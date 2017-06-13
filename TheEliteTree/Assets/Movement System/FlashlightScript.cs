using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour {
    public bool onOff;
    public GameObject flashLigt;
	
	void Update ()
    {
        Turn();
	}
    
    void Turn()
    {
        if (Input.GetButtonDown("flash"))
        {
            if(onOff == true)
            {
                onOff = false;
                flashLigt.SetActive(false);
            }
        else if (Input.GetButtonDown("flash"))
        {
                if (onOff == false)
                {
                    onOff = true;
                    flashLigt.SetActive(true);
                }
            }
        }
    }
}
