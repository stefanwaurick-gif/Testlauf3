using UnityEngine;

/// <summary>
/// A placeholder implementation of a track spline.
/// This provides a simple, mathematically defined path for the physics engine to follow.
/// In a real implementation, this would likely read data from a tool or asset.
/// </summary>
public class TrackSpline : MonoBehaviour
{
    [Header("Track Shape")]
    [Tooltip("The radius of the circular track in meters.")]
    public float radius = 100f;

    // The total length of the circular track (circumference).
    public float Length { get; private set; }

    private void Awake()
    {
        Length = 2 * Mathf.PI * radius;
    }

    /// <summary>
    /// Gets the 3D world position and tangential rotation for a given distance along the track spline.
    /// </summary>
    /// <param name="distance">The distance from the start of the track.</param>
    /// <param name="position">The calculated 3D position on the spline.</param>
    /// <param name="rotation">The calculated tangential rotation on the spline.</param>
    public void GetPointAndRotation(float distance, out Vector3 position, out Quaternion rotation)
    {
        // Ensure the distance wraps around the track length
        float wrappedDistance = distance % Length;
        if (wrappedDistance < 0)
        {
            wrappedDistance += Length;
        }

        // Calculate the angle on the circle based on the distance
        // Angle (in radians) = distance / radius
        float angle = wrappedDistance / radius;

        // Calculate the X and Z coordinates on the circle
        float x = radius * Mathf.Sin(angle);
        float z = radius * Mathf.Cos(angle);

        position = new Vector3(x, 0, z);

        // The rotation should be tangential to the circle.
        // The tangent is perpendicular to the radius vector.
        // We can find this by rotating the direction vector from the center by 90 degrees.
        // Or more simply, the forward vector is the derivative of the position vector.
        // Position = (R*sin(t), 0, R*cos(t))
        // Derivative = (R*cos(t), 0, -R*sin(t))
        Vector3 forward = new Vector3(Mathf.Cos(angle), 0, -Mathf.Sin(angle));
        rotation = Quaternion.LookRotation(forward, Vector3.up);
    }
}
