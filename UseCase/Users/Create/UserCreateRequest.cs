using System;
namespace UseCase.Users.Create
{
    /// <summary>
    /// ユーザ作成リクエスト
    /// </summary>
    public class UserCreateRequest
    {
        public UserCreateRequest(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; }
    }
}
