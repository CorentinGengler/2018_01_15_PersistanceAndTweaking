using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetImageFromWebPage : MonoBehaviour
{

    #region Public Members
    public string m_urlImage = "https://wallpaperclicker.com/storage/wallpaper/High-Definition-Ultra-HD-Wallpaper-96262544.jpg";
    public RawImage _rawImage;



    #endregion


    #region Public Void

    #endregion
    IEnumerator GetImage()
    {
        WWW www = new WWW(m_urlImage);
        yield return www;
        _rawImage.texture = www.texture;
    }

    #region System

    public void FetchImage()
    {
        StartCoroutine("GetImage");
    }
    void Awake () 
    {
        
        
    }

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
