﻿using GotStuff.ViewModels;

namespace GotStuff.Services
{
    public interface IKnownProductService
    {
        List<KnownProductVm> GetAllKnownProducts();
        void AddNewProduct(KnownProductVm knownProductsVm);
        Task RemoveProduct(int id);
        Task<KnownProductVm> GetProductVmById(int? id);
        Task EditProduct(KnownProductVm updatedProduct);
    }
}