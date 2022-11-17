using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float move_speed = 0.5f;
    public float gravity = 9.8f;
    CharacterController controller;
    //private static Controller Instance1;
    public int collecItem = 0;
    public GameManager gmi;


    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movZ = Input.GetAxis("Vertical") *
            Vector3.forward * move_speed;
        Vector3 movX = Input.GetAxis("Horizontal") *
            Vector3.right * move_speed;
        Vector3 mov = transform.TransformDirection(movX + movZ);
        mov.y -= gravity * Time.deltaTime;
        controller.Move(mov);
        gmi.UpdatePensText(collecItem);
    }

    /*private void Awake()
    {
        Instance1 = this;
    }
    */

    public void AddCollectable()
    {
        collecItem++;
    }
    
}
