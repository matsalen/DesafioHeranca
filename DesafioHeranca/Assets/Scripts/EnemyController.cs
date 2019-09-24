using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Enemy
{
    private void FixedUpdate()
    {
        transform.LookAt(player);
        
    }

    protected override void Move()
    {         
        transform.position += (transform.forward * Time.deltaTime * velocidade);        
    }
}
