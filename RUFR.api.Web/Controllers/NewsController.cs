﻿using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Controllers
{
    [Route("api/News")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_newsService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_newsService.GetById(id));
        }

        /// <summary>
        /// Добавление нового сущности
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] NewsModel news)
        {
            NewsModel newNews = _newsService.Create(news);

            return Ok(newNews);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] NewsModel news)
        {
            if (_newsService.GetById(news.Id) == null)
            {
                return NotFound(news);
            }

            try
            {
                NewsModel oldNews = _newsService.GetById(news.Id);
                oldNews.Author = news.Author;
                oldNews.Content = news.Content;
                oldNews.Date = news.Date;
                oldNews.Logo = news.Logo;
                oldNews.Name = news.Name;
                oldNews.Theme = news.Theme;
                oldNews.Lang = news.Lang;
                oldNews.Description = news.Description;

                _newsService.Update(oldNews);

                return Ok(oldNews);

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Добавление картинки по id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="logo"></param>
        /// <returns></returns>
        [HttpPost("AddLogo/{id}")]
        public IActionResult AddLogo(long id, [FromBody] byte[] logo)
        {

            if (_newsService.GetById(id) == null)
            {
                return NotFound();
            }
            else
            {
                var news = _newsService.GetById(id);
                news.Logo = logo;
                _newsService.Update(news);

                return Ok();
            }
        
        }

        /// <summary>
        /// Удаление сущности по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var news = _newsService.GetById(id);
            if (!news.IsDelete)
            {
                news.IsDelete = true;
                try
                {
                    _newsService.Update(news);
                    return Ok();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return Ok(false);
            }
        }
    }
}
