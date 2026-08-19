namespace HolaMundo.Tests;

public class SaludoServiceTests
{
    [Fact]
    public void ObtenerSaludo_DebeRetornarHolaMundo()
    {
        // Arrange
        string esperado = "Hola Mundo";

        // Act
        string resultado = SaludoService.ObtenerSaludo();

        // Assert
        Assert.Equal(esperado, resultado);
    }
}