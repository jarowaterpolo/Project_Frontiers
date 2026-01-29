using UnityEngine;
using UnityEngine.Events;

public class UIClose : MonoBehaviour
{
    public GameObject[] UIs;
    public UnityEvent EscControll;
    private bool SettingsOn = false;

    public UnityEvent OpenSettings;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Debug.Log("escape been pressed");

            if (SettingsOn == true)
            {
                CloseAllUI();
                SettingsOn = false;
            }
            else
            {
                OpenSettings.Invoke();
                SettingsOn = true;
            }
        }
    }

    void CloseAllUI()
    {
        foreach (GameObject ui in UIs) 
        { 
            ui.SetActive(false);
            Debug.Log("closed " + ui);
        }

        EscControll.Invoke();
    }
}
