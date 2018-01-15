using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AddPosToList  : MonoBehaviour
{

    #region Public Members
    
    public Transform m_PlayerTransform;

    public List<PositionThroughTimeStruct> m_listPos = new List<PositionThroughTimeStruct>();
    #endregion


    #region Public Void
    #endregion


    #region System

    void Start () 
    {
        PositionThroughTimeStruct newPos = new PositionThroughTimeStruct()
        {
            m_v3pos = m_PlayerTransform.position,
            m_time = Time.fixedTime
        };
        m_listPos.Add(newPos);
    }
    void Awake () 
    {
        
    }

    void FixedUpdate()
    {
        if(m_PlayerTransform.position != m_listPos[m_listPos.Count-1].m_v3pos)
        {
            PositionThroughTimeStruct newPos = new PositionThroughTimeStruct()
            {
                m_v3pos = m_PlayerTransform.position,
                m_time = Time.fixedTime
            };
            m_listPos.Add(newPos);
        }
    }

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members
    #endregion

}
