using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{

    public GameObject animacaoCameraMain;
    public GameObject animacaoCamera;
 
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            animacaoCameraMain.SetActive(false);
            animacaoCamera.SetActive(true);
        }
    }

    public void fimAnimacao()
    {
        animacaoCameraMain.SetActive(true);
        animacaoCamera.SetActive(false);
    }
}
