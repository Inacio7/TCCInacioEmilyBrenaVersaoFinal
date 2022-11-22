using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoIniciar : MonoBehaviour
{
    public GameObject cameraPrincipal;
    public GameObject cameraAnimacao;


    private void Awake()
    {
        cameraPrincipal.SetActive(false);
        cameraAnimacao.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fimAminacao()
    {
        cameraPrincipal.SetActive(true);
        cameraAnimacao.tag= "camera";
        cameraAnimacao.SetActive(false);
    }
}
