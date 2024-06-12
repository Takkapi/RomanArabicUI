namespace RomanArabicUI {
    public interface IConvert<T1, T2> {
        T1 Convert(T2 input);
    }
}