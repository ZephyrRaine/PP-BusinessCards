using UnityEngine;
using System.Collections;

public class LKD : MonoBehaviour
{
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
        
    }

    public void EnvoyerSignal(string button)
    {
        if (button == "calendar")
        {
            
        }else if (button=="mic")
        {
            
        }  
    }
}
