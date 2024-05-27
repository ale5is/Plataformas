using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Switch : MonoBehaviour
{
    public int targetNumber;
    public bool playerOnTarget;
    public GameObject puerta;

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
                puerta.GetComponent<AbrirCerrar>().activado=true;
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
                //Debug.Log("P off T");
            }
        }
    }
}
