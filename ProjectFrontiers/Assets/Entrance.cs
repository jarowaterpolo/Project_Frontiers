using UnityEngine;
using UnityEngine.SceneManagement;
public class Entrance : MonoBehaviour
{
    [Header("Setting")]
    [SerializeField] private string ScenceName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(ScenceName);
    }
}
