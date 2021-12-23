using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RUFR.Api.Web.Controllers
{
    [Route("api/Document")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        private readonly IUserDocumentService _userDocumentService;

        public DocumentsController(IDocumentService documentService,
            IUserDocumentService userDocumentService)
        {
            _documentService = documentService;
            _userDocumentService = userDocumentService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var documents = _documentService.Select()
                .Include(p => p.UserDocumentModels)
                .ThenInclude(u => u.UserModel).AsNoTracking().ToArray();

            return Ok(documents);
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var document = _documentService.Select()
                .Include(p => p.UserDocumentModels)
                .ThenInclude(u => u.UserModel).AsNoTracking().FirstOrDefault(p => p.Id == id);

            if (document != null)
            {
                return Ok(document);
            }
            else
            {
                return NotFound(document);
            }
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

            try
            {
                DocumentModel oldDoc = _documentService.Select()
                    .Include(p => p.UserDocumentModels).AsNoTracking().FirstOrDefault(p => p.Id == doc.Id);

                if (oldDoc != null)
                {
                    oldDoc.Author = doc.Author;
                    oldDoc.Date = doc.Date;
                    oldDoc.DocByte = doc.DocByte;
                    oldDoc.Lang = doc.Lang;
                    oldDoc.Name = doc.Name;
                    oldDoc.Type = doc.Type;
                    oldDoc.Description = doc.Description;

                    if (!oldDoc.UserDocumentModels.Select(p => p.UserModelId).ToArray().
                           SequenceEqual(doc.UserDocumentModels.Select(p => p.UserModelId).ToArray()))
                    {
                        foreach (var oldUD in oldDoc.UserDocumentModels)
                        {
                            _userDocumentService.Delete(oldUD.Id);
                        }

                        oldDoc.UserDocumentModels.Clear();

                        foreach (var pd in doc.UserDocumentModels)
                        {
                            oldDoc.UserDocumentModels.Add(new UserDocumentModel
                            { UserModelId = pd.UserModelId, DocumentModelId = pd.DocumentModelId, Position = pd.Position, EnrollmentDate = DateTime.Now });
                        }
                    }

                    _documentService.Update(oldDoc);

                    return Ok(oldDoc);
                }
                else
                {
                    return NotFound(doc);
                }
                
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
            var doc = _documentService.Select()
                .Include(p => p.UserDocumentModels).FirstOrDefault(p => p.Id == id);

            if (!doc.IsDelete && doc != null)
            {
                doc.IsDelete = true;
                try
                {
                    doc.UserDocumentModels.Clear();
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

