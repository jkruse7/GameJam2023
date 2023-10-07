using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cheese : ageableObject
{
    [SerializeField] private Material agedMaterial;
    [SerializeField] private Slider slider;
    [SerializeField] private float ageTime = 2;

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
            progress += (1 * Time.deltaTime);
            slider.value = progress/ageTime;
            GetComponent<Renderer>().material = agedMaterial;
            Debug.Log(progress);
            //isAged = true;
        }
        //var selectionRenderer = selection.GetComponent<Renderer>();
    }
}
