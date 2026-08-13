namespace ClamProject.Services;

using ClamProject.Models;

public class JWTService
{
    public string CreateToken(User user)
    {
        if(user == null) 
            throw new ArgumentNullException("user");



        return "Token";
    }
}
