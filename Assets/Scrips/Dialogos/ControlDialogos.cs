using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDialogos : MonoBehaviour
{
    //Singleton
    public static ControlDialogos singleton;


    public GameObject dialogo;
    public Text txtDialogo;

    [Header("Config de teclado")]
    public KeyCode teclaSiguienteFrase;
    public KeyCode teclaInicioDialogo = KeyCode.N;
    [Header("Ensayos")]
    public Frase[] dialogoEnsayo;

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        dialogo.SetActive(false);
    }

    public IEnumerator Decir(Frase[] _dialogo)
    {
        dialogo.SetActive(true);
        for (int i = 0; i < _dialogo.Length; i++)
        {
            txtDialogo.text = _dialogo[i].texto;
            yield return new WaitForSeconds(0.5f);
            yield return new WaitUntil(() => Input.GetKeyDown(teclaSiguienteFrase));
        }
        dialogo.SetActive(false);

    }
    [ContextMenu("Activar prueba")]
    public void Prueba()
    {
       StartCoroutine(Decir(dialogoEnsayo));
    }
    
}
[System.Serializable]
public class Frase
{
    public string texto;
}

[System.Serializable]
public class EstadoDialogo
{
    public Frase[] frases;
}
