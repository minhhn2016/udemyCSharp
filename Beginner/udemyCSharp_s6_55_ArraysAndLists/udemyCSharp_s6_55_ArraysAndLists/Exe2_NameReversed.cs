namespace udemyCSharp_s6_55_ArraysAndLists
{
    internal class Exe2NameReversed
    {
        public static string NameReversed(string input)
        {
            var nameToChar = input.ToCharArray();
            var charReversed = new char[nameToChar.Length];
            for (var i = 0; i < nameToChar.Length; i++)
                charReversed[i] = nameToChar[nameToChar.Length - 1 - i];
            var reversedName = new string(charReversed);
            return reversedName;
        }
    }
}