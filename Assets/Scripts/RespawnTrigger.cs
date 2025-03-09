using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    public Transform spawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = spawnPoint.position;
        }
    }
}
