using UnityEngine;

public class CameraScroller : MonoBehaviour
{
    public float scrollSpeed = 2f;

    void Update()
    {
        transform.position += Vector3.right * scrollSpeed * Time.deltaTime;
    }
}
