using System.Collections.Generic;

namespace RomanArabicUI {
    public static class RomanArabicDictionary {
        public static Dictionary<string, int> RomanNumberDictionary = new Dictionary<string, int>() {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };

        public static Dictionary<int, string> NumberRomanDictionary = new Dictionary<int, string>() {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };
    }
}