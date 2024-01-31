using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject platform;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float startrange = transform.position.x - 13;
        float endrange = transform.position.x + 13;
        Instantiate(platform, new Vector3(Random.Range(startrange,endrange),transform.position.y), transform.rotation);
        
    }
}
