using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Handles the basic 2D physics simulation for a race car on a straight track.
/// </summary>
public class CarPhysics : MonoBehaviour
{
    [Header("Car Parts")]
    [Tooltip("The list of parts currently equipped on the car.")]
    public List<CarPartData> equippedParts;

    [Header("Base Physics Parameters")]
    [Tooltip("The base engine power of the chassis in Newtons, before part modifiers.")]
    public float baseEnginePower = 30000f;

    [Tooltip("The base aerodynamic drag coefficient of the chassis.")]
    public float baseDragCoefficient = 0.8f;

    [Tooltip("The base constant friction force, representing rolling resistance.")]
    public float baseFrictionConstant = 200f;

    [Tooltip("The base mass of the car in kilograms, before part modifiers.")]
    public float baseMass = 1500f;

    // Final, calculated stats after applying part modifiers
    private float finalEnginePower;
    private float finalDragCoefficient;
    private float finalFrictionConstant;
    private float finalMass;

    [Header("Real-time Data")]
    [Tooltip("The current forward speed of the car in meters per second.")]
    [SerializeField]
    private float currentSpeed = 0f;

    [Tooltip("The car's current position along the track.")]
    [SerializeField]
    private float position = 0f;

    // Internal physics state
    private float currentAcceleration = 0f;

    void Awake()
    {
        CalculatePerformanceFromParts();
    }

    /// <summary>
    /// Calculates the final performance stats by combining base stats with modifiers from equipped parts.
    /// </summary>
    void CalculatePerformanceFromParts()
    {
        // Start with base stats
        finalEnginePower = baseEnginePower;
        finalDragCoefficient = baseDragCoefficient;
        finalFrictionConstant = baseFrictionConstant;
        finalMass = baseMass;

        if (equippedParts == null) return;

        // Apply modifiers from each part
        foreach (var part in equippedParts)
        {
            if (part == null || part.StatModifiers == null) continue;

            foreach (var modifier in part.StatModifiers)
            {
                switch (modifier.Stat)
                {
                    case StatType.EnginePower:
                        finalEnginePower += modifier.Value;
                        break;
                    case StatType.Drag:
                        finalDragCoefficient += modifier.Value;
                        break;
                    case StatType.Friction:
                        finalFrictionConstant += modifier.Value;
                        break;
                    case StatType.Mass:
                        finalMass += modifier.Value;
                        break;
                    // Downforce is not used in this simple model yet
                    case StatType.Downforce:
                        break;
                }
            }
        }
    }

    /// <summary>
    /// Update is called once per frame.
    /// This is where the physics calculations happen.
    /// </summary>
    void Update()
    {
        // 1. Calculate Forces using the final stats calculated from parts
        float engineForce = finalEnginePower;
        float dragForce = finalDragCoefficient * currentSpeed * currentSpeed; // Drag = C * v^2
        float frictionForce = finalFrictionConstant;

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
        currentAcceleration = netForce / finalMass;

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
