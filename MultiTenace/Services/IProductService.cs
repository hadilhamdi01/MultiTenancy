﻿namespace MultiTenace.Services
{
    public interface IProductService
    {
        Task<Product> CreatedAsync(Product product);
        Task<Product?> GetByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetAllAsync();
    }
}
