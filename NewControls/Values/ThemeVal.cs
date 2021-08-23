namespace NewControls.Values
{
    public class ThemeVal<T> : Val<T>
    {
        private readonly string _name;

        public ThemeVal(string name)
        {
            _name = name;
        }

        public override T GetVal(IValProvider vp) => vp.GetThemeVal<T>(_name);
        
        public static ThemeVal<T> Create(string name) => new ThemeVal<T>(name);
    }
}