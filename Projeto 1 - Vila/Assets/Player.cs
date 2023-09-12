using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayerGO();
        rotateCameraWithMouse();
    }

    void movePlayerGO()
    {
        float right = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        Vector3 velocidadeX = transform.right * right * speed * Time.deltaTime;
        Vector3 velocidadeY = transform.forward * forward * speed * Time.deltaTime;
        transform.position += velocidadeX;
        transform.position += velocidadeY;   
    }

    void rotateCameraWithMouse()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(new Vector3(0f, mouseX, 0f));
        Camera.main.transform.Rotate(new Vector3(-mouseY, 0f, 0f));   
    }
}
