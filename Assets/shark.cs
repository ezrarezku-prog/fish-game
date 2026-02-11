using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class shark : MonoBehaviour
{
    [SerializeField] float turnSpeed = 150f;
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float regularSpeed = 5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shrimpBoost"))
        {
            currentSpeed = boostSpeed;
        }
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

        float moveAmount = move * currentSpeed * Time.deltaTime;
        float turnAmount = turn * turnSpeed * Time.deltaTime;

        transform.Rotate(0, 0, turnAmount);
        transform.Translate(0, moveAmount, 0);



    }
}

