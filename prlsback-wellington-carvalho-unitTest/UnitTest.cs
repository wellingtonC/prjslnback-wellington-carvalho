using prjslnback_wellington_carvalho.Models;
using prjslnback_wellington_carvalho.Services;
using Xunit;

namespace prlsback_wellington_carvalho_unitTest
{
    public class UnitTest
    {
        [Fact]
        public void testGenerateToken()
        {
            Assert.NotNull(TokenService.GenerateToken("JoseC"));
        }

        [Fact]
        public void testValidatePassword()
        {
            PasswordValidations passwordTest = new PasswordValidations();
            Assert.True(passwordTest.PasswordValidator("H3l0@"));
        }

        [Fact]
        public void testCreateUser()
        {
            UserValidator user = new UserValidator();
            Assert.NotNull(user.GenerateUser("James", "J0sE_"));
        }
    }
}
