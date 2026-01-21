using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCode : MonoBehaviour
{
    public void CheckCodeLock(string answer)
    {
        if (answer == "121247")
        {
            SceneManager.LoadScene("End");
        }
    }
}
