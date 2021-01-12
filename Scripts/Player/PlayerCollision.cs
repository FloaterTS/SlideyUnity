using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    

    void OnCollisionEnter(Collision collisionInfo) // daca player-ul a atins vreun obiect de tip obstacol, acesta isi pierde capacitatea de a se misca, iar scena de end game apare
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
