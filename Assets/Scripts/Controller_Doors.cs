using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Doors : MonoBehaviour
{
    public int targetNumber;
    public GameObject puerta;
    public bool playerOnTarget;

    private void Start()
    {
        playerOnTarget = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.GetComponent<Controller_Player>().playerNumber == targetNumber)
            {
                playerOnTarget = true;
                puerta.GetComponent<AbrirCerrar>().activado = true;
                //Debug.Log("P on T");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.GetComponent<Controller_Player>().playerNumber == targetNumber)
            {
                playerOnTarget = false;
                puerta.GetComponent<AbrirCerrar>().activado = false;
                //Debug.Log("P off T");
            }
        }
    }
}
