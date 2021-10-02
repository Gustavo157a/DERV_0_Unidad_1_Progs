using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogador : MonoBehaviour
{
    public int estadoActual = 0;
    public EstadoDialogo[] estados;

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(ControlDialogos.singleton.teclaInicioDialogo))
            {
                StartCoroutine(ControlDialogos.singleton.Decir(estados[estadoActual].frases));
            }
        }
    }
}
