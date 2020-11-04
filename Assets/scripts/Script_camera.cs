using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 /* Uparrow=up, downarrow=down, leftarrow=turn left, rightarrow= turn right*/

public class Script_camera : MonoBehaviour
{
    public GameObject obj;
    public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;



    void Update()
    {
        //float h = Input.GetAxis("Horizontal");
        //float xPos = h * range;

        // obj.transform.position = new Vector3(xPos, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            obj.transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            obj.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

    }
}
