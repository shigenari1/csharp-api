namespace UseCase.Users.Create
{
    /// <summary>
    /// ユーザー登録
    /// </summary>
    public interface IUserCreateUseCase
    {
        UserCreateResponse Handle(UserCreateRequest request);
    }
}
