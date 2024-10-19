using MinimalApi.Dominio.Entidades;

namespace Test.Dominio
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Id = 1;
            veiculo.Marca = "Ford";
            veiculo.Nome = "Fiesta";
            veiculo.Ano = 2012;

            //Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("Ford", veiculo.Marca);
            Assert.AreEqual("Fiesta", veiculo.Nome);
            Assert.AreEqual(2012, veiculo.Ano);
        }
    }
}