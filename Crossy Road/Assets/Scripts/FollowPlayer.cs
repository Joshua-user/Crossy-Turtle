using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -10);

    private void Update()
    {
        transform.position = player.transform.position + offset; 
    }
}
