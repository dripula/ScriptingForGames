using UnityEngine;

public class TransformController : MonoBehaviour
{
    

    void Update()
    {

        var x = Mathf.PingPong(Time.time, 3); transform.position = new Vector3(x,0,0);
        
        transform.Rotate(new Vector3(0,60,0) * Time.deltaTime);

    }
}
