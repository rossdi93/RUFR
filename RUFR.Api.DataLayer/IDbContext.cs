using Microsoft.EntityFrameworkCore;
using RUFR.Api.Model.Models;

namespace RUFR.Api.DataLayer
{
    public interface IDbContext
    {
        DbSet<UserModel> Users { get; set; }

        DbSet<HistoryOfSuccessModel> HistoryOfSuccessModels { get; set; }

        DbSet<TypesOfCooperationModel> TypesOfCooperationModels { get; set; }

        DbSet<EventModel> EventModels { get; set; }

        DbSet<MemberModel> MemberModels { get; set; }

        DbSet<NewsModel> NewsModels { get; set; }

        DbSet<PriorityDirectionModel> PriorityDirectionModels { get; set; }

        DbSet<ProjectModel> ProjectModels { get; set; }

        /// <summary>
        /// Получение таблицы для указанного типа сущности
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        void SaveChanges();
    }
}