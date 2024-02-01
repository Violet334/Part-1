using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float move;
    public float moveSpeed = 50;
    public float acceleration = 1.5f;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        transform.Translate(move * moveSpeed * Time.deltaTime, 0, 0);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        transform.Translate(move * moveSpeed * acceleration * Time.deltaTime, 0, 0);
        Destroy(trigger);

    }

}
