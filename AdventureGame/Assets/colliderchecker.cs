using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderchecker : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
