using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove  : MonoBehaviour
{

    #region Public Members
    public GameObject m_prefabChar;
    public Transform m_StartingPosition;
    #endregion


    #region Public Void
    public void GhostShow(List<PositionThroughTimeStruct> ListPTT)
    {
        m_ListPTT = ListPTT;
        m_index = 0;
        m_ghost = Instantiate(m_prefabChar, m_ListPTT[m_index].m_v3pos, new Quaternion());
        m_index++;
        m_isInstanciated = true;
    }
    #endregion


    #region System
    void FixedUpdate()
    {
        if(m_isInstanciated)
        {
            if(m_index +1 < m_ListPTT.Count)
            {
                if (m_ghost.transform.position != m_ListPTT[m_index].m_v3pos)//if player moved
                {
                    if ((m_ghost.transform.position - m_ListPTT[m_index].m_v3pos).magnitude > 0.5)//if distance from previous is enough
                    {
                        m_ghost = Instantiate(m_prefabChar, m_ListPTT[m_index].m_v3pos, new Quaternion());
                    }

                }
                m_index++;
            }
            else
            {
                m_ghost = Instantiate(m_prefabChar, m_ListPTT[m_index].m_v3pos, new Quaternion() );
                m_isInstanciated = false;
            }
        }
    }
    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members
    private bool m_isInstanciated;
    private List<PositionThroughTimeStruct> m_ListPTT = new List<PositionThroughTimeStruct>();
    private int m_index;
    private Transform LastPlacedPosition;
    private GameObject m_ghost;
    #endregion

}
