using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float MovementSpeed;
    public string PlayerName;
    public int Health;

    

 
	

    public void PlayerOneMovement()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * MovementSpeed * Time.deltaTime);
        }
    }

    public void PlayerTwoMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * MovementSpeed * Time.deltaTime);
        }
    }

    
}
