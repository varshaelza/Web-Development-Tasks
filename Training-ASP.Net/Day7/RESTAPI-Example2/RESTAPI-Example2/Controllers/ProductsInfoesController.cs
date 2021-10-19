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
using RESTAPI_Example2.Models;

namespace RESTAPI_Example2.Controllers
{
    public class ProductsInfoesController : ApiController
    {
        private Products_DBEntities db = new Products_DBEntities();

        // GET: api/ProductsInfoes
        public IQueryable<ProductsInfo> GetProductsInfoes()
        {
            return db.ProductsInfoes;
        }

        // GET: api/ProductsInfoes/5
        [ResponseType(typeof(ProductsInfo))]
        public IHttpActionResult GetProductsInfo(int id)
        {
            ProductsInfo productsInfo = db.ProductsInfoes.Find(id);
            if (productsInfo == null)
            {
                return NotFound();
            }

            return Ok(productsInfo);
        }

        // PUT: api/ProductsInfoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProductsInfo(int id, ProductsInfo productsInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productsInfo.pID)
            {
                return BadRequest();
            }

            db.Entry(productsInfo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsInfoExists(id))
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

        // POST: api/ProductsInfoes
        [ResponseType(typeof(ProductsInfo))]
        public IHttpActionResult PostProductsInfo(ProductsInfo productsInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductsInfoes.Add(productsInfo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProductsInfoExists(productsInfo.pID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = productsInfo.pID }, productsInfo);
        }

        // DELETE: api/ProductsInfoes/5
        [ResponseType(typeof(ProductsInfo))]
        public IHttpActionResult DeleteProductsInfo(int id)
        {
            ProductsInfo productsInfo = db.ProductsInfoes.Find(id);
            if (productsInfo == null)
            {
                return NotFound();
            }

            db.ProductsInfoes.Remove(productsInfo);
            db.SaveChanges();

            return Ok(productsInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductsInfoExists(int id)
        {
            return db.ProductsInfoes.Count(e => e.pID == id) > 0;
        }
    }
}