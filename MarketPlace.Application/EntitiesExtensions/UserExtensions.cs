﻿using MarketPlace.Domain.Models.User;

namespace MarketPlace.Application.EntitiesExtensions
{
    public static class UserExtensions
    {
        public static string GetUserShowName(this ApplicationUser user)
        {
            if (!string.IsNullOrEmpty(user.FirstName) && !string.IsNullOrEmpty(user.LastName))
            {
                return $"{user.FirstName} {user.LastName}";
            }

            return user.PhoneNumber;
        }
    }
}
