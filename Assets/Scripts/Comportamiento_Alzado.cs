using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_Alzado : MonoBehaviour
{
    // Start is called before the first frame update
    public bool alzado=false;
    private bool activo=false;
    public GameObject alzador;
    private void Update()
    {
        if (activo) { transform.position = alzador.transform.position + new Vector3(0, 1.45f, 0); }
    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")&&alzado)
        {
            transform.SetParent(collision.transform);  
            activo = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !alzado)
        {
            activo = false;
            transform.SetParent(null);
            
        }
    }
}
