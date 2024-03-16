using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheroiControls : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = 0.1f;
        
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.z<=225)
            {
                transform.Translate(0, 0, step);
            }

 
        }
        if (Input.GetKey(KeyCode.X))
        {
            if (transform.position.z >= -225)
            {
                transform.Translate(0, 0, -step);
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x <= 225)
            {
                transform.Translate(step, 0, 0);
            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x >= -225)
            {
                transform.Translate(-step, 0, 0);
            }

        }
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y <= 600)
            {
                transform.Translate(0, step, 0);
            }

        }
        if (Input.GetKey(KeyCode.E))
        {
            if (transform.position.y >= 125)
            {
                transform.Translate(0, -step, 0);
            }

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "flame")
        {

            Destroy(this.gameObject);
            if (GetComponent<MeshRenderer>().enabled == false)
            {
                GetComponent<MeshRenderer>().enabled = true;
            }

            

        }

    }
}
