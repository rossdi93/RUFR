using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Web.Controllers
{
    [Route("api/Document")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_documentService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_documentService.GetById(id));
        }

        /// <summary>
        /// Добавление нового сущности
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] DocumentModel doc)
        {
            DocumentModel newDoc = _documentService.Create(doc);

            return Ok(newDoc);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] DocumentModel doc)
        {
            if (_documentService.GetById(doc.Id) == null)
            {
                return NotFound(doc);
            }

            try
            {
                DocumentModel oldDoc = _documentService.GetById(doc.Id);
                oldDoc.Author = doc.Author;
                oldDoc.Date = doc.Date;
                oldDoc.DocByte = doc.DocByte;
                oldDoc.Lang = doc.Lang;
                oldDoc.Name = doc.Name;
                oldDoc.Type = doc.Type;
                oldDoc.Description = doc.Description;

                _documentService.Update(oldDoc);

                return Ok(oldDoc);

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
            var doc = _documentService.GetById(id);
            if (!doc.IsDelete)
            {
                doc.IsDelete = true;
                try
                {
                    _documentService.Update(doc);
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

