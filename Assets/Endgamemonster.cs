using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Endgamemonster : MonoBehaviour
{

    private const int MAX_HEALTH = 100;
    [SerializeField]
    int Health = MAX_HEALTH;
    [SerializeField]
    Animator myAnimator;
    [SerializeField]
    AudioSource myAudioSource;
    [SerializeField]
    AudioClip hit;
    float TimeToAttack = 0;
    [SerializeField]
    GameObject Playerlocation;
    private bool playOnceMyClp = true;

    public void Damage(int points)
    {
        Health -= points;
        if (Health <= 0)
            Destroy(gameObject);
        else
        {
            myAudioSource.Play();
        }

    }
    void Update()
    {
        float distance = Vector3.Distance(Playerlocation.transform.position, transform.position);
        print(distance);


        if (distance <50)
        {
            if (playOnceMyClp)
                GetComponent<AudioSource>().Play();
            playOnceMyClp = false;
            GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(Playerlocation.transform.position);
            myAnimator.SetBool("IsWalking", true);
            if (distance < 3)
            {
                myAnimator.SetBool("IsWalking", false);
                Attack();
            }
        }
    }

    void Attack()
    {
        TimeToAttack -= Time.deltaTime;
        if (TimeToAttack > 0)
            return;
        TimeToAttack = 1f;
        Player player = Playerlocation.GetComponent<Player>();
        if (player)
        {
            myAnimator.SetTrigger("Attack");
            player.Damage(10);


        }

    }
}
