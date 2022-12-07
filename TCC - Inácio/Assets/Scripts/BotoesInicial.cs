using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesInicial : MonoBehaviour
{
    bool tocando;
    public AudioSource cam;
    // Start is called before the first frame update
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
    public void Som()
    {
        if (tocando == true)
        {
            cam.mute = true;
            tocando = false;
        }
        else if (tocando == false)
        {
            cam.mute = false;
            tocando = true;
        }
    }
}
