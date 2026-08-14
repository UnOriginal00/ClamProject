using ClamBackend.Models;

namespace ClamBackend.Services;

public class JWTService
{
    public string CreateToken(User user)
    {
        if (user == null)
            throw new ArgumentNullException(nameof(user));

        return "Token";
    }
}
