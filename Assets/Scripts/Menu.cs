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

    public void Paladino()
    {
        SceneManager.LoadScene("Fūma Kotarō");
    }

    public void Mago()
    {
        SceneManager.LoadScene("Hattori Hanzō");
    }

    public void Druida()
    {
        SceneManager.LoadScene("Mochizuki Chiyome");
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

    private void EscolhaFloresta()
    {
        SceneManager.LoadScene("EscolhaFloresta");
    }

    public void BatalhaDaFlorestaEsquerda()
    {
        TocarSom(); //Chama a função para tocar o som
        Invoke("EscolhaFlorestaBatalha", 1f); //Chama a função EscolhaFloresta após 1 segundo
    }

    private void EscolhaFlorestaBatalha()
    {
        SceneManager.LoadScene("EscolhaFlorestaBatalha");
    }
}
