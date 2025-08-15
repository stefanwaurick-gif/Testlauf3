/// <summary>
/// Defines the types of statistics that a car part can modify.
/// </summary>
public enum StatType
{
    EnginePower,    // Affects acceleration
    Drag,           // Affects top speed (air resistance)
    Downforce,      // Affects grip (not used in simple physics, but good for future)
    Mass,           // Affects acceleration (F=ma)
    Friction,       // Affects rolling resistance
    FuelConsumptionRate // Affects how quickly fuel is used
}
