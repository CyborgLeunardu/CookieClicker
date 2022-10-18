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
        //N�o � poss�vel converter UnityEngine.GameObject para Cookie
        //cookieGerado = Instantiate(cookie, cookiePosicao.position, cookiePosicao.rotation);

        //Resolu��o:
        cookieGerado = Instantiate(cookie, cookiePosicao.position, cookiePosicao.rotation).GetComponent<Cookie>();

    }

    // N�o � o lugar ideal, melhor fazer no MenuManager, mas para um projeto exemplo est� de bom tamanho
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

    //M�todo para contar n�mero de clicks
    public void ClicouNoCookie()
    {
        cookiesComidos++;
        cookiesComidosTexto.text = cookiesComidos.ToString();
        //Instanciar a migalha toda vez que clickar no cookie
        Instantiate(cookieGerado.Migalhas, migalhaPosicao.position, migalhaPosicao.localRotation);
    }

    //Passar o m�todo Gerar e atualizando o valor dos clicks do m�todo ClicouNoCookie
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
