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

    public void HattoriHanzo()
    {
        SceneManager.LoadScene("HattoriHanzo");
    }

    public void MochizukiChiyome()
    {
        SceneManager.LoadScene("MochizukiChiyome");
    }

    private void TocarSom()
    {
        player.PlayOneShot(som);
    }

    private void SelecionaPersonagens()
    {
        SceneManager.LoadScene("SelecionaPersonagens");
    }

    public void SairDaFloresta()
    {
        TocarSom(); //Chama a função para tocar o som
        Invoke("EscolhaFloresta", 1f); //Chama a função EscolhaFloresta após 1 segundo
    }

    private void inimigo()
    {
        SceneManager.LoadScene("inimigo");
        Invoke("inimigo", 1f);
    }

    public void Batalhar()
    {
        TocarSom(); //Chama a função para tocar o som
    }

    private void Batalha()  
    {
        SceneManager.LoadScene("Batalha");
    }

    private void FumaKotaroo()
    {
        SceneManager.LoadScene("inimigo");
    }
}
       
