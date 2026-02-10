using UnityEngine;

public class shark : MonoBehaviour
{
    float swimSpeed = .05f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0, 0, swimSpeed);
        transform.Translate(0, 0.05f, 0);
        
    }
}
