using UnityEngine;

public class player_death : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("bombEnemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
