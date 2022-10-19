using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLib.Util
{
    public static class StringHelper
    {
        public enum StringSimilarityScanType
        { 
            NONE = 0, ALL_MATCH = 99, AT_LEAST_ONE = 1, HALF_OR_ABOVE = 2, HALF_OR_BELOW = 3
        }

        public static double LevenshteinDistance(string str1, string str2)
        {
            int n = str1.Length;
            int m = str2.Length;
            int[,] distance = new int[n + 1, m + 1]; // matrix
            int cost = 0;
            if (n == 0) return m;
            if (m == 0) return n;
            //init1
            for (int i = 0; i <= n; distance[i, 0] = i++) ;
            for (int j = 0; j <= m; distance[0, j] = j++) ;
            //find min distance
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    cost = (str2.Substring(j - 1, 1) == str1.Substring(i - 1, 1) ? 0 : 1);
                    distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
                }
            }

            PrintLevenshteinDistance(distance, n, m);
            float dis = distance[n, m];
            float maxLen = (str1.Length <= str2.Length) ? str1.Length : str2.Length;
            if (maxLen == 0.0F)
                return 1;
            else
                return 1 - (dis / maxLen);
        }


        private static void PrintLevenshteinDistance(int[,] arr, int n, int m)
        {
            var str = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    str += arr[i, j].ToString() + "\t";
                }
                str += "\n";
            }
            System.Diagnostics.Debug.WriteLine(str);
        }

        public static double CompareStringSimilarity(string str1, string str2)
        {
            double score = 0;
            if (String.IsNullOrEmpty(str1.Trim()) || String.IsNullOrEmpty(str1.Trim()))
                return 0;

            string s1 = str1.Trim().ToUpper().Replace(" ", "");
            string s2 = str2.Trim().ToUpper().Replace(" ", "");

            if (s1 == s2)
                return 1;

            var arrCharArray = s1.Length <= s2.Length ? s1.ToCharArray() : s2.ToCharArray();
            var strCompareString = s1.Length <= s2.Length ? s2 : s1;
            var intMaxLength = s1.Length <= s2.Length ? s2.Length : s1.Length;

            foreach (var c in arrCharArray)
            {
                if (strCompareString.Contains(c))
                    strCompareString = strCompareString.Remove(strCompareString.IndexOf(c), 1);
            }
            score = intMaxLength - strCompareString.Length;
            return (score == 0) ? 0 : score/intMaxLength;
        }

        public static double CompareStringSimilarity2(string str1, string str2, StringSimilarityScanType type, bool IgnoreFullyMatchWord = true)
        {
            str1 = str1.Trim();
            str2 = str2.Trim();
            while (str1.Contains("  "))
                str1 = str1.Replace("  ", " ");
            while (str2.Contains("  "))
                str2 = str2.Replace("  ", " ");

            if (str1 == str2)
                return 1;
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
                return 0;

            var arr1 = str1.Split(' ');
            var arr2 = str2.Split(' ');
            var a1 = arr1.Length <= arr2.Length ? arr1 : arr2;
            var a2 = arr1.Length <= arr2.Length ? arr2 : arr1;
            double intMatchCount = 0;

            switch (type)
            {
                case StringSimilarityScanType.ALL_MATCH:
                    intMatchCount = a1.Length;
                    break;
                case StringSimilarityScanType.AT_LEAST_ONE:
                    intMatchCount = 1;
                    break;
                case StringSimilarityScanType.HALF_OR_ABOVE:
                    intMatchCount = a1.Length == 1 ? 1 : a1.Length / 2;
                    break;
                case StringSimilarityScanType.HALF_OR_BELOW:
                    intMatchCount = a1.Length == 1 ? 1 : (a1.Length / 2) + (a1.Length % 2);
                    break;
            }

            var arrCompare1 = a1.ToList();
            var arrCompare2 = a2.ToList();
            var intCount = 0;
            var intFullMatchChar = 0;

            foreach (var s in a1)
            {
                if (a2.Contains(s))
                {
                    intCount++;
                    arrCompare1.Remove(s);
                    arrCompare2.Remove(s);
                    intFullMatchChar += s.Length;
                }
            }

            if (intCount >= intMatchCount)
            {
                double result = 0;
                if (IgnoreFullyMatchWord)
                {
                    result = LevenshteinDistance(String.Join("", arrCompare1), String.Join("", arrCompare2));
                    //System.Diagnostics.Debug.WriteLine(String.Format("{0} => {1} : {2}", str1, str2, result));

                    return result;
                }
                else
                {
                    double intMatchScore = LevenshteinDistance(String.Join("", arrCompare1), String.Join("", arrCompare2));
                    double intTotalLength = (str1.Length <= str2.Length) ? str1.Length : str2.Length;
                    var ratio = (intFullMatchChar / intTotalLength);
                    result = (intMatchScore * (1 - ratio)) + ratio;

                    //System.Diagnostics.Debug.WriteLine(String.Format("{0} => {1} : {2}", str1, str2, result));
                    return result;
                }

            }
            else
                return 0;
        }
    }
}
