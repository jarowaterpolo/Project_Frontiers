using System.Collections;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlanetStateSwitching : MonoBehaviour
{
    private GameObject Player;
    private Transform PlayerTransform;

    public string TargetPlanetState;
    public char SwitchPlanetStateKey = 'q';

    public GameObject PlayerPosTracker;

    private void Start()
    {
        PlayerPosTracker = GameObject.FindGameObjectWithTag("PlayerPositionTracker");
        DontDestroyOnLoad(PlayerPosTracker);

        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerTransform = Player.transform;

        PlayerTransform.position = PlayerPosTracker.transform.position;
    }

    public void Update()
    {
        PlayerPosTracker.transform.position = PlayerTransform.position;

        if (Input.GetKeyDown((KeyCode)SwitchPlanetStateKey))
        {
            //Debug.Log("test click");
            Debug.Log(PlayerPosTracker);
            SceneManagement.ChangePlanetState(TargetPlanetState);
        }
    }
}
