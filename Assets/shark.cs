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
        float move = 0f;
        float turn = 0f;
    

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            turn = 1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            turn = -1f;
        }
    

        transform.Rotate(0, 0, turn*turnSpeed);
        transform.Translate(0, move*moveSpeed, 0);
        
    }
}
