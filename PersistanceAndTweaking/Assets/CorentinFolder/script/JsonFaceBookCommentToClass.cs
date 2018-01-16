using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonFaceBookCommentToClass : MonoBehaviour
{
    public Commments m_comments;

    public void ConvertJson(string json)
    {
        m_comments = JsonUtility.FromJson<Commments>(json);
    }
    public void ChangeDateFormat()
    {
        foreach(SingleComment comment in m_comments.data)
        {
            //2017-03-25T11:27:15+0000
            //comment.created_time = 
        }

    }
}
[System.Serializable]
public class Commments
{
    public List<SingleComment> data;
}
[System.Serializable]
public class SingleComment
{
    public string created_time;
    public string message;
    private string id;
}


