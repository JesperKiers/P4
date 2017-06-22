using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillBoost : MonoBehaviour {
    public float baseBoost;
    public GameObject thePlayer;
    public Movement require;
	// Use this for initialization
	void Start ()
    {
        thePlayer = GameObject.Find("Player");
        require = thePlayer.GetComponent<Movement>();
	}
	
    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "player")
        {
            if (require.boostCount < baseBoost)
            {
                require.boostCount = baseBoost;
                Destroy(gameObject);
            }
        }
    }
}
