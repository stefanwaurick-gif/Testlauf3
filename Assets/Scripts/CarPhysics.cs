using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Handles the physics simulation for a race car, calculating its position along a track spline.
/// </summary>
public class CarPhysics : MonoBehaviour
{
    [Header("Dependencies")]
    [Tooltip("The track spline the car will follow.")]
    public TrackSpline track;

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

    [Header("Fuel")]
    [Tooltip("The car's fuel tank capacity in liters.")]
    public float fuelTankCapacity = 110f;

    [Tooltip("The base rate of fuel consumption in liters per second at full throttle.")]
    public float baseFuelConsumptionRate = 0.05f;

    // Final, calculated stats after applying part modifiers
    private float finalEnginePower;
    private float finalDragCoefficient;
    private float finalFrictionConstant;
    private float finalMass;
    private float finalFuelConsumptionRate;

    [Header("Real-time Data")]
    [Tooltip("The current forward speed of the car in meters per second.")]
    [SerializeField]
    private float currentSpeed = 0f;

    [Tooltip("The car's current position along the track.")]
    [SerializeField]
    private float position = 0f;

    [Tooltip("The current amount of fuel in the tank, in liters.")]
    [SerializeField]
    private float currentFuel;

    // Internal physics state
    private float currentAcceleration = 0f;

    void Awake()
    {
        // Initialize fuel tank to full
        currentFuel = fuelTankCapacity;
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
        finalFuelConsumptionRate = baseFuelConsumptionRate;

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
                    case StatType.FuelConsumptionRate:
                        finalFuelConsumptionRate += modifier.Value;
                        break;
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
        // --- Fuel Consumption ---
        bool hasFuel = currentFuel > 0;
        float engineForce = hasFuel ? finalEnginePower : 0f;

        if (hasFuel)
        {
            currentFuel -= finalFuelConsumptionRate * Time.deltaTime;
            if (currentFuel < 0)
            {
                currentFuel = 0;
            }
        }

        // --- Physics Calculation ---
        // 1. Calculate Forces using the final stats calculated from parts
        float dragForce = finalDragCoefficient * currentSpeed * currentSpeed;
        float frictionForce = finalFrictionConstant;

        // 2. Calculate Net Force
        float netForce = engineForce - dragForce - frictionForce;

        if (currentSpeed <= 0 && netForce < 0)
        {
            netForce = 0;
        }

        // 3. Calculate Acceleration
        currentAcceleration = netForce / finalMass;

        // 4. Update Speed
        currentSpeed += currentAcceleration * Time.deltaTime;
        if (currentSpeed < 0)
        {
            currentSpeed = 0;
        }

        // 5. Update 1D Position (distance along spline)
        position += currentSpeed * Time.deltaTime;

        // 6. Update 3D Transform from Spline
        UpdateTransformFromSpline();
    }

    /// <summary>
    /// Updates the GameObject's 3D position and rotation based on the current distance along the spline.
    /// </summary>
    private void UpdateTransformFromSpline()
    {
        if (track == null)
        {
            // If no track is assigned, we can't calculate the 3D position.
            // We could log a warning, but for now we'll just do nothing.
            return;
        }

        // Get the 3D position and rotation from the spline
        track.GetPointAndRotation(position, out Vector3 newPosition, out Quaternion newRotation);

        // Apply the new transform to this GameObject
        transform.position = newPosition;
        transform.rotation = newRotation;
    }

    // Public getters for external scripts to read data
    public float GetCurrentSpeed() => currentSpeed;
    public float GetCurrentPosition() => position; // This is the 1D distance along the spline
    public float GetCurrentAcceleration() => currentAcceleration;

    /// <summary>
    /// Provides the current 3D world position and rotation of the car.
    /// This is the primary method for the graphics engine to use.
    /// </summary>
    /// <returns>A tuple containing the car's world position and rotation.</returns>
    public (Vector3 Position, Quaternion Rotation) GetWorldTransform()
    {
        return (transform.position, transform.rotation);
    }
}
