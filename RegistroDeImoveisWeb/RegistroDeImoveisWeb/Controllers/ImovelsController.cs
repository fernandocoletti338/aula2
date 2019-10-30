﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using RegistroDeImoveisWeb.Models;

namespace RegistroDeImoveisWeb.Controllers
{
    public class ImovelsController : ApiController
    {
        private MigrationContext db = new MigrationContext();

        // GET: api/Imovels
        public IQueryable<Imovel> GetImoveis()
        {
            return db.Imoveis;
        }

        // GET: api/Imovels/5
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult GetImovel(string id)
        {
            Imovel imovel = db.Imoveis.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }

            return Ok(imovel);
        }

        // PUT: api/Imovels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutImovel(string id, Imovel imovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != imovel.Cep)
            {
                return BadRequest();
            }

            db.Entry(imovel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImovelExists(id))
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

        // POST: api/Imovels
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult PostImovel(Imovel imovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Imoveis.Add(imovel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ImovelExists(imovel.Cep))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = imovel.Cep }, imovel);
        }

        // DELETE: api/Imovels/5
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult DeleteImovel(string id)
        {
            Imovel imovel = db.Imoveis.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }

            db.Imoveis.Remove(imovel);
            db.SaveChanges();

            return Ok(imovel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImovelExists(string id)
        {
            return db.Imoveis.Count(e => e.Cep == id) > 0;
        }
    }
}