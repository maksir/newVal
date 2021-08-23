namespace NewControls.Values
{
    /// <summary>
    /// общий абстрактный класс
    /// с реализованным приведением типов для упрощения создания фиксированных значений
    /// </summary>
    /// <typeparam name="T">тип значения</typeparam>
    public abstract class Val<T> : IVal
    {
        public abstract T GetVal(IValProvider vp);

        object IVal.GetVal(IValProvider vp) => GetVal(vp);

        public static implicit operator Val<T>(T val) => new FixVal<T>(val);
    }
}