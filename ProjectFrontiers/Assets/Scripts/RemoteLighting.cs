using UnityEngine;

public class RemoteLighting : MonoBehaviour
{
    public static GameObject staticGreenLight;
    public static GameObject staticOrangeLight;

    public GameObject greenLight;
    public GameObject orangeLight;

    private void Start()
    {
        staticGreenLight = greenLight;
        staticOrangeLight = orangeLight;
    }

    void Update()
    {
        HandleGreenLight();
        HandleOrangeLight();
    }

    public static void HandleGreenLight()
    {
        if (staticGreenLight == null) return;

        bool isHoldingQ = Input.GetKey(KeyCode.Q);
        staticGreenLight.SetActive(isHoldingQ);
    }

    public static void HandleOrangeLight()
    {
        if (staticOrangeLight == null) return;

        bool isHoldingRightMouse = Input.GetMouseButton(1);
        staticOrangeLight.SetActive(isHoldingRightMouse);
    }
}