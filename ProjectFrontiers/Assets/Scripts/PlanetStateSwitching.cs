using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlanetStateSwitching : MonoBehaviour
{
    [Header("STATE SWITCHING")]
    [Space(10)]
    public string TargetPlanetState;
    public char SwitchPlanetStateKey = 'q';

    public GameObject WastelandParent;
    public GameObject OvergrownParent;

    public GameObject WastelandSwitch;
    public GameObject OvergrownSwitch;

    public static bool HasRemote;

    [Space(20)]
    [Header("AUDIO STUFF")]
    [Space(10)]
    public UnityEvent Audio;

    [Space(20)]
    [Header("ERROR STUFF")]
    [Space(10)]
    private int i;
    public GameObject ErrorCanvas;
    public UnityEvent ErrorStop;

    //[Header("Cutscene stuff")]
    private float GlitchDelay = .15f;
    private bool StartCutsceneDone = false;

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

                if (i >= 250)
                {
                    ErrorCanvas.SetActive(true);
                    ErrorStop.Invoke();
                    return;
                }


                switch (TargetPlanetState)
                {
                    case "Wasteland":
                        WastelandParent.SetActive(true);
                        OvergrownParent.SetActive(false);

                        WastelandSwitch.SetActive(true);
                        OvergrownSwitch.SetActive(false);

                        RemoteLighting.OrangeLightOn();

                        TargetPlanetState = "Overgrown";
                        break;

                    case "Overgrown":
                        OvergrownParent.SetActive(true);
                        WastelandParent.SetActive(false);

                        OvergrownSwitch.SetActive(true);
                        WastelandSwitch.SetActive(false);

                        RemoteLighting.GreenLightOn();

                        TargetPlanetState = "Wasteland";
                        break;
                }

                Audio.Invoke();
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
        StartCutsceneDone = true;
    }

    IEnumerator LabCutscene()
    {
        if (StartCutsceneDone != true)
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
            Audio.Invoke();
        }
        else
        {
            yield return null;
        }
    }
}
