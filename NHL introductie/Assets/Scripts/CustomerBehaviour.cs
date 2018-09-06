using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehaviour : MonoBehaviour {
    private GameObject wayPoint;
    private Vector3 wayPointPos;

    public GameObject player1;
    public GameObject player2;

    private float distanceToPlayer = 8f;

    public float MovementSpeed;

    public bool isTouchedBy1 = false;
    public bool isTouchedBy2 = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float dist1 = Vector3.Distance(player1.transform.position, transform.position);
        float dist2 = Vector3.Distance(player2.transform.position, transform.position);


        if (isTouchedBy1 == true)
        {
            if(dist1 > distanceToPlayer)
            {
                wayPoint = GameObject.Find("PlayerOneWayPoint");
                wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, wayPointPos, MovementSpeed * Time.deltaTime);
            }
        }
        if (isTouchedBy2 == true)
        {
            if (dist2 > distanceToPlayer)
            {
                wayPoint = GameObject.Find("PlayerTwoWayPoint");
                wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, wayPointPos, MovementSpeed * Time.deltaTime);
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("PlayerOneGoal"))
        {
            Debug.Log("test");
            Death();
        }

        if (col.gameObject.CompareTag("PlayerOne"))
        {
            isTouchedBy1 = true;
        }

        if (col.gameObject.CompareTag("PlayerTwo"))
        {
            isTouchedBy2 = true;
        }


    }

     public void Death()
    {
        Destroy(this.gameObject, 1f);
    }
}
