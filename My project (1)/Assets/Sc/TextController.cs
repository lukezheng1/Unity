using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    private Text text;
    private int startSize;
    void Start()
    {
        text = GetComponent<Text>();
        startSize = text.fontSize;
    }

    // Update is called once per frame
    void Update()
    {
        text.fontSize = startSize + GameManager.instance.fontSize;
    }
}
