using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.DAL.Abstract
{
    interface IAsyncRepository<in TKey, TValue> : IDisposable
        where TValue : class
    {

        Task<List<TValue>> GetAllAsync(); // получение всех объектов
        Task<TValue> GetByIdAsync(TKey id); // получение одного объекта по id
        Task CreateAsync(TValue item); // создание объекта
        Task UpdateAsync(TValue item); // обновление объекта
        Task DeleteAsync(TKey id); // удаление объекта по id
        Task Save();  // сохранение изменений
    }
}