using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scCura : MonoBehaviour
{
    public TextMeshProUGUI vidaSpidey;
    BoxCollider bc;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(int.Parse(vidaSpidey.text) != 100)
        {
            bc.isTrigger = false;
        }
    }

}
