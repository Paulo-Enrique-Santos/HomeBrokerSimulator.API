﻿namespace AuthUserToken.Domain.Model.Request
{
    public class UserLoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}