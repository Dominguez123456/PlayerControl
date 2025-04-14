using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningPropellar : MonoBehaviour
{
    public float rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spin lil bro 
        transform.Rotate(Vector3.forward * rotation * Time.deltaTime);
    }
}
