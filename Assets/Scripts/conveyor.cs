using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyor : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public List<GameObject> onBelt;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= onBelt.Count -1 ; i++){
            onBelt[i].GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col){
        onBelt.Add(col.gameObject);
    }
    private void OnCollisionExit(Collision col){
        onBelt.Remove(col.gameObject);
    }
}
