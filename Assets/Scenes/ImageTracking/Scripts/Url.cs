using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class Url : MonoBehaviour
{
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
        
    }
    
}
