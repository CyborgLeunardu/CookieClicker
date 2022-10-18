using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialAdExample : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{

    [SerializeField] string _androidUnityId = "Interstitial_Android";
    [SerializeField] string _iosAdUnityId = "Interstitial_iOS";
    string _adUnityId;

    void Awake()
    {
        _adUnityId = (Application.platform == RuntimePlatform.IPhonePlayer) ? _iosAdUnityId : _androidUnityId;
    }

    public void LoadAd()
    {
        Debug.Log("Carregando ad:" + _adUnityId);
        Advertisement.Load(_adUnityId, this);
    }

    public void ShowAd()
    {
        Debug.Log("Show ad: " + _adUnityId);
        Advertisement.Show(_adUnityId, this);
    }
    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("Ads Carregado - with placementID" + placementId);
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log("Falha no carregamento de Ads");
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("Fazer algo ao clicar no Ads");
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("Fazer algo quando o Ads acabar de ser mostrado");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log("Falha no Ads");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("Ads iniciado");
    }
}
