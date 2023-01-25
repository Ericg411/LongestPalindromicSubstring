using LongestPalindromicSubstring;

namespace LongestPalindromicSubstring.Tests;

[TestClass]
public class UnitTest1
{
    private readonly LongestPalindromicSubstring _longestPalindromicSubstring;

    public UnitTest1()
    {
        _longestPalindromicSubstring = new LongestPalindromicSubstring();
    }

    [TestMethod]
    public void TestMethod1()
    {
        string testString = "babad";

        string result = _longestPalindromicSubstring.LongestPalindrome(testString);

        Assert.AreEqual("aba", result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        string testString = "cbbd";

        string result = _longestPalindromicSubstring.LongestPalindrome(testString);

        Assert.AreEqual("bb", result);
    }

    [TestMethod]
    public void TestMethod3()
    {
        string testString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "bgaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaa";

        string result = _longestPalindromicSubstring.LongestPalindrome(testString);

        Assert.AreEqual("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", result);
    }

    [TestMethod]
    public void TestMethod4()
    {
        string testString = "ngjhfidosvjfiodnsgjiofndsugoifndsgufidosngufjiodsngufodsignufiodsngufidosjfdisalfhjdloskgjfkidnmihnyvbtysvtsvarscaesdxaerscvatysbniuasmoamsufnm" +
            "fdusaifbnudsbnafiyudhbsaiyfbydsbafyidsiuyafkdsyabfiyudsbafuiydsbavhfdbsvuyhfndmkhgomgfnaghfdsa";

        string result = _longestPalindromicSubstring.LongestPalindrome(testString);

        Assert.AreEqual("n", result);
    }
}