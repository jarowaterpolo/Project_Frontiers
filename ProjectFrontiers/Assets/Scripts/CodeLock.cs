using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CodeLock : MonoBehaviour
{
    private string input;
    public TMP_InputField CodeText;
    public void CodeInput()
    {
        Debug.Log("Clicked");

        input = gameObject.name;
        switch (input)
        {
            case "1":
                Debug.Log("1 was pressed");
                CodeText.text += "1";
                break;
            case "2":
                CodeText.text += "2";
                break;
            case "3":
                CodeText.text += "3";
                break;
            case "4":
                CodeText.text += "4";
                break;
            case "5":
                CodeText.text += "5";
                break;
            case "6":
                CodeText.text += "6";
                break;
            case "7":
                CodeText.text += "7";
                break;
            case "8":
                CodeText.text += "8";
                break;
            case "9":
                CodeText.text += "9";
                break;
            case "0":
                CodeText.text += "0";
                break;

            default:
                break;
        }
    }
}
