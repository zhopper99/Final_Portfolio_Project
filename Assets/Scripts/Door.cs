using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Transform previousRoom;
    [SerializeField] Transform nextRoom;
    [SerializeField] private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.position.x < transform.position.x)
            cam.MoveToNewRoom(nextRoom);
        else
            cam.MoveToNewRoom(previousRoom);
    }
}
