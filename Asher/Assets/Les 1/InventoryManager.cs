using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour {
    public bool follow;
    public GameObject myButton;
    public GameObject myItem;
    public GameObject slot;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(slot != null)
        {
            myItem.transform.position = Input.mousePosition;
        }
        
	}
    public void FollowMouse()
    {
        if (slot = null)
        {
            slot = null;
        }
    }
    public void OnClick()
    {
        myButton.GetComponent<Button>().onClick.AddListener(() => { FollowMouse(); });
    }
}
