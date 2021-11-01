
using UnityEngine;

public class CameraM : MonoBehaviour
{
    public Transform capsule;
public Vector3 offset;

    void Update()
    {
        transform.position = capsule.position + offset;
    }
}
