using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : Player {


    public GameObject wayPoint;
    private float timer = 0.5f;
    public ParticleSystem specialActionButton;

    public List<GameObject> customers = new List<GameObject>();


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        SpecialActionButton();

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            UpdatePosition();
            timer = 0.5f;
        }
        
    }

    private void FixedUpdate()
    {
        PlayerTwoMovement();
    }

    void UpdatePosition()
    {
        wayPoint.transform.position = transform.position;
    }

    void SpecialActionButton()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Instantiate(specialActionButton, transform.position, transform.rotation);
            specialActionButton.Play();
        }
    }

}
