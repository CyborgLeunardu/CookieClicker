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

    //Instancia os objetos criados
    public void GerarCookie(GameObject cookie)
    {
        //N�o � poss�vel converter UnityEngine.GameObject para Cookie
        //cookieGerado = Instantiate(cookie, cookiePosicao.position, cookiePosicao.rotation);

        //Resolu��o:
        cookieGerado = Instantiate(cookie, cookiePosicao.position, cookiePosicao.rotation).GetComponent<Cookie>();

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
