﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{

    private const int MAX_HEALTH = 100;
    [SerializeField]
    int Health = MAX_HEALTH;
    [SerializeField]
    Animator myAnimator;
    [SerializeField]
    AudioSource myAudioSource;
    private Transform target;
    [SerializeField]
    AudioClip hit;
    float TimeToAttack = 1.5f;
    [SerializeField]
    GameObject Playerlocation;

    public void Damage(int points, Transform newTarget)
    {
        Health -= points;
        if (Health <= 0)
            Destroy(gameObject);
        else
        {
            target = newTarget;
            myAudioSource.Play();
        }

    }
    void Update()
    {
            float distance = Vector3.Distance(Playerlocation.transform.position, transform.position);
            print(distance);
            if (distance <10)
            {
                GetComponent<NavMeshAgent>().SetDestination(Playerlocation.transform.position); 
                myAnimator.SetBool("IsWalking", true);
                TimeToAttack = 1.5f;
            }
            else if(distance<4)
            {
                myAnimator.SetBool("IsWalking", false);
                Attack();
            }
        
    }

    void Attack()
    {
        TimeToAttack -= Time.deltaTime;
        if (TimeToAttack > 0)
            return;
        TimeToAttack = 1.5f;
        Player player = target.GetComponent<Player>();
        if (player)
        {
            myAnimator.SetTrigger("IsAttacking");
            player.Damage(10);
            myAudioSource.clip = hit;

        }

    }
}
