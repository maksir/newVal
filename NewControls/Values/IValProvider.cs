namespace NewControls.Values
{
    public interface IValProvider
    {
        T GetModelVal<T>(string name);
    }
}