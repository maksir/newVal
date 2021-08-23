namespace NewControls.Values
{
    /// <summary>
    /// значение из темы оформления
    /// </summary>
    /// <typeparam name="T">тип значения</typeparam>
    public class ThemeVal<T> : Val<T>
    {
        /// <summary>
        /// название свойства темы
        /// </summary>
        private readonly string _name;

        public ThemeVal(string name)
        {
            _name = name;
        }

        /// <summary>
        /// получение значения из темы через провадер (визитор)
        /// </summary>
        /// <param name="vp"></param>
        /// <returns></returns>
        public override T GetVal(IValProvider vp) => vp.GetThemeVal<T>(_name);
        
        /// <summary>
        /// быстрый конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ThemeVal<T> Create(string name) => new ThemeVal<T>(name);
    }
}