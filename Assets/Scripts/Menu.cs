using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private AudioSource player; //Referência ao componente AudioSource
    [SerializeField] private AudioClip som; //Arquivo (Clip) de áudio a ser reproduzido

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<AudioSource>(); //Guarda a referência do AudioSource
    }

    public void Jogar()
    {
        TocarSom(); //Chama a função para tocar o som
        Invoke("SelecionaPersonagens", 1f); //Chama a função SelecionaPersonagens após 1 segundo
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void FumaKotaro()
    {
        SceneManager.LoadScene("FumaKotaro");
    }

    private void Inimigo()
    {
        SceneManager.LoadScene("Inimigo");

    }

    public void INIMIGO()
    {
        SceneManager.LoadScene("INIMIGO");
    }

    public void vitoria()
    {
        SceneManager.LoadScene("vitoria");
    }
    public void artefato()
    {
        SceneManager.LoadScene("artefato");
    }

    public void Espada()
    {
        SceneManager.LoadScene("Espada");
    }
    public void Espada1()
    {
        SceneManager.LoadScene("Espada1");
    }
    public void Espada2()
    {
        SceneManager.LoadScene("Espada2");
    }
    public void Obrigado()
    {
        SceneManager.LoadScene("Obrigado");
    }

    private void TocarSom()
    {
        player.PlayOneShot(som);
    }

    private void SelecionaPersonagens()
    {
        SceneManager.LoadScene("SelecionaPersonagens");
    }

    public void batalhar()
    {
        TocarSom(); //Chama a função para tocar o som
        Invoke("Batalhar", 1f); //Chama a função EscolhaFloresta após 1 segundo
    }

    private void inimigo()
    {
        SceneManager.LoadScene("inimigo");
        Invoke("inimigo", 1f);
    }
    /*
    public void Batalhar()
    {
        TocarSom(); //Chama a função para tocar o som
    }
    */
    private void Batalhar()  
    {
        SceneManager.LoadScene("Batalhar");
    }

    private void FumaKotaroo()
    {
        SceneManager.LoadScene("Inimigo");
    }
   
}
       
