using ClasseObjeto;
using Xunit;

namespace XUnitTestProject.ClasseObjeto
{
    public class ClasseObjetoTest
    {
        [Fact]
        public void Verificar_latido_dog()
        {
            //arrange
            Dog dog = new Dog();

            //act
            var latido = dog.Latir();

            //assert
            Assert.Equal("Au au au", latido);
        }
    }
}
