using UnityEngine;

public class DeathPit : MonoBehaviour
{
    public static GameObject RespawnPoint;
    public GameObject StartSpawnPoint;

    private void Start()
    {
        RespawnPoint = StartSpawnPoint;
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(collision);
    //    Debug.Log(collision.transform.parent);
    //    Debug.Log(collision.transform.parent.name);
    //    Debug.Log(collision.transform.parent.tag);

    //    if (collision.transform.parent.CompareTag("Player"))
    //    {
    //        collision.transform.position = RespawnPoint.transform.position;
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Debug.Log(other.transform.parent);
        Debug.Log(other.transform.parent.name);
        Debug.Log(other.transform.parent.tag);

        if (other.transform.parent.CompareTag("Player"))
        {
            Debug.Log(RespawnPoint.transform.position);
            other.transform.parent.position = RespawnPoint.transform.position;
        }
    }

    public static void SetRespawnPoint(GameObject Spawn)
    {
        Debug.Log("respawn set to " + Spawn.name);
        RespawnPoint = Spawn;
        Debug.Log("respawn is now " + RespawnPoint.name);
    }
}
