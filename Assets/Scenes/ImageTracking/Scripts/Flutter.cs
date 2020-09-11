using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flutter : MonoBehaviour
{
    // Start is called before the first frame update
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
