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

        DbSet<DocumentModel> DocumentModels { get; set; }

        DbSet<ProjectPriorityModel> ProjectPriorityModels { get; set; }

        DbSet<ProjectMemberModel> ProjectMemberModels { get; set; }

        DbSet<MemberPriorityModel> MemberPriorityModels { get; set; }

        DbSet<MemberTypesOfCooperationModel> MemberTypesOfCooperationModels { get; set; }

        DbSet<StatisticalInformationModel> StatisticalInformationModels { get; set; }

        DbSet<UserDocumentModel> UserDocumentModels { get; set; }

        DbSet<UserProjectModel> UserProjectModels { get; set; }

        DbSet<UserMemberModel> UserMemberModels { get; set; }

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