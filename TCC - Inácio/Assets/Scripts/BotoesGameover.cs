using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesGameover : MonoBehaviour
{
    private AudioSource musica;
    public AudioClip morte;
    // Start is called before the first frame update
    void Start()
    {
        musica = GetComponent<AudioSource>();
        musica.PlayOneShot(morte);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene("GamePlayer");
    }
    public void Menu()
    {
        SceneManager.LoadScene("TelaInicial");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
