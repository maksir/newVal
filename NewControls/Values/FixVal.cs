namespace NewControls.Values
{
    /// <summary>
    /// Фиксированное значение
    /// </summary>
    /// <typeparam name="T">тип значения</typeparam>
    public class FixVal<T> : Val<T>
    {
        private readonly T _val;

        public FixVal(T val)
        {
            _val = val;
        }

        /// <summary>
        /// получение значения
        /// </summary>
        /// <param name="vp">визитор: провайдер значений, тут не используется</param>
        /// <returns></returns>
        public override T GetVal(IValProvider vp)
        {
            return _val;
        }
    }
}