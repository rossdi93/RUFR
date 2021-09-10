using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Service.Services
{
    public class NewsService : MainService<NewsModel>, INewsService
    {
        public NewsService(IDbContext context) : base(context)
        {
        }
    }
}
