using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Character
{
    Rigidbody rbody;

    private void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    protected override void Move()
    {

        GetComponent<Animator>().SetFloat("Velocidade", rbody.velocity.magnitude); ;
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * velocidade, 0, Input.GetAxis("Vertical") * Time.deltaTime * velocidade);
        rbody.velocity = movimento;
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            transform.rotation = Quaternion.LookRotation(movimento);
    }
}
