namespace UnitTest.Models
{
    public static class StringManipulation
    {
        public static string Substitute(string input, string search, string replace)
        {
            return input.Replace(search, replace);
        }
    }
}
