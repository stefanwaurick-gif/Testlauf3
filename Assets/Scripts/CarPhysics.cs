using UnityEngine;

/// <summary>
/// Handles the basic 2D physics simulation for a race car on a straight track.
/// </summary>
public class CarPhysics : MonoBehaviour
{
    [Header("Physics Parameters")]
    [Tooltip("The maximum force the engine can produce in Newtons.")]
    public float enginePower = 30000f;

    [Tooltip("The aerodynamic drag coefficient. Determines how much air resistance affects the car.")]
    public float dragCoefficient = 0.8f;

    [Tooltip("The constant friction force, representing rolling resistance.")]
    public float frictionConstant = 200f;

    [Tooltip("The total mass of the car in kilograms.")]
    public float mass = 1500f;

    [Header("Real-time Data")]
    [Tooltip("The current forward speed of the car in meters per second.")]
    [SerializeField]
    private float currentSpeed = 0f;

    [Tooltip("The car's current position along the track.")]
    [SerializeField]
    private float position = 0f;

    // Internal physics state
    private float currentAcceleration = 0f;

    /// <summary>
    /// Update is called once per frame.
    /// This is where the physics calculations happen.
    /// </summary>
    void Update()
    {
        // 1. Calculate Forces
        float engineForce = enginePower; // For now, assume constant engine force
        float dragForce = dragCoefficient * currentSpeed * currentSpeed; // Drag = C * v^2
        float frictionForce = frictionConstant;

        // 2. Calculate Net Force
        // Net force determines the change in motion.
        float netForce = engineForce - dragForce - frictionForce;

        // Ensure the car doesn't move backwards if forces are negative at standstill
        if (currentSpeed <= 0 && netForce < 0)
        {
            netForce = 0;
        }

        // 3. Calculate Acceleration
        // F = m * a  =>  a = F / m
        currentAcceleration = netForce / mass;

        // 4. Update Speed
        // New speed is the old speed plus the change in speed (acceleration * time).
        currentSpeed += currentAcceleration * Time.deltaTime;
        if (currentSpeed < 0)
        {
            currentSpeed = 0; // The car should not move backwards
        }

        // 5. Update Position
        // New position is the old position plus the distance covered in this frame (speed * time).
        position += currentSpeed * Time.deltaTime;

        // Optional: Update the GameObject's transform to visualize the position
        // This assumes the car moves along the Z-axis in world space.
        transform.position = new Vector3(transform.position.x, transform.position.y, position);
    }

    // Public getters for external scripts to read data
    public float GetCurrentSpeed() => currentSpeed;
    public float GetCurrentPosition() => position;
    public float GetCurrentAcceleration() => currentAcceleration;
}
