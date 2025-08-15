// CarPhysics.cs
//
// This script implements a simple 2D physics simulation for a racing car.
// It calculates the car's movement on a straight track based on engine power,
// air resistance (drag), and rolling friction.
//
// Sofia - Physics Engine Programmer

using UnityEngine;

/// <summary>
/// Manages the physics simulation for a single car.
/// Attach this component to a car's GameObject.
/// </summary>
public class CarPhysics : MonoBehaviour
{
    [Header("Physics Properties")]
    [Tooltip("Mass of the car in kilograms.")]
    public float mass = 1000f; // kg

    [Tooltip("The maximum force the engine can produce in Newtons.")]
    public float engineForce = 3000f; // N

    [Tooltip("The drag coefficient, representing air resistance.")]
    public float dragCoefficient = 0.425f;

    [Tooltip("The rolling friction coefficient.")]
    public float frictionCoefficient = 30f; // This will be a simplified constant force

    // Private physics state variables
    private Vector3 velocity;
    private Vector3 acceleration;

    /// <summary>
    /// Called once per frame by Unity.
    /// </summary>
    void Update()
    {
        // For now, we assume the engine is always at full throttle.
        float currentEngineForce = engineForce;

        // Calculate opposing forces
        Vector3 dragForce = CalculateDragForce();
        Vector3 frictionForce = CalculateFrictionForce();

        // Calculate net force
        Vector3 netForce = (transform.forward * currentEngineForce) - dragForce - frictionForce;

        // Calculate acceleration (Newton's second law: F = ma -> a = F/m)
        acceleration = netForce / mass;

        // Update velocity
        velocity += acceleration * Time.deltaTime;

        // Update position
        transform.position += velocity * Time.deltaTime;
    }

    /// <summary>
    /// Calculates the air resistance (drag) force.
    /// Drag is proportional to the square of the velocity.
    /// </summary>
    /// <returns>The drag force vector.</returns>
    private Vector3 CalculateDragForce()
    {
        // Simplified drag formula: F_drag = C_drag * v^2
        // A more accurate formula is 0.5 * rho * A * C_d * v^2, but we simplify for now.
        float speed = velocity.magnitude;
        float dragMagnitude = dragCoefficient * speed * speed;

        // The drag force opposes the direction of velocity.
        return velocity.normalized * dragMagnitude;
    }

    /// <summary>
    /// Calculates the rolling friction force.
    /// This is simplified to a constant force opposing motion.
    /// </summary>
    /// <returns>The friction force vector.</returns>
    private Vector3 CalculateFrictionForce()
    {
        // As a simplification, we use a constant friction force that always opposes motion.
        // It only applies if the car is moving.
        if (velocity.magnitude < 0.1f)
        {
            return Vector3.zero;
        }

        return velocity.normalized * frictionCoefficient;
    }

    /// <summary>
    /// Resets the car's physics state (velocity and acceleration).
    /// </summary>
    public void Reset()
    {
        velocity = Vector3.zero;
        acceleration = Vector3.zero;
    }
}
