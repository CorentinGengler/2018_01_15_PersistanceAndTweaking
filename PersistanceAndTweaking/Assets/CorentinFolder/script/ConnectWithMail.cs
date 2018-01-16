using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectWithMail  : MonoBehaviour
{

    #region Public Members
    public string m_urlServer = "http://jams.center/api/php/permission/Allowed.php";
    public string m_userEmail = "gengcor@gmail.com";
    public GetImageFromWebPage m_scriptGetImage;
    #endregion


    #region Public Void

    #endregion
    IEnumerator SendMail()
    {
        WWW pageToLoad = new WWW(m_urlServer + "?mail=" + m_userEmail);
        Debug.Log("Loading");
        yield return pageToLoad;
        Debug.Log("Page is loaded");
        Debug.Log("E:" + pageToLoad.error);
        Debug.Log("Text:" + pageToLoad.text);
        if(pageToLoad.text.Contains("true"))
        {
            m_scriptGetImage.FetchImage();
        }
    }

    #region System

    void Start () 
    {
        StartCoroutine("SendMail");
    }
    void Awake () 
    {
		
	}
	
	void Update () 
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
