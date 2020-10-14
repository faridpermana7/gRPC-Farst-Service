namespace GrpcFarstCommon
{
    public interface IContextBase<T>
    {
        T Db { get; }
    }
}
