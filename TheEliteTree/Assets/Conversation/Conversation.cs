using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour {
    public List<string> tekst = new List<string>();
    public int layer;
    public int stop;
	// Use this for initialization
	void Start ()
    {
        layer = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void OnClick()
    {
        if (layer < stop)
        {
            layer++;
            GameObject.Find("Main Camera").GetComponent<UIManager>().deTekst.text = tekst[layer];
        }
        else
        {
            layer = 0;
        }
    }
}
