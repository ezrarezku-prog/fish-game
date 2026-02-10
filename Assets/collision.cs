using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("ouch");
    }
    
        
    

    
}
