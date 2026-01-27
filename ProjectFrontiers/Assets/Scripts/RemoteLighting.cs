using UnityEngine;

public class RemoteLighting : MonoBehaviour
{
    public static GameObject staticGreenLight;
    public static GameObject staticOrangeLight;

    public GameObject greenLight;
    public GameObject orangeLight;

    public static bool InWasteland = true;

    private void Start()
    {
        staticGreenLight = greenLight;
        staticOrangeLight = orangeLight;
    }

    public static void GreenLightOn()
    {
        if (staticGreenLight == null) return;

        staticGreenLight.SetActive(true);
        staticOrangeLight.SetActive(false);
    }

    public static void OrangeLightOn()
    {
        if (staticOrangeLight == null) return;

        staticGreenLight.SetActive(false);
        staticOrangeLight.SetActive(true);
    }
}