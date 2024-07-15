namespace xUnitProject.Tests;

public class StringValidatorTest
{
    [Fact]
    public void TestIsStringEmpty()
    {
        StringValidator validator = new StringValidator();
        Assert.False(validator.isEmpty("Hello"));

    }
    [Theory]
    [InlineData("", true)]
    [InlineData("MyString", false)]
    [InlineData("My Writing is not perfect", false)]

    public void TestIsStringWhitespace(string input, bool isWhitespace/*(we can name anything)*/)
    {
        StringValidator validator = new StringValidator();
        Assert.Equal(isWhitespace, validator.isEmpty(input));
    }
}