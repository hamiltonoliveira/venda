using System;
using System.Text.RegularExpressions;

namespace Recurso.Validacao
{
  public class ValidarEmail
    {
        public static bool IsValid(string email) 
        {
          
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (rg.IsMatch(email))
            {
                return false;
            }
            else {
                return  true;
            }
           
        }
    }
}
