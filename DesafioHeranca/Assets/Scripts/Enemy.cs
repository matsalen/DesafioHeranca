using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    [SerializeField] protected Transform player;

    protected void OnTriggerEnter(Collider other)
    {        
        if (other.CompareTag("Player"))
        {
            atacando = true;
            anim.SetBool("Ataque", atacando);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        atacando = false;
        anim.SetBool("Ataque", atacando);
    }
}
