using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class shark : MonoBehaviour
{
    [SerializeField] float turnSpeed = 1f;
    [SerializeField] float moveSpeed = .005f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Pushing forward");
        }

        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("Turning left");
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("Turning right");
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("Pushing back");
        }



        transform.Rotate(0, 0, turnSpeed);
        transform.Translate(0, moveSpeed, 0);
        
    }
}
