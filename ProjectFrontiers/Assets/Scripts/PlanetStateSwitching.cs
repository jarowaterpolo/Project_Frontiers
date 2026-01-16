using System.Collections;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlanetStateSwitching : MonoBehaviour
{
    public string TargetPlanetState;
    public char SwitchPlanetStateKey = 'q';

    public GameObject WastelandParent;
    public GameObject OvergrownParent;

    private int i;


    private void Start()
    {
   
    }

    public void Update()
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
                    TargetPlanetState = "Overgrown";
                    break;

                case "Overgrown":
                    OvergrownParent.SetActive(true);
                    WastelandParent.SetActive(false);
                    TargetPlanetState = "Wasteland";
                    break;
            }
        }
    }
}
