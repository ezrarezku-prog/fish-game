using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class shark : MonoBehaviour
{
    [SerializeField] float turnSpeed = 150f;
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float BoostSpeed = 10f;
    [SerializeField] float regularSpeed = 5f;

    [SerializeField] int health = 50;
    [SerializeField] int score = 0;

    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] TextMeshProUGUI winText;
    [SerializeField] TextMeshProUGUI diedText;

    public GameObject restartButtton;
    audiomanager audioManager;

     
     bool isAlive = true;

    //float timeLeft= 2f;

    void Start()
    {
        audioManager = FindFirstObjectByType<audiomanager>();

        currentSpeed = regularSpeed;
        healthText.text = health.ToString();
        scoreText.text = score.ToString();
        winText.text = "";
        diedText.text = "";
        restartButtton.SetActive(false);
        
        

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shrimpBoost"))
        {   
            audioManager.PlayPickShrimpSFX();
            Destroy(collision.gameObject);
           StartCoroutine(BoostSpeedCoroutine());
        }

        if (collision.CompareTag("reward"))
        {
            audioManager.PlayYayFishSFX();
            Destroy(collision.gameObject);
            score += 1;
            scoreText.text = score.ToString();
            
            if (score >= 5)
            {
                winText.text = "You Win!";
                audioManager.PlayWonSFX();
            }
        }

        if (collision.CompareTag("trash"))
        {
            Destroy(collision.gameObject);
            health -= 10;
            healthText.text = health.ToString();
            audioManager.PlayTrashSFX();
            
            if (health <= 0)
            {
                diedText.text = "You Died!";
                isAlive = false;
                audioManager.PlayLoseSFX();
                restartButtton.SetActive(true);
                
              // write died
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

