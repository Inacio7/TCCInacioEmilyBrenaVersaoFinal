using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fimAnimacaoFase : MonoBehaviour
{
    public GameObject player;

    private animacaoFases cameraFase;
    // Start is called before the first frame update
    void Start()
    {
        cameraFase = FindObjectOfType(typeof(animacaoFases)) as animacaoFases;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fimAnimacao()
    {
        cameraFase.cameraPrincipal.SetActive(true);
        cameraFase.cameraAnimacao.SetActive(false);
    }
}
