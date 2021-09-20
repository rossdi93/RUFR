using System.Collections.Generic;
using RUFR.Api.Service.Interfaces;
using RUFR.Api.DataLayer;
using System.Linq;
using System.Linq.Expressions;
using System;
using Microsoft.EntityFrameworkCore;

namespace RUFR.Api.Service.Services
{
    /// <summary>
    /// Базовый сервис для всех сущностей
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MainService<T> : IMainService<T> where T : class
    {
        protected readonly IDbContext Context;
        
        /// <summary>
        /// Создание сервиса
        /// </summary>
        /// <param name="context"></param>
        public MainService(IDbContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Получение данных из таблицы
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public IQueryable<T> Select(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? Context.Set<T>().AsQueryable() : Context.Set<T>().Where(filter).AsQueryable();
        }

        /// <summary>
        /// Получение сушностей по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById (long id)
        {
            return Context.Set<T>().Find(id);
        }

        /// <summary>
        /// Получение всех сушностей
        /// </summary>
        /// <returns></returns>
        public List<T> Get()
        {
            return Context.Set<T>().ToList();
        }

        /// <summary>
        /// Добавление сушностей в таблицу БД
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Create(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
            return entity;
        }

        /// <summary>
        /// Обнолвение сущностей
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
            Context.SaveChanges();
        }

        /// <summary>
        /// Удаление сущностей из БД
        /// </summary>
        /// <param name="id"></param>
        public void Delete(long id)
        {
            var entity = Context.Set<T>().Find(id);

            if (entity == null)
            {
                return;
            }

            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public DbSet<T> Set()
        {
            return Context.Set<T>();
        }
    }
}
