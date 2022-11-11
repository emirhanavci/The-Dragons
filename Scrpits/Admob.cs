using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;

public class Admob : MonoBehaviour
{
    public static Admob instance;
    private InterstitialAd interstitial;

    bool adshow = false;

    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        this.RequestInterstitialAd();
    }

    private void Update()
    {
        if(MenuManager.instance.currentScore < 1)
        {
            if (adshow == false)
            {
                if (this.interstitial.IsLoaded())
                {
                    this.interstitial.Show();
                    adshow = false;
                }
            }
        }
        if (MenuManager.instance.currentAstronot > 19)
        {
            if (adshow == false)
            {
                if (this.interstitial.IsLoaded())
                {
                    this.interstitial.Show();
                    adshow = false;
                }
            }
        }
    }
    public void RequestInterstitialAd()
    {
        string reklamId = "ca-app-pub-3535768035091412/8490714988";

        this.interstitial = new InterstitialAd(reklamId);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
    }

}