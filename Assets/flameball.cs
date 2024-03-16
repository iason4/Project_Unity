using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class flameball : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource source;

    void Explode()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();

    }



    // Grenade explodes on impact.
    void OnCollisionEnter(Collision collision)
    {
        source = GetComponent<AudioSource>();

        Explode();
        if (GetComponent<AudioSource>().enabled == false )
        {
            GetComponent<AudioSource>().enabled = true;

            source.PlayOneShot(clip);
        }
       

        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }


    // Update is called once per frame
    void Update()
    {

        //generate random position 
        float xscale = Random.Range(10.0f, 30.0f);
        

        if (Input.GetKey(KeyCode.Space))
        {
            if (GetComponent<Renderer>().enabled == false)
            {
                GetComponent<Renderer>().enabled = true;
                GetComponent<Collider>().enabled = true;
            }
            transform.localScale = new Vector3(xscale, xscale, xscale);
        }
    }
}