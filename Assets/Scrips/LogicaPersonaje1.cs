 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje1 : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;
    public Rigidbody rb;
    public bool estoyAtacando;
    public bool avanzoSolo;
    public float impulsoDeGole = 10f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        if (!estoyAtacando)
        {
            transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
        }
        if (avanzoSolo)
        {
            rb.velocity = transform.forward * impulsoDeGole;
        }

        if (Input.GetKeyDown(KeyCode.Return) && !estoyAtacando)
        {
            anim.SetTrigger("Golpeo");
            estoyAtacando = true;
        }

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }

    public void DejoGolpear()
    {
        estoyAtacando = false;
        avanzoSolo = false;
    }

    public void AvanzoSolo()
    {
        avanzoSolo = true;
    }

    public void DejoAvanzar()
    {
        avanzoSolo = false;
    }
}
