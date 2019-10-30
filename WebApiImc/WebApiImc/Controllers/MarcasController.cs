using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiImc.Models;

namespace WebApiImc.Controllers
{
    public class MarcasController : ApiController
    {
        private InnerJoinContextDB db = new InnerJoinContextDB();

        // GET: api/Marcas
        public IQueryable<Marcas> GetMarcas()
        {
            return db.Marcas;
        }

        // GET: api/Marcas/5
        [ResponseType(typeof(Marcas))]
        public IHttpActionResult GetMarcas(int id)
        {
            Marcas marcas = db.Marcas.Find(id);
            if (marcas == null)
            {
                return NotFound();
            }

            return Ok(marcas);
        }

        [Route("api/Marcas/WHO")]
        public IHttpActionResult GetUsuarioCadastrouAMarca(int IdMarca)
        {
            //
            var Marcas = db.Marcas.Where(P => P.Id == IdMarca).ToList();
            var Usuarios = db.Usuarios.ToList();

            var InnerJoin = from mar in Marcas
                            join usu in Usuarios
                            on mar.UsuInc equals usu.Id
                            select new
                            {
                                UsuarioID = usu.Id,
                                MarcaNome = mar.Nome,
                                UsuarioNome = usu.Usuario
                            };


            return Ok(InnerJoin);
        }


        // PUT: api/Marcas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMarcas(int id, Marcas marcas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marcas.Id)
            {
                return BadRequest();
            }

            db.Entry(marcas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Marcas
        [ResponseType(typeof(Marcas))]
        public IHttpActionResult PostMarcas(Marcas marcas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Marcas.Add(marcas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = marcas.Id }, marcas);
        }

        // DELETE: api/Marcas/5
        [ResponseType(typeof(Marcas))]
        public IHttpActionResult DeleteMarcas(int id)
        {
            Marcas marcas = db.Marcas.Find(id);
            if (marcas == null)
            {
                return NotFound();
            }

            db.Marcas.Remove(marcas);
            db.SaveChanges();

            return Ok(marcas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MarcasExists(int id)
        {
            return db.Marcas.Count(e => e.Id == id) > 0;
        }
    }
}