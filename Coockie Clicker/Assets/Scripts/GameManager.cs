using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Cria os objetos
    public GameObject cookie;
    public Transform cookiePosicao;
    public TextMeshProUGUI cookiesComidosTexto;
    public float cookiesComidos;
    public Cookie cookieGerado;
    public Transform migalhaPosicao;

    public GameObject menuItem;
    public TextMeshProUGUI menuAlternarIcone;

    public InterstitialAdExample interstitialAdExample;

    //Instancia os objetos criados
    public void GerarCookie(GameObject cookie)
    {
        //Não é possível converter UnityEngine.GameObject para Cookie
        //cookieGerado = Instantiate(cookie, cookiePosicao.position, cookiePosicao.rotation);

        //Resolução:
        cookieGerado = Instantiate(cookie, cookiePosicao.position, cookiePosicao.rotation).GetComponent<Cookie>();

    }

    // Não é o lugar ideal, melhor fazer no MenuManager, mas para um projeto exemplo está de bom tamanho
    public void AlternarMenu()
    {

        if (menuItem.activeSelf)
        {
            menuItem.SetActive(false);
            menuAlternarIcone.text = "+";
        }
        else
        {
            interstitialAdExample.LoadAd();
            interstitialAdExample.ShowAd();
            menuItem.SetActive(true);
            menuAlternarIcone.text = "X";
        }
    }

    //Método para contar número de clicks
    public void ClicouNoCookie()
    {
        cookiesComidos++;
        cookiesComidosTexto.text = cookiesComidos.ToString();
        //Instanciar a migalha toda vez que clickar no cookie
        Instantiate(cookieGerado.Migalhas, migalhaPosicao.position, migalhaPosicao.localRotation);
    }

    //Passar o método Gerar e atualizando o valor dos clicks do método ClicouNoCookie
    void Start()
    {
        cookiesComidos = 0;
        cookiesComidosTexto.text = cookiesComidos.ToString();
        GerarCookie(cookie);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
