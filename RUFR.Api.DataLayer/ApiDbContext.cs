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

        /// <summary>
        /// таблица документов
        /// </summary>
        public DbSet<DocumentModel> DocumentModels { get; set; }

        /// <summary>
        /// таблица связи проект-приоритетное направление
        /// </summary>
        public DbSet<ProjectPriorityModel> ProjectPriorityModels { get; set; }

        /// <summary>
        /// таблицы связи проект-участник
        /// </summary>
        public DbSet<ProjectMemberModel> ProjectMemberModels { get; set; }

        /// <summary>
        /// таблица связи участник-приоритетное направление
        /// </summary>
        public DbSet<MemberPriorityModel> MemberPriorityModels { get; set; }

        /// <summary>
        /// таблица связи участник-тип сотрудничества
        /// </summary>
        public DbSet<MemberTypesOfCooperationModel> MemberTypesOfCooperationModels { get; set; }

        /// <summary>
        /// таблица для хранения стастической, краткой информации для участников
        /// </summary>
        public DbSet<StatisticalInformationModel> StatisticalInformationModels { get; set; }

        /// <summary>
        /// таблица связи пользователь-документ
        /// </summary>
        public DbSet<UserDocumentModel> UserDocumentModels { get; set; }

        /// <summary>
        /// таблица связи пользователь-проект
        /// </summary>
        public DbSet<UserProjectModel> UserProjectModels { get; set; }

        /// <summary>
        /// таблица связи пользователь-участник
        /// </summary>
        public DbSet<UserMemberModel> UserMemberModels { get; set; }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
