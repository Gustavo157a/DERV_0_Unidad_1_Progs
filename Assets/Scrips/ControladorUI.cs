using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControladorUI : MonoBehaviour
{
    public TextMeshProUGUI texto;

    public void Saludar()
    {
        texto.text = "Bienvenido al juego 7u7";
    }
}
