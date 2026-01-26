using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MouseSensitivityControl : MonoBehaviour
{
    public PlayerController playerPrefab;
    public Slider sensitivitySlider;
    public TMP_Text PercentText;
    void Start()
    {
        playerPrefab = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        sensitivitySlider.value = playerPrefab.mouseSensitivity;
        PercentText.text = Mathf.Round(sensitivitySlider.value * 100) + "";
    }

    public void setSensitivity(float sensitivity)
    {
        playerPrefab.mouseSensitivity = sensitivity;
        PercentText.text = Mathf.Round(sensitivity * 100) + "";
    }

    private void Update()
    {
        //Debug.Log(playerPrefab.mouseSensitivity);
    }
}
