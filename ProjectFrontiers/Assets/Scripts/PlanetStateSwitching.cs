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

    public GameObject PlayerTracker;

    private void Start()
    {
        PlayerTracker = GameObject.FindGameObjectWithTag("PlayerTracker");
        DontDestroyOnLoad(PlayerTracker);

        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerTransform = Player.transform;

        PlayerTransform.position = PlayerTracker.transform.position;
        PlayerTransform.rotation = PlayerTracker.transform.rotation;
    }

    public void Update()
    {
        PlayerTracker.transform.position = PlayerTransform.position;
        PlayerTracker.transform.rotation = PlayerTransform.rotation;

        if (Input.GetKeyDown((KeyCode)SwitchPlanetStateKey))
        {
            //Debug.Log("test click");
            Debug.Log(PlayerTracker);
            SceneManagement.ChangePlanetState(TargetPlanetState);
        }
    }
}
