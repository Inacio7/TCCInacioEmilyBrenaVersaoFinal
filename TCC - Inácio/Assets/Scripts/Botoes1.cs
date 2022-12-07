using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botoes : MonoBehaviour
{
    bool pausado;
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
    public void Pausar()
    {
        if(pausado == false)
        {
            Time.timeScale = 0;
            pausado = true;
        }
        else if(pausado == true)
        {
            Time.timeScale = 1;
            pausado = false;
        }
    }
    public void Som()
    {
        if(tocando == true)
        {
            cam.mute = true;
            tocando = false;
        }
        else if(tocando == false)
        {
            cam.mute = false;
            tocando = true;
        }
    }
}
