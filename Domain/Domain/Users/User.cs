﻿using System;
namespace Domain.Domain.Users
{
    /// <summary>
    /// ユーザモデル
    /// </summary>
    public class User
    {
        public User(string id, string userName)
        {
            Id = id;
            UserName = userName;
        }

        public User(string userName) 
        {
            Id = Guid.NewGuid().ToString();
            UserName = userName;
        
        }

        public string Id { get; }
        public string UserName { get; }
    }
}
