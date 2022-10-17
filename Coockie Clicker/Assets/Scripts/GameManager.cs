using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Cria os objetos
    public GameObject cookie;
    public Transform cookiePosicao;
    public TextMeshProUGUI cookiesComidosTexto;
    public float cookiesComidos;

    //Instancia os objetos criados
    public void GerarCookie(GameObject cookie)
    {
        Instantiate(cookie, cookiePosicao.position, cookiePosicao.rotation);
    }

    public void ClicouNoCookie()
    {
        cookiesComidos++;
        cookiesComidosTexto.text = cookiesComidos.ToString();
    }

    //Passar o método no Start
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
