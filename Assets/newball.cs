using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newball : MonoBehaviour
{
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int x = Random.Range(-200, 200);
            int y = Random.Range(600, 1000);


            Instantiate(ball, new Vector3(x,y,x), transform.rotation);
        }
    }
}
