using DNPJ;
using Xunit;


public class StringManipulatorTests
{
    private readonly StringManipulator _stringManipulator;

    public StringManipulatorTests()
    {
        _stringManipulator = new StringManipulator();
    }

    [Fact]

    public void ReverseString_InputIsHello_ShouldReturnOlleh()
    {
        var input = "Hola";

        var result = _stringManipulator.ReverseString(input);

        Assert.Equal("aloH", result);
    }

    [Fact]
    
    public void RemoveSpaces_InputHasSpaces_ShouldRemoveAllSpaces()
    {
        var input = "H  o l a";

        var result = _stringManipulator.RemoveSpaces(input);

        Assert.Equal("Hola", result);
    }
}
