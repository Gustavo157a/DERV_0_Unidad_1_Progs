using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scCampana : MonoBehaviour
{
    GameObject goVenom;
    public TextMeshProUGUI numCamps;
    public int numMax;

    // Start is called before the first frame update
    void Start()
    {
        goVenom = GameObject.Find("Venom");
    }

    private void OnCollisionEnter(Collision collision)
    {
        numCamps.text = (int.Parse(numCamps.text) + 1).ToString();

        if (int.Parse(numCamps.text) == numMax)
        {
            goVenom.tag = "Enemigo";
        }

        Destroy(gameObject);
    }

}
