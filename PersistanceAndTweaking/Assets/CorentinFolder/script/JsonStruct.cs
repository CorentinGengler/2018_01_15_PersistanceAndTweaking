using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class JsonStruct  
{
    public List<PositionThroughTimeStruct> m_listPosTroughTime;
    public JsonStruct(List<PositionThroughTimeStruct> m_list)
    {
        m_listPosTroughTime = m_list;
    }
}
