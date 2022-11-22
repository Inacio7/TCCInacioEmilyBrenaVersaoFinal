using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoMissoes : MonoBehaviour
{

    public GameObject animacaoCameraPrincipal;
    public GameObject animacaoCameraFase;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        animacaoCameraPrincipal.SetActive(false);
        animacaoCameraFase.SetActive(true);
    }

    public void fimAnimacao()
    {
        animacaoCameraPrincipal.SetActive(true);
        animacaoCameraFase.SetActive(false);
    }
}
