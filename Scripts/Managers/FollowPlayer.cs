using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public Transform player;
    public Vector3 offset;

    
    void Update() // metoda pentru modificarea pozitiei camerei
    {
        transform.position = player.position + offset;
    }
}
