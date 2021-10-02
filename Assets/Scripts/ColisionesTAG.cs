using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColisionesTAG : MonoBehaviour
{
    public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_vida;

    int puntaje;
    int vida;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        vida = 100;

        StartCoroutine("corrutinaVida");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string Etiqueta = collision.gameObject.tag;
        string nombre;

        Debug.Log("Colisión con: " + Etiqueta);

        if (Etiqueta.Equals("Enemigo"))
        {
            nombre = collision.gameObject.name;

            GameObject gameObj;
            gameObj = GameObject.Find(nombre);
            Destroy(gameObj);

            //vida--;
            //txt_vida.text = vida.ToString();

            puntaje++;
            txt_puntaje.text = puntaje.ToString();
        }
    
    }

    private void OnCollisionStay(Collision collision)
    {
        string Etiqueta = collision.gameObject.tag;
        if (Etiqueta.Equals("PowerUp"))
        {
            vida++;
            txt_vida.text = vida.ToString();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }

    //corrutina
    IEnumerator corrutinaVida()
    {
        while (true)
        {
            vida -= 5;
            txt_vida.text = vida.ToString();

            yield return new WaitForSeconds(1.0f); //yield indica que necesita el num
        }
    }

}
