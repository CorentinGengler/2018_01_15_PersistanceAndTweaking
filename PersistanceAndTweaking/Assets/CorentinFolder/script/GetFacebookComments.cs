using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GetFacebookComments  : MonoBehaviour
{

    #region Public Members
    public string m_urlServer = "https://graph.facebook.com/v2.8/";
    public string m_urlCommand = "1288727477846995/comments";
    public string m_token = "EAACEdEose0cBANIrgHPTlPZBXXlmPSeSyathtvmZA5H97TfgEeDFM3L8L2PtQtZB3PIEMastprEb6YM4ZA8evUN5HFbEbTxMeKRnvngG2mB64Th3LAygM8D2vhFLuexDgcMcSxh6bozGbNptU4dZAmXZAWXinjL0Du4IU3BN2ZAsoJlTK73SQrPI6WduVRPXHJ9prmwWdmeBgZDZD";
    private string m_json = "";
    
    public OnPageLoadEvent _onJsonLoaded;
    [System.Serializable]
    public class OnPageLoadEvent : UnityEvent<string> { }
    #endregion


    #region Public Void

    #endregion
    IEnumerator GetComments()
    {
        WWWForm form = new WWWForm();
        var headers = form.headers;
        headers["Authorization"] = "Bearer " + m_token;

        WWW page = new WWW(m_urlServer + m_urlCommand , null , headers);

        yield return page;
        
        if(string.IsNullOrEmpty(page.error))
        {
            m_json = page.text;
            _onJsonLoaded.Invoke(m_json);
        }
    }

    #region System

    void Start()
    {
        StartCoroutine("GetComments");
    }

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
