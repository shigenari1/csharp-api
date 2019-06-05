using System;
namespace UseCase.Users.Create
{
    public class UserCreateResponse
    {
        public UserCreateResponse(string userId)
        {
            UserId = userId;
        }

        public string UserId { get; }
    }
}
