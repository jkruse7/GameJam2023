using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : ageableObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void age(){
        if(!isAged){
            Debug.Log("aged");
            isAged = true;
        }
        //var selectionRenderer = selection.GetComponent<Renderer>();
    }
}
