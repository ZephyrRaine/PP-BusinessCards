using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickSprite : MonoBehaviour
{
    public UnityEvent onClickEvent;
    // Start is called before the first frame update
    private void onMouseDown(){
        onClickEvent?.Invoke();
    }
}
