using System;
namespace Domain.Domain.Users
{
    /// <summary>
    /// ユーザレポジトリ
    /// </summary>
    public interface IUserRepository
    {
        User FindByUserName(string userId);
        void Save(User user);
    }
}
