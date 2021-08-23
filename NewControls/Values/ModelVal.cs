namespace NewControls.Values
{
    /// <summary>
    /// значение из модели
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ModelVal<T> : Val<T>
    {
        /// <summary>
        /// название свойства модели
        /// </summary>
        private string _name;

        public ModelVal(string name)
        {
            _name = name;
        }

        public override T GetVal(IValProvider vp) => vp.GetModelVal<T>(_name);

        /// <summary>
        /// быстрый конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ModelVal<T> Create(string name) => new ModelVal<T>(name);
    }
}