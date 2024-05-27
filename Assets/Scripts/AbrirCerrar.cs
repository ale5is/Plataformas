using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCerrar : MonoBehaviour
{
    public bool activado=false;
    private MeshRenderer mr;
    private BoxCollider bc;
    // Start is called before the first frame update
    void Start()
    {
        mr = gameObject.GetComponent<MeshRenderer>();
        bc = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        Activar();
    }
    public void Activar()
    {
        if (activado)
        {
            mr.enabled = false;
            bc.enabled = false;
        }
        else
        {
            mr.enabled = true;
            bc.enabled = true;
        }
    }
}
