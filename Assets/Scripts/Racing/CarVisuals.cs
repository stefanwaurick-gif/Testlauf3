using UnityEngine;

public class CarVisuals : MonoBehaviour
{
    // This method will be called by the RaceSceneController
    // with data from the physics engine (Task P-004)
    public void UpdatePosition(Vector3 position, Quaternion rotation)
    {
        transform.position = position;
        transform.rotation = rotation;
    }
}
