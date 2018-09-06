using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneGoal : MonoBehaviour {

    [SerializeField]
    private CustomerBehaviour _customer;

	// Use this for initialization
	void Update () {
        _customer = GameObject.FindGameObjectWithTag("Customer").GetComponent<CustomerBehaviour>();

	}
	

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Customer"))
        {
            Debug.Log("goal");
            _customer.Death();
        }
    }
}
