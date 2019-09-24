using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySentinel : Enemy
{
    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }

    protected override void Move()
    {
        transform.position = pos + new Vector3(Mathf.Sin(Time.time) * velocidade, 0.0f, 0.0f);
    }
}
