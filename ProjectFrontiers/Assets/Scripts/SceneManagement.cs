using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement
{
    [SerializeField] private string CurrentPlanetState;
    public void Update()
    {
        CurrentPlanetState = SceneManager.GetActiveScene().name;
    }

    public static void ChangePlanetState(string TargetState)
    {
        switch (TargetState)
        {
            case "Wasteland":
                SceneManager.LoadScene("Wasteland");
                break;

            case "OverGrown":
                SceneManager.LoadScene("OverGrown");
                break;

            default:
                Debug.Log("Somethings wrong");
                break;
        }
    }
}
