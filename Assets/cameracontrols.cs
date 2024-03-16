using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrols : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float ydistance = 171.3f;

        float step = 1.0f;

        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            transform.Translate(0, step, 0);
      

        }
        if (Input.GetKey(KeyCode.KeypadMinus))
        {
            transform.Translate(0, -step, 0);
 

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-step, 0, 0);
            float rotaY = (1 / (2 * Mathf.PI * ydistance)) * 100;
            transform.Rotate(0, rotaY, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(step, 0, 0);
            float rotaY = -(1 / (2 * Mathf.PI * ydistance)) * 100;
            transform.Rotate(0, rotaY, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, step);
            ydistance += step;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -step);
        }

    }

}