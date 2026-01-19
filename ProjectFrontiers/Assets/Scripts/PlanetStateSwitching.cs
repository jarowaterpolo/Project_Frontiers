using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlanetStateSwitching : MonoBehaviour
{
    public string TargetPlanetState;
    public char SwitchPlanetStateKey = 'q';

    public GameObject WastelandParent;
    public GameObject OvergrownParent;

    public GameObject WastelandSwitch;
    public GameObject OvergrownSwitch;

    private int i;
    public static bool HasRemote;

    private float GlitchDelay = .15f;


    private void Start()
    {
        
    }

    public void Update()
    {
        if (HasRemote == true)
        {
            if (Input.GetKeyDown((KeyCode)SwitchPlanetStateKey) || Input.GetMouseButtonDown(1))
            {
                i++;
                //Debug.Log("test click");
                //Debug.Log(PlayerTracker);
                //SceneManagement.ChangePlanetState(TargetPlanetState);

                Debug.Log("Planet switch activated " + i + "times");
                switch (TargetPlanetState)
                {
                    case "Wasteland":
                        WastelandParent.SetActive(true);
                        OvergrownParent.SetActive(false);

                        WastelandSwitch.SetActive(true);
                        OvergrownSwitch.SetActive(false);

                        TargetPlanetState = "Overgrown";
                        break;

                    case "Overgrown":
                        OvergrownParent.SetActive(true);
                        WastelandParent.SetActive(false);

                        OvergrownSwitch.SetActive(true);
                        WastelandSwitch.SetActive(false);

                        TargetPlanetState = "Wasteland";
                        break;
                }
            }
        }
    }

    void WasteOn()
    {
        WastelandParent.SetActive(true);
        OvergrownParent.SetActive(false);
    }

    void OvergrownOn()
    {
        OvergrownParent.SetActive(true);
        WastelandParent.SetActive(false);
    }

    public void LabStart()
    {
        StartCoroutine("LabCutscene");
    }

    IEnumerator LabCutscene()
    {
        OvergrownOn();
        yield return new WaitForSeconds(GlitchDelay);
        WasteOn();
        yield return new WaitForSeconds(GlitchDelay);
        OvergrownOn();
        yield return new WaitForSeconds(GlitchDelay);
        WasteOn();
        yield return new WaitForSeconds(GlitchDelay);
        OvergrownOn();
        yield return new WaitForSeconds(GlitchDelay);
        WasteOn();
        yield return new WaitForSeconds(GlitchDelay);
        OvergrownOn();
    }
}
