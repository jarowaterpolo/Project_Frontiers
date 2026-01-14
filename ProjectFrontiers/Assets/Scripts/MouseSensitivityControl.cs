using UnityEngine;
using UnityEngine.UI;

public class MouseSensitivityControl : MonoBehaviour
{
    public PlayerController playerPrefab;
    public Slider sensitivitySlider;
    void Start()
    {
        sensitivitySlider.value = playerPrefab.mouseSensitivity;
    }

    public void setSensitivity(float sensitivity)
    {
        playerPrefab.mouseSensitivity = sensitivity;
    }

    private void Update()
    {
        Debug.Log(playerPrefab.mouseSensitivity);
    }
}
