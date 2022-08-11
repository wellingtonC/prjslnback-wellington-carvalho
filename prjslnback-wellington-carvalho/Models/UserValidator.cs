using prjslnback_wellington_carvalho.Services;

namespace prjslnback_wellington_carvalho.Models
{
    public class UserValidator
    {
        public UserValidator(){}

        public UserDTO GenerateUser(string userName, string password) 
        {
            PasswordValidations passwordValid = new PasswordValidations();
            if (passwordValid.PasswordValidator(password) == true)
            {
                TokenValidDTO tokenValidate = TokenService.GenerateToken(userName);
                if(tokenValidate.tokenValue!=null && tokenValidate.expiresDate != null)
                {
                    UserDTO user = new UserDTO()
                    {
                        UserName = userName,
                        password = password,
                        Token = tokenValidate.tokenValue,
                        expirationDate = tokenValidate.expiresDate
                    };
                    return user;
                }
            }
         return null;
        }
    }
}
