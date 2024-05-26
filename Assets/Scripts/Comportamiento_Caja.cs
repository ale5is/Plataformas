using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_Caja : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Collider coliider;
        
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.AddForce(new Vector3(1, 1, 1), ForceMode.Impulse);
        }
    }
}
