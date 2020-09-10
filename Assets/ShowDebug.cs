using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[ExecuteInEditMode]
public class ShowDebug : MonoBehaviour
{
public RectTransform parent;
public TMP_Text text;
    // Update is called once per frame
    void Update()
    {
        text.text = "x : "+parent.localScale.x+" \n y : " + parent.localScale.y;
    }
}
