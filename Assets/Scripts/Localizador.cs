using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localizador : MonoBehaviour
{
    GameObject objMirar;
    GameObject [] arrBells;
    GameObject flecha;
    bool isActive = true;
    int maxBells;

    // Start is called before the first frame update
    void Start()
    {
        flecha = GameObject.Find("Flecha");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isActive)
            {
                flecha.SetActive(false);
                isActive = false;
            }
            else
            {
                flecha.SetActive(true);
                isActive = true;
            }
        }
    }

    private void FixedUpdate()
    {
        arrBells = GameObject.FindGameObjectsWithTag("Bell");
        maxBells = arrBells.Length;

        if (maxBells > 0)
        {
            objMirar = arrBells[0];
            Vector3 pos = objMirar.transform.position;
            transform.LookAt(pos);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //ORIGEN, DIRECCION
        Gizmos.DrawRay(transform.position, transform.forward * 10f);
    }

}
