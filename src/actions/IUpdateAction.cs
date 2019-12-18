namespace mxcd.core.actions
{
    /// <summary>
    /// Action to execute before update an entity
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public interface IUpdateAction<in T>: IAction<T>
    {
    }
}
