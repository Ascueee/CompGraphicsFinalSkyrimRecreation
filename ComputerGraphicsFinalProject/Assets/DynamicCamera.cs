using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicCamera : MonoBehaviour
{
    [SerializeField] Transform posOne, posTwo;
    [SerializeField] GameObject cam;
    [SerializeField] float rotationSpeed;
    bool rotate;
    // Start is called before the first frame update
    void Start()
    {
        rotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCams();
        RotateCamera();
    }

    void RotateCamera()
    {
        if(rotate == true)
        {
            cam.transform.Rotate(0, rotationSpeed, 0);
        }
        else if(rotate == false)
        {
            cam.transform.rotation = Quaternion.Euler(0, -85.759f, 0);
        }
    }
    void SwitchCams()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            cam.transform.position = posTwo.transform.position;
            rotate = true;
            
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            cam.transform.position = posOne.transform.position;
            rotate = false;
        }
    }
}
