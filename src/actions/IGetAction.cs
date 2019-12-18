namespace mxcd.core.actions
{
    /// <summary>
    /// Action to execute after get an entity
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public interface IGetAction<in T>: IAction<T>
    {
    }
}
