using System;
using System.Collections.Generic;

namespace FootballManager.DAL.Abstract
{
    public interface ISyncRepository<in TKey, TValue> : IDisposable
        where TValue : class
    {

        List<TValue> GetAll(); // получение всех объектов
        TValue GetById(TKey id); // получение одного объекта по id
        void Create(TValue item); // создание объекта
        void Update(TValue item); // обновление объекта
        void Delete(TKey id); // удаление объекта по id
        void Save();  // сохранение изменений
    }
}