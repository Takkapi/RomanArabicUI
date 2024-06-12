using System.Linq;

namespace RomanArabicUI {
    public class ConvertRomanToArabic : IConvert<int, string> {
        public int Convert(string inputRoman) {
            int arabic = 0;
            for(int i = 0; i < inputRoman.Count(); i++) {
                if(!RomanArabicDictionary.RomanNumberDictionary.ContainsKey(inputRoman[i].ToString()))
                    return 0;
                if(i == inputRoman.Count() - 1) {
                    arabic += RomanArabicDictionary.RomanNumberDictionary[inputRoman[i].ToString()];
                } else {
                    if(RomanArabicDictionary.RomanNumberDictionary[inputRoman[i + 1].ToString()] > RomanArabicDictionary.RomanNumberDictionary[inputRoman[i].ToString()])
                        arabic -= RomanArabicDictionary.RomanNumberDictionary[inputRoman[i].ToString()];
                    else arabic += RomanArabicDictionary.RomanNumberDictionary[inputRoman[i].ToString()];
                }
            }
            return arabic;
        }
    }
}