using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Controllers
{
    [Route("api/History")]
    [ApiController]
    public class HistoryOfSuccessController : ControllerBase
    {
        private readonly IHistoryOfSuccessService _historyOfSuccessService;

        public HistoryOfSuccessController(IHistoryOfSuccessService historyOfSuccessService)
        {
            _historyOfSuccessService = historyOfSuccessService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_historyOfSuccessService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_historyOfSuccessService.GetById(id));
        }

        /// <summary>
        /// Добавление новой сущности
        /// </summary>
        /// <param name="history"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] HistoryOfSuccessModel history)
        {
            HistoryOfSuccessModel newHistory = _historyOfSuccessService.Create(history);

            return Ok(newHistory);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="history"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] HistoryOfSuccessModel history)
        {
            if (_historyOfSuccessService.GetById(history.Id) == null)
            {
                return NotFound(history);
            }

            try
            {
                HistoryOfSuccessModel oldHistory = _historyOfSuccessService.GetById(history.Id);
                oldHistory.Author = history.Author;
                oldHistory.Content = history.Content;
                oldHistory.Countrys = history.Countrys;
                oldHistory.Date = history.Date;
                oldHistory.Logo = history.Logo;
                oldHistory.Name = history.Name;
                oldHistory.TypesOfHistory = history.TypesOfHistory;
                oldHistory.Lang = history.Lang;
                oldHistory.Description = history.Description;

                _historyOfSuccessService.Update(oldHistory);

                return Ok(oldHistory);

            }
            catch (Exception)
            {

                throw;
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
            var history = _historyOfSuccessService.GetById(id);
            if (!history.IsDelete)
            {
                history.IsDelete = true;
                try
                {
                    _historyOfSuccessService.Update(history);
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
