using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    
    public int velocidadeGiro = 50;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<GameManager>().SubtrairMoedas(1);
            Destroy(gameObject);
        }
    }

    void Update()
    {
       transform.Rotate(Vector3.up * velocidadeGiro * Time.deltaTime, Space.World); 
    }
}
