namespace Models.Tasks;

public interface ITask
{
    /// <summary>
    /// The name of the task to be displayed to user.
    /// </summary>
    string Name { get; protected set; }

    /// <summary>
    /// A description of the task. 
    /// </summary>
    string Description { get; protected set; }
}