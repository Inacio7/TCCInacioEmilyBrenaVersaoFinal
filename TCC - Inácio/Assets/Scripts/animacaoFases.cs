using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacaoFases : MonoBehaviour
{

    public GameObject cameraPrincipal;
    public GameObject cameraAnimacao;
    

    void Start()
    {
        cameraPrincipal.SetActive(true);
        cameraAnimacao.SetActive(false);
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            cameraPrincipal.SetActive(false);
            cameraAnimacao.SetActive(true);
        }
    }


}
