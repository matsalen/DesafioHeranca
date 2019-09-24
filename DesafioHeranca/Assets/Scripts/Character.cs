using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected float velocidade;
    protected bool atacando;
    protected Animator anim;

    private void Start()
    {
        atacando = false;
        anim = GetComponent<Animator>();
    }

    protected void Update()
    {

        if (!atacando)
        {
            Move();
        }        
    }

    protected abstract void Move();

    protected virtual void Ataque(bool Status)
    {
        anim.SetBool("Ataque", atacando);
    }
}
