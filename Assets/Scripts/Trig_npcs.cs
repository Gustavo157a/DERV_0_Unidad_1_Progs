using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig_npcs : MonoBehaviour
{

    public GameObject toCopy; //objeto
    public GameObject toPaste;//lugar

    int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            for (int j = 0; j < 3; j++)
            {
                toPaste = GameObject.Find("place"+ (j+1));
                GameObject obj = Instantiate(toCopy, toPaste.transform.position,
                    toPaste.transform.rotation) as GameObject;
                
                i++;
                obj.name = "mysterio_copy" + i;
                obj.tag = "Secuaz";
            }
        }
    }

}
