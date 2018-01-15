using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderImageFromGoogle  : MonoBehaviour
{

    #region Public Members
    public string url = "https://trello-attachments.s3.amazonaws.com/5a5baaeb7ab77faf698ec795/5a5bb068244479818cabe109/e8ab72192289f7adc0688a3380d953a7/image.png";
    #endregion


    #region Public Void

    #endregion
    IEnumerator GetImage()
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = www.texture;
        }
    }

    #region System

    void Awake () 
    {
        StartCoroutine("GetImage");
        

    }

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
