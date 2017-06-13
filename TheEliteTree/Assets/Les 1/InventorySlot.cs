using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public bool occupied;
    public GameObject item;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Occupy();
    }
    void Occupy()
    {
        if (occupied == true)
        {
            item.transform.position = transform.position;
            occupied = false;
        }
    }
}
