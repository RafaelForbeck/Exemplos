using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var vector = new Vector3(horizontal, vertical, 0);

        // Controle por velocidade
        rig.velocity = vector * speed;

        // Controle por física
        //rig.AddForce(vector * Time.deltaTime * speed);


        // Controle por vetores
        //transform.position += vector * speed * Time.deltaTime;
    }
}
