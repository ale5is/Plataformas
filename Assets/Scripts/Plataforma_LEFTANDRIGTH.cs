using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma_LEFTANDRIGTH : MonoBehaviour
{
    public float velocidad;
    public float tiempo;
    public bool cambio;
    // Start is called before the first frame update
    void Start()
    {
        cambio = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
        if (cambio)
        {
            Invoke("Invertir", tiempo);
            cambio = false;
        }
    }
    private void Invertir()
    {
        velocidad *= -1;
        cambio = true;
    }
    
}
