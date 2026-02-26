using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public PlayerMovement movement;


    void OnCollisionEnter(Collision info ) {

        if (info.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
