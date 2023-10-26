using System;
using BlazorSQL.Client.Pages;
using BlazorSQL.Shared;
namespace BlazorSQL.Server.Repositories
{
    public interface IBikeRepository
    {
        BEBike[] GetAll();
        void Add(BEBike bike);
        void DeleteById(int id);
    }
}