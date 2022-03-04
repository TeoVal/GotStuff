﻿using GotStuff.Models;
using GotStuff.ViewModels;

namespace GotStuff.Services
{
    public interface ISharePantryService
    {
        Task<PantryVm> GetPantryVm(int? pantryId);
        Task RemoveTheUserFromPantry(string userId, int pantryId);
        Task AddNewUserToPantry(AppUserVm user);
        Task<bool> CheckIfUserSharesPantry(AppUserVm user);
        Task<bool> CheckIfUserExistsInDatabase(AppUserVm user);
    }
}