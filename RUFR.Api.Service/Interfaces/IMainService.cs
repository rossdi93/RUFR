using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RUFR.Api.Service.Interfaces
{
    public interface IMainService<T> where T : class
    {
        /// <summary>
        /// Выборка данных по условию
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IQueryable<T> Select(Expression<Func<T, bool>> filter = null);

        /// <summary>
        /// Получение объекта по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(long id);

        /// <summary>
        /// Получение всех объектов
        /// </summary>
        /// <returns></returns>
        List<T> Get();

        /// <summary>
        /// Создание нового объекта
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Create(T entity);

        /// <summary>
        /// Обновление объекта
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Удаление объекта по id
        /// </summary>
        /// <param name="id"></param>
        void Delete(long id);

        /// <summary>
        /// Возможность использовать таблицу контекста
        /// </summary>
        /// <returns></returns>
        DbSet<T> Set();
    }
}
