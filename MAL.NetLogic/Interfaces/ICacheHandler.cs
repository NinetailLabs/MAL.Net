﻿using System.Threading.Tasks;

namespace MAL.NetLogic.Interfaces
{
    public interface ICacheHandler
    {
        Task<IAnime> GetAnime(int id);
        Task<IAnime> GetAnime(int id, string username, string password);
        Task<ILoginData> GetAuth(string username, string password, bool canCache = true);
    }
}