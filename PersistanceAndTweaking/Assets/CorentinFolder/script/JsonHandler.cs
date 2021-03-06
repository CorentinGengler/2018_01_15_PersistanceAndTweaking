﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class JsonHandler : MonoBehaviour
{
    public static string GenerateJsonStringFromClass(JsonStruct jsonS)
    {
        return JsonUtility.ToJson(jsonS);
    }

    public static JsonStruct ImportClassFromJsonString(string jsonString)
    {
        return JsonUtility.FromJson<JsonStruct>(jsonString);
    }

    
    public static string ReadStringFromFile()
    {
        if(System.IO.File.Exists("JsonHolder"))
        {
            return File.ReadAllText("JsonHolder");
        }
        else
        {
            return "!";
        }
    }
    public static string ReadStringFromFile(string filePath)
    {
        return File.ReadAllText(filePath);
    }

    public static void WriteStringOnDrive(string jsonStringToWrite)
    {
        File.WriteAllText("JsonHolder", jsonStringToWrite);
        AssetDatabase.Refresh();
    }

    public static void WriteStringOnDrive(string jsonStringToWrite, string filePath)
    {
        File.WriteAllText(filePath, jsonStringToWrite);
        AssetDatabase.Refresh();
    }
}
