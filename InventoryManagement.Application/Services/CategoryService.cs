﻿using InventoryManagement.Domain.Models;
using InventoryManagement.Infastructure.Repositories;

namespace InventoryManagement.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository _repository;

        public CategoryService(CategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            return await _repository.CreateAsync(category);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> UpDateAsync(int id, Category category)
        {
            return await _repository.UpDateAsync(id, category);
        }
    }
}
