using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class Url : MonoBehaviour, IEventSystemHandler
{
    public FollowMainPrefab otherPrefab;
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
        
    }

    private void Start()
    {
        var instance = Instantiate(otherPrefab, transform.parent);
        instance.toFollow = this.transform;
    }


    
}
