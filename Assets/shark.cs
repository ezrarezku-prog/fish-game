using Unity.VisualScripting;
using UnityEngine;

public class shark : MonoBehaviour
{
    [SerializeField] float turnSpeed = 1f;
    [SerializeField] float moveSpeed = .005f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed);
        transform.Translate(0, moveSpeed, 0);
        
    }
}
