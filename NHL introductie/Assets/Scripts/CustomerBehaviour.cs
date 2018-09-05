using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehaviour : MonoBehaviour {
    private GameObject wayPoint;
    private Vector3 wayPointPos;

    public float MovementSpeed;

    public bool isTouchedBy1 = false;
    public bool isTouchedBy2 = false;

    public PlayerOne Player_one;
    public PlayerTwo Player_two;

    public GameObject Customer;
    

	// Use this for initialization
	void Start () {

        Player_one = this.GetComponent<PlayerOne>();
        Player_two = this.GetComponent<PlayerTwo>();
       
    
	}
	
	// Update is called once per frame
	void Update () {

		if(isTouchedBy1 == true)
        {         
            wayPoint = GameObject.Find("PlayerOneWayPoint");
            wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, wayPointPos, MovementSpeed * Time.deltaTime);
        }
        if (isTouchedBy2 == true)
        {
            wayPoint = GameObject.Find("PlayerTwoWayPoint");
            wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, wayPointPos, MovementSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("PlayerOne"))
        {
            isTouchedBy1 = true;
        }

        if (col.gameObject.CompareTag("PlayerTwo"))
        {
            isTouchedBy2 = true;
        }
    }
}
