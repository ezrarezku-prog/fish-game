using UnityEngine;

public class audiomanager : MonoBehaviour
{
    [Header("Pick Shrimp SFX")]
    [SerializeField] AudioClip pickShrimp;
    [SerializeField] [Range (0f, 1f)] float pickShrimpVolume = 1f;

[Header("Yay Fish SFX")]
    [SerializeField] AudioClip yayFish;
    [SerializeField] [Range (0f, 1f)] float yayFishVolume = 1f; 

    [Header("Trash SFX")]
    [SerializeField] AudioClip trash;
    [SerializeField] [Range (0f, 1f)] float trashVolume = 1f; 

    [Header("Won SFX")]
    [SerializeField] AudioClip won;
    [SerializeField] [Range (0f, 1f)] float wonVolume = 1f; 

[Header("Lose SFX")]
    [SerializeField] AudioClip lose;
    [SerializeField] [Range (0f, 1f)] float loseVolume = 1f;

    public void PlayPickShrimpSFX()
    {
        if (pickShrimp != null)
        AudioSource.PlayClipAtPoint(pickShrimp, Camera.main.transform.position, pickShrimpVolume);
    }

    public void PlayYayFishSFX()
    {
        if (yayFish != null)
        AudioSource.PlayClipAtPoint(yayFish, Camera.main.transform.position, yayFishVolume);
    }

    public void PlayTrashSFX()
    {
        if (trash != null)
        AudioSource.PlayClipAtPoint(trash, Camera.main.transform.position, trashVolume);
    }

    public void PlayWonSFX()
    {
        if (won != null)
        AudioSource.PlayClipAtPoint(won, Camera.main.transform.position, wonVolume);
    }
    
    public void PlayLoseSFX()
    {
        if (lose != null)
        AudioSource.PlayClipAtPoint(lose, Camera.main.transform.position, loseVolume);

    }



    
    }






