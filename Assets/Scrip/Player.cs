using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private const int MAX_HEALTH = 100;
    [SerializeField]
    int Health = MAX_HEALTH;
    [SerializeField]
    AudioSource myAudioSourse;
    [SerializeField]
    AudioClip PlayerHurt;


    public void Damage(int points)
    {
        Health -= points;
   
        if (Health <= 0)
        {SceneManager.LoadScene(3); }
            

    }


}
