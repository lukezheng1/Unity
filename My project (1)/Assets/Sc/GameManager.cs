using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int fontSize;
    public float volume;
    private void Start()
    {
        fontSize = 0;
        volume = 1;
    }


    public void SetVolume(float vo)
    {
        volume = vo;
    }
    public void SetFontSize(float vo)
    {
        fontSize = -5 + (int)(vo * 10);
    }
    public void QuitApplcation()
    {
        Application.Quit();
    }
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
