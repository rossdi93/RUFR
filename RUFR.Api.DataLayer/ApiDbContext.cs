using System;
using Microsoft.EntityFrameworkCore;
using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;

namespace Api.DataLayer
{
    public class ApiDbContext: DbContext, IDbContext
    {
        /// <summary>
        /// Интерфейс доступа к БД
        /// </summary>
        /// <param name="options"></param>
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// таблица пользователей
        /// </summary>
        public DbSet<UserModel> Users { get; set; }

        /// <summary>
        /// таблица историй успеха
        /// </summary>
        public DbSet<HistoryOfSuccessModel> HistoryOfSuccessModels { get; set; }

        /// <summary>
        /// таблица видов сотрудничества
        /// </summary>
        public DbSet<TypesOfCooperationModel> TypesOfCooperationModels { get; set; }

        /// <summary>
        /// таблицы событий
        /// </summary>
        public DbSet<EventModel> EventModels { get; set; }

        /// <summary>
        /// таблица участников
        /// </summary>
        public DbSet<MemberModel> MemberModels { get; set; }

        /// <summary>
        /// таблица новостей
        /// </summary>
        public DbSet<NewsModel> NewsModels { get; set; }

        /// <summary>
        /// таблица приоритетных направлений
        /// </summary>
        public DbSet<PriorityDirectionModel> PriorityDirectionModels { get; set; }

        /// <summary>
        /// таблица поректов
        /// </summary>
        public DbSet<ProjectModel> ProjectModels { get; set; }
    }
}
