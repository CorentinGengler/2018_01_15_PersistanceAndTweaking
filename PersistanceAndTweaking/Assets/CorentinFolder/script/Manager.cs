using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager  : MonoBehaviour
{

    #region Public Members
    public GameObject m_PlayerTransform;
    public AddPosToList m_AddPosToList;
    public GhostMove m_GhostMove;
    #endregion


    #region Public Void
    public void SaveListOnJson()
    {
        m_listPTT = m_AddPosToList.m_listPos;
        JsonStruct Jstruct = new JsonStruct(m_listPTT);
        string temp = JsonHandler.GenerateJsonStringFromClass(Jstruct);
        JsonHandler.WriteStringOnDrive(temp);
    }
    public void GetListFromJson()
    {
        string temp = JsonHandler.ReadStringFromFile();
        if (temp.Length<5)
        {
            m_jsonExists= false;
        }
        else
        {
            JsonStruct Jstruct = JsonHandler.ImportClassFromJsonString(temp);
            m_LoadedPTT = Jstruct.m_listPosTroughTime;
            m_jsonExists = true;
        }
    }

    public void PlayGhostParcour()
    {
        if(m_LoadedPTT.Count>1)
        {
            m_GhostMove.GhostShow(m_LoadedPTT);
        }
        
    }
    #endregion


    #region System

    void Start () 
    {
		
	}
    void Awake () 
    {
        GetListFromJson();
        if (m_jsonExists)
        {
            if (m_LoadedPTT.Count > 0)
            {
                m_PlayerTransform.transform.position = m_LoadedPTT[m_LoadedPTT.Count - 1].m_v3pos;
            }
        }
        
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
    private List<PositionThroughTimeStruct> m_listPTT = new List<PositionThroughTimeStruct>();
    private List<PositionThroughTimeStruct> m_LoadedPTT = new List<PositionThroughTimeStruct>();
    private bool m_jsonExists;
    #endregion

}
