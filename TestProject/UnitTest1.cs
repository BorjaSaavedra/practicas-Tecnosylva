using DataModels;
using gestorModel.Repository;
using LinqToDB;
using LinqToDB.Data;
using static LinqToDB.Common.Configuration;

namespace TestProject
{
    public class Tests
    {

        private UserRepository<Usuario> userRepository;
        private RolRepository<Role> rolRepository;
        private DataConnection connection;

        [SetUp]
        public void Setup()
        {
            //Inicializamos una nueva conexion a nuestra bd
            connection = new DataConnection(
                new DataOptions()
                .UseSqlServer(@"Server=DESKTOP-E8O5D44\SQLEXPRESS\;Database=BDGestorCapas;Trusted_Connection=True;"));
        }


        [Test]
        public void TestNewRol()
        {
            Role rol = new Role();
            //Seteamos sus datos
            rol.IdRol = Guid.NewGuid();
            rol.Nivel = "Principiante";
            //Llamamos al metodo del repositorio que agrega roles
            rolRepository.add(rol);
            //Compruebo que el objeto inicial no sea nulo
            Assert.IsNotNull(rol);
        }
    }
}