using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_Alzar : MonoBehaviour
{
    // Start is called before the first frame update
    public bool alzar=false;
    public GameObject alzado;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            alzar = true;
            gameObject.gameObject.GetComponent<Controller_Player>().jumpForce =35;
        }
        if(Input.GetKeyUp(KeyCode.K))
        {
            alzar=false;
            gameObject.gameObject.GetComponent<Controller_Player>().jumpForce = 18;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")&&alzar)
        {
            alzado.GetComponent<Comportamiento_Alzado>().alzado = true;
        }
        else
        {
            alzado.GetComponent<Comportamiento_Alzado>().alzado = false;
        }
        
    }
}
