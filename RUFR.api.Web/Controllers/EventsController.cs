using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Controllers
{
    [Route("api/Events")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventsService _eventsService;

        public EventsController(IEventsService eventsService)
        {
            _eventsService = eventsService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_eventsService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_eventsService.GetById(id));
        }

        /// <summary>
        /// Добавление нового сущности
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] EventModel ev)
        {
            EventModel newEvents = _eventsService.Create(ev);

            return Ok(newEvents);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] EventModel ev)
        {
            if (_eventsService.GetById(ev.Id) == null)
            {
                return NotFound(ev);
            }

            try
            {
                EventModel oldEvent = _eventsService.GetById(ev.Id);
                oldEvent.Content = ev.Content;
                oldEvent.Date = ev.Date;
                oldEvent.Logo = ev.Logo;
                oldEvent.Name = ev.Name;
                oldEvent.Theme = ev.Theme;
                oldEvent.TypeEven = ev.TypeEven;
                oldEvent.Lang = ev.Lang;

                _eventsService.Update(oldEvent);

                return Ok(oldEvent);

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
            var ev = _eventsService.GetById(id);
            if (!ev.IsDelete)
            {
                ev.IsDelete = true;
                try
                {
                    _eventsService.Update(ev);
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
