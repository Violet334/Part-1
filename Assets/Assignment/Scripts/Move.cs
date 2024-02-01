using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
    //Movement script for platforms and speed boosting plates
{
    public float speed = 3;
    float bounds = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        //collision event does not seem to work, thus ensuring the objects will be destroyed
        if(transform.position.y > bounds)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
