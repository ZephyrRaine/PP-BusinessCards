using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class LKD : MonoBehaviour, IEventSystemHandler
{
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
        
    }

    public void EnvoyerSignal(string button)
    {
        if (button == "calendar")
        {
            UnityMessageManager.Instance.SendMessageToFlutter("calendar");
        }else if (button=="mic")
        {
            UnityMessageManager.Instance.SendMessageToFlutter("mic");
        }  
    }
}
