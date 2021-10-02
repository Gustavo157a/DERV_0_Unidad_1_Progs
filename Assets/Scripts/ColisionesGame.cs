using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColisionesGame : MonoBehaviour
{
    public TextMeshProUGUI txt_spidey;
    public TextMeshProUGUI txt_venom;
    public TextMeshProUGUI txt_aviso;

    int vidaSpidey;
    int vidaVenom;
    int vidaSecuaz;

    // Start is called before the first frame update
    void Start()
    {
        vidaSpidey = 100;
        vidaVenom = 200;
        vidaSecuaz = 100;
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

        if (Etiqueta.Equals("Enemigo"))
        {
            if (vidaSpidey != 0)
            {
                vidaVenom -= 50;
                txt_venom.text = vidaVenom.ToString();
            }

            if (vidaVenom == 0)
            {
                nombre = collision.gameObject.name;
                destruir(nombre);

                txt_aviso.text = "You Win!";
            }
        }

        if (Etiqueta.Equals("Secuaz"))
        {
            if (vidaSpidey != 0)
            {
                vidaSecuaz -= 50;
            }

            if (vidaSecuaz == 0)
            {
                nombre = collision.gameObject.name;
                destruir(nombre);
                vidaSecuaz = 100;
            }
        }

        if (Etiqueta.Equals("Daño"))
        {
            if (vidaSpidey != 0)
            {
                vidaSpidey -= 10;
                txt_spidey.text = vidaSpidey.ToString();
                if (vidaSpidey == 0)
                {
                    txt_aviso.text = "Game Over";
                }
            }
        }

        if (Etiqueta.Equals("PowerUp"))
        {
            if (vidaSpidey != 100 && vidaSpidey != 0)
            {
                vidaSpidey += 100 - int.Parse(txt_spidey.text);
                txt_spidey.text = vidaSpidey.ToString();

                nombre = collision.gameObject.name;
                destruir(nombre);
            }
        }
    }

    void destruir(string nombre)
    {
        GameObject gameObj;
        gameObj = GameObject.Find(nombre);
        Destroy(gameObj);
    }

}
