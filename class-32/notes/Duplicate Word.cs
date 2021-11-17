string words = "Cat dog dog cat!"

string[] wordList = Regex.Split(words, "[^\w]+");

//var wordsSeen = new Dictionary<string, ????>();
var wordsSeen = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);

foreach (var word in wordList)
{
    if (wordsSeen.Contains(word))
        return word;

    wordsSeen.Add(word);
}

return null; // or throw?



[Theory]
[InlineData("lots of words of", "of")]
[InlineData("No duplicates", null)]
[InlineData("Dog cat Cat dog", "cat")]
[InlineData("a a a a", "a")]
[InlineData("a", null)]
[InlineData("", null)]
[InlineData(".", null)]
[InlineData("lots. of. words. with. punctuation. lots!", "lots")]
public void RepeatedWord_works(string words, string expected)
{
    // Arrange

    // Act
    string result = RepeatedWord(words);

    // Assert
    Assert.Equal(expected, result);
}









