using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] spawners;
    private GameObject[] objects;
    private float rate;
    private float time;
    void Start()
    {
        InvokeRepeating("gameTick", 1f, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void gameTick() {
        if(Random.Range(0f,1f)>rate){
            Random.Range(0,spawners.Length);
            Instantiate(objects[Random.Range(0,objects.Length)], spawners[Random.Range(0,spawners.Length)].transform.position, Quaternion.identity);
        }

    }
}
