using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour {
    public bool follow;
    public GameObject myButton;
    public GameObject myItem;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        FollowMouse();
	}
    public void FollowMouse()
    {
        follow = true;
        if (follow == true)
        {
            myItem.transform.position = Input.mousePosition;
        }
    }
    public void OnClick()
    {
        myButton.GetComponent<Button>().onClick.AddListener(() => { FollowMouse(); });
    }
}
