using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFisicas : MonoBehaviour
{
    Rigidbody rb;
    public float desplazamiento = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void Update()
    {

    }

    //Update por tiempo
    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("Arriba");
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("Izquierda");
            rb.MovePosition(rb.position + transform.right * -1f * desplazamiento * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("Abajo");
            rb.MovePosition(rb.position + transform.forward * -1f * desplazamiento * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Derecha");
            rb.MovePosition(rb.position + transform.right * desplazamiento * Time.deltaTime);
        }
    }
}
