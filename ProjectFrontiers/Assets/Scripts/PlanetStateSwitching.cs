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

    private GameObject PlayerCam;
    private Transform PlayerCamTransform;

    public static float SavedRot;

    public string TargetPlanetState;
    public char SwitchPlanetStateKey = 'q';

    public GameObject PlayerTracker;
    public GameObject PlayerCamTracker;

    private void Start()
    {
        PlayerTracker = GameObject.FindGameObjectWithTag("PlayerTracker");
        DontDestroyOnLoad(PlayerTracker);

        PlayerCamTracker = GameObject.FindGameObjectWithTag("PlayerCamTracker");
        DontDestroyOnLoad(PlayerCamTracker);

        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerTransform = Player.transform;

        PlayerCam = GameObject.FindGameObjectWithTag("MainCamera");
        PlayerCamTransform = PlayerCam.transform;

        PlayerTransform.position = PlayerTracker.transform.position;
        PlayerTransform.rotation = PlayerTracker.transform.rotation;

        SavedRot = PlayerCamTracker.transform.localEulerAngles.x;

        if (SavedRot > 90)
        {
            SavedRot -= 360;
        }
        Debug.Log("rot = " + SavedRot);
    }

    public void Update()
    {
        PlayerTracker.transform.position = PlayerTransform.position;
        PlayerTracker.transform.rotation = PlayerTransform.rotation;

        PlayerCamTracker.transform.rotation = PlayerCamTransform.rotation;

        if (Input.GetKeyDown((KeyCode)SwitchPlanetStateKey))
        {
            //Debug.Log("test click");
            Debug.Log(PlayerTracker);
            SceneManagement.ChangePlanetState(TargetPlanetState);
        }
    }
}
