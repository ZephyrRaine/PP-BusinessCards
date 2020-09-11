using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class Url : MonoBehaviour, IEventSystemHandler
{
    public GameObject otherPrefab;
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
        
    }

    private void Start()
    {
        Instantiate(otherPrefab, transform.parent);
    }

    
}
