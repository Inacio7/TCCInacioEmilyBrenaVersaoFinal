using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{
    public GameObject bala;         
    public Transform posicaoAtirarbala;
    public float forcaTiro;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Atirar();
        }
    }

    void Atirar()
    {
        Instantiate(bala, posicaoAtirarbala.position, posicaoAtirarbala.transform.rotation);
    }
}
