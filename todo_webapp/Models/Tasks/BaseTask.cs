namespace Models.Tasks;

public class BaseTask : ITask
{
    private string mName;
    private string mDescription;

    public string Name
    {
        get => mName;
        set => mName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Description
    {
        get => mDescription;
        set => mDescription = value ?? throw new ArgumentNullException(nameof(value));
    }
}