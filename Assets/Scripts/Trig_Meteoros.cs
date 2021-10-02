using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trig_Meteoros : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject posInicio;
    public GameObject objetoLanzar;
    public TextMeshProUGUI txt_vidaSpidey;
    public TextMeshProUGUI txt_vidaEnem;

    int i;
    public bool meteoritos;

    void Start()
    {
        i = 0;
        meteoritos = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!meteoritos)
        {
            meteoritos = true;
            StartCoroutine("corrutinaTiempo");
        }
    }


    //Corrutina
    IEnumerator corrutinaTiempo()
    {
        while (meteoritos)
        {
            if (i == 5)
            {
                i = 0;
                yield return new WaitForSeconds(2.0f); //entre cada serie de meteoritos
            }
            else
            {
                GameObject obj = Instantiate(objetoLanzar, posInicio.transform.position, 
                    posInicio.transform.rotation) as GameObject;
                i++;
                obj.name = "Meteoro_" + i;
                Destroy(obj, 3f);
            }
            yield return new WaitForSeconds(0.5f); //entre cada meteorito
            if (int.Parse(txt_vidaSpidey.text) == 0 || int.Parse(txt_vidaEnem.text) == 0)
            {
                meteoritos = false;
                Destroy(GameObject.Find("startMet"));
            }  
        }
    }
}
