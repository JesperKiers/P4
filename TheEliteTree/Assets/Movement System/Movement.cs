using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Vector3 move;
    public float hor;
    public float dia;
    public float speed;
    public Vector3 rot;
    public Vector3 turn;
    public RaycastHit hit;
    public GameObject cam;
    public float range;
    public float boost;
    public float baseSpeed;
    public float boostCount;
    
	// Use this for initialization
	void Start ()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        Debug.DrawRay(cam.transform.position, cam.transform.forward * range, Color.blue, 2f);
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range);
        Boosten();
    }
    void Moving()
    {
        rot.x = Input.GetAxis("Mouse Y");
        turn.y = Input.GetAxis("Mouse X");

        dia = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");

        move.x = hor;
        move.z = dia;

        cam.transform.Rotate(rot);
        transform.Rotate(turn);
        transform.Translate(move * Time.deltaTime * speed);

    }
    public void Boosten()
    {
        if (boostCount > 0)
        {
            if (Input.GetButton("Tee"))
            {
                speed = boost;
                boostCount -= Time.deltaTime;
            }
        }
        else
        {
            speed = baseSpeed;
        }
    }
}
