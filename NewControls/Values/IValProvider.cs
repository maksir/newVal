namespace NewControls.Values
{
    /// <summary>
    /// провайдер значений, осуществляет связь или с моделью или с темой оформления.
    /// паттерн: визитор
    /// </summary>
    public interface IValProvider
    {
        /// <summary>
        /// получение значения из модели
        /// </summary>
        /// <param name="name">название свойства модели</param>
        /// <typeparam name="T">тип значения</typeparam>
        /// <returns></returns>
        T GetModelVal<T>(string name);

        /// <summary>
        /// получение занчения из темы оформления
        /// </summary>
        /// <param name="name">название свойства темы</param>
        /// <typeparam name="T">тип свойства</typeparam>
        /// <returns></returns>
        T GetThemeVal<T>(string name);
    }
}