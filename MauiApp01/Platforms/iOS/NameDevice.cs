namespace MauiApp01;

public partial class NameDevice
{
    public partial string GetName() => Guid.NewGuid().ToString();
}
