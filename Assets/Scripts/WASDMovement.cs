using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public float speed;
    public CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        this.move();
    }

    void move()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        //Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
        //transform.position += moveDirection * speed;
        Vector3 moveDirection = transform.right * xDirection + transform.forward * zDirection;
        controller.Move(moveDirection * speed * Time.deltaTime);
    }

}
