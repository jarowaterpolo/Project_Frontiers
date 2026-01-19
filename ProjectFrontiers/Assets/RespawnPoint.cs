using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.CompareTag("Player"))
        {
            Debug.Log("set the respawn to " + gameObject.name);
            DeathPit.RespawnPoint = gameObject;
            //DeathPit.SetRespawnPoint(gameObject);
        }
    }
}
