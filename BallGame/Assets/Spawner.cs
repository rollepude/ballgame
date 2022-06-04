using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 2f;
    private float timer = 0f;
    public GameObject pipe;
    public float lenght;
    
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(Random.Range(-lenght, lenght), 0, 0);
    }


    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(Random.Range(-lenght, lenght), 0, 0);
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;

        
            Invoke("speed", 5);
       
        
        

    }
    
    public void speed()
    {
        
            maxTime = (maxTime - 0.0001f);
        
    }
}

