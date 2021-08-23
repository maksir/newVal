namespace NewControls.Values
{
    using System.Threading.Tasks;

    public interface IValProvider
    {
        T GetModelVal<T>(string name);

        T GetThemeVal<T>(string name);
    }
}