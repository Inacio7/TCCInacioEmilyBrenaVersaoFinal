using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botoes : MonoBehaviour
{

    public GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciarJogo()
    {

        StartCoroutine(TempoEspera());
    }

    IEnumerator TempoEspera()
    {
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(3.5f);

        SceneManager.LoadScene("GamePlayer");
    }
}
