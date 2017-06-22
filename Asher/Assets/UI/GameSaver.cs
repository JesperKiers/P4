using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSaver : MonoBehaviour {
    public Text tekst;
    
	// Use this for initialization
	void Start () {

        
        if (PlayerPrefs.HasKey("test"))
        {
            print(PlayerPrefs.GetString("test"));
        }

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Prefs();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            tekst.text = PlayerPrefs.GetString("test");
        }
       
    }
    void Prefs()
    {
        PlayerPrefs.SetString("test", "dit is een test");
    }
}

