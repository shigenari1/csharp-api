using System;
using Domain.Domain.Users;
using UseCase.Users.Create;

namespace Domain.Application.Users
{
    public class UserCreateInteractor : IUserCreateUseCase
    {
        private readonly IUserRepository userRepository;

        public UserCreateInteractor()
        {
        }

        public UserCreateResponse Handle(UserCreateRequest request) => null;
    }
}
