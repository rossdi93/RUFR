using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;
using System;
using System.Linq;

namespace RUFR.Api.Web.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usersService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_usersService.GetById(id));
        }

        /// <summary>
        /// Добавление нового сущности
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] UserModel user)
        {
            UserModel newUser = _usersService.Create(user);

            return Ok(newUser);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] UserModel user)
        {
            if (_usersService.GetById(user.Id) == null)
            {
                return NotFound(user);
            }

            try
            {
                UserModel oldUser = _usersService.GetById(user.Id);
                oldUser.Date = user.Date;
                oldUser.Login = user.Login;
                oldUser.Mail = user.Mail;
                oldUser.Name = user.Name;
                oldUser.Pass = user.Pass;
                oldUser.Role = user.Role;

                _usersService.Update(oldUser);

                return Ok(oldUser);

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
            var user = _usersService.GetById(id);
            if (!user.IsDelete)
            {
                user.IsDelete = true;
                try
                {
                    _usersService.Update(user);
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
