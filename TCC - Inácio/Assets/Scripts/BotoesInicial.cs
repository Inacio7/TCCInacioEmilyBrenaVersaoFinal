using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesInicial : MonoBehaviour
{
    bool tocando;
    public AudioSource cam;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Iniciar()
    {
        SceneManager.LoadScene("GamePlayer");

    }
    public void Instrucoes()
    {
        SceneManager.LoadScene("InstrucaoDoJogo");

    }
}
