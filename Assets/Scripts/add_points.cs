using UnityEngine;

public class eat_battery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("power_up"))
        {
            Destroy(collision.gameObject);
            score_manager.instance.addPoints();
        }
    }
}
