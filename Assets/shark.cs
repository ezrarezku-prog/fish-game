using UnityEngine;

public class shark : MonoBehaviour
{
    float turnSpeed = .1f;
    float moveSpeed = .005f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed);
        transform.Translate(0, moveSpeed, 0);
        
    }
}
