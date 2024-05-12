using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Transform previousRoom;
    [SerializeField] Transform nextRoom;
    [SerializeField] private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.position.x < transform.position.x)
        {
            cam.MoveToNewRoom(nextRoom);
            nextRoom.GetComponent<Room>().ActivateRoom(true);
            previousRoom.GetComponent<Room>().ActivateRoom(false);
        }

        else
        {
            cam.MoveToNewRoom(previousRoom);
            nextRoom.GetComponent<Room>().ActivateRoom(false);
            previousRoom.GetComponent<Room>().ActivateRoom(true);
        }

    }
}
