namespace mxcd.core.actions
{
    /// <summary>
    /// Action to execute before delete an entity
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public interface IDeleteAction<in T>:IAction<T>
    {
    }
}
