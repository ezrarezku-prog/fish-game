using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class shark : MonoBehaviour
{
    [SerializeField] float turnSpeed = 150f;
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float BoostSpeed = 10f;
    [SerializeField] float regularSpeed = 5f;

    [SerializeField] int health = 50;
     
     bool isAlive = true;

    //float timeLeft= 2f;

    void Start()
    {
        currentSpeed = regularSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shrimpBoost"))
        {
            
            Destroy(collision.gameObject);
           StartCoroutine(BoostSpeedCoroutine());

           
        }
        if (collision.CompareTag("trash"))
        {
            Destroy(collision.gameObject);
            health -= 10;
            if (health <= 0)
            {
                isAlive = false;
                // Optionally, you can add code here to handle the shark's death, such as playing an animation or disabling the GameObject.
            }
        }
    }
    IEnumerator BoostSpeedCoroutine()
{
    currentSpeed = BoostSpeed;
    yield return new WaitForSeconds(2f);
    currentSpeed = regularSpeed;
}
    void Update()
    {
        if (!isAlive) { return;}
        

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

