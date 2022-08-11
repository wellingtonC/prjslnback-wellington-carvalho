namespace prjslnback_wellington_carvalho.Models
{
    public class PasswordValidations
    {
        public PasswordValidations(){}

        public bool PasswordValidator(string password)
        {
            char[] specialCaracteres = { '#', '@', '!', '_','+','-' };
            char[] UpperCase = { 'A', 'B', 'C', 'D', 'F', 'G', 'H', 'I', 'J', 'K','L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'W', 'Y', 'Z' };
            char[] LowerCase = { 'a', 'b', 'c', 'd', 'f', 'g', 'h', 'i', 'j', 'k','l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'w', 'y', 'z' };

            bool containspecial = false;
            bool checkUper = false;
            bool checkLower = false;
            foreach (var item in specialCaracteres)
            {
                if (password.Contains(item))
                {
                    containspecial = true;
                }
            }
            foreach (var x in UpperCase) 
            {
                if (password.Contains(x)) 
                {
                    checkUper = true;
                }
            }
            foreach (var y in LowerCase) 
            {
                if (password.Contains(y)) 
                {
                    checkLower = true;
                }
            }
            int trys = 0;
            for (int i = 0; i <= password.Length - 1; i++)
            {
                if (i >= 1)
                {
                    if (password[i] == password[i - 1])
                    {
                        trys++;
                        if (trys >0)
                        {
                            return false;
                        }
                    }
                }
            }

            if (containspecial == true && checkUper == true && checkLower==true)
            {
                return true;
            }
            return false;
        }
    }
}

