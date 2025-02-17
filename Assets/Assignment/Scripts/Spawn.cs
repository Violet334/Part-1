using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
    //script for spawning platforms and boosts
{
    public GameObject platform;
    float time = 2;
    float spawnRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //add space between spawns
        if(time < spawnRate)
        {
            time += Time.deltaTime;
        }
        else
        {
            //spawn object
            float startrange = transform.position.x - 13;
            float endrange = transform.position.x + 13;
            //boost spawn point is placed slightly higher than the platform spawn point
            Instantiate(platform, new Vector3(Random.Range(startrange, endrange), transform.position.y), transform.rotation);
            time = 0;
        }
    }
}
