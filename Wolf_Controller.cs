using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class Wolf_Controller : MonoBehaviour
{
        int hp = 50;
        Animator animation;
        NavMeshAgent agent;
        public Transform player_transform;
        public PlayerControler player_script;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player_script.playerAtHouse == false) {
            agent.SetDestination(player_transform.position);
            animation.SetBool("move", true);
        }else{
             animation.SetBool("move", false);
             agent.ResetPath();
        }
    }
     public void TakeDamage(int dmg)
    { 
        hp = hp - dmg;
        print (hp);
    }

   
}
