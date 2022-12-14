using Microsoft.EntityFrameworkCore;
using prjslnback_wellington_carvalho.Controllers;
using prjslnback_wellington_carvalho.Data;
using prjslnback_wellington_carvalho.Models;
using prjslnback_wellington_carvalho.Services;
using Xunit;

namespace UnitTestProject
{
    public class UnitTest1
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
            Assert.notnu(user.GenerateUser("James", "J0sE_"));
        }


    }
}
