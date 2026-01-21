using UnityEngine;
using UnityEngine.Events;

public class OpenSettings : MonoBehaviour
{
    public UnityEvent Open_Settings;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            Open_Settings.Invoke();
        }
    }
}
