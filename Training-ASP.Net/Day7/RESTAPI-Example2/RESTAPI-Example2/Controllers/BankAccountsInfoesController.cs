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
    public class BankAccountsInfoesController : ApiController
    {
        private Banking_DBEntities db = new Banking_DBEntities();

        // GET: api/BankAccountsInfoes
        public IQueryable<BankAccountsInfo> GetBankAccountsInfoes()
        {
            return db.BankAccountsInfoes;
        }

        // GET: api/BankAccountsInfoes/5
        [ResponseType(typeof(BankAccountsInfo))]
        public IHttpActionResult GetBankAccountsInfo(int id)
        {
            BankAccountsInfo bankAccountsInfo = db.BankAccountsInfoes.Find(id);
            if (bankAccountsInfo == null)
            {
                return NotFound();
            }

            return Ok(bankAccountsInfo);
        }

        // PUT: api/BankAccountsInfoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBankAccountsInfo(int id, BankAccountsInfo bankAccountsInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bankAccountsInfo.AccNo)
            {
                return BadRequest();
            }

            db.Entry(bankAccountsInfo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankAccountsInfoExists(id))
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

        // POST: api/BankAccountsInfoes
        [ResponseType(typeof(BankAccountsInfo))]
        public IHttpActionResult PostBankAccountsInfo(BankAccountsInfo bankAccountsInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BankAccountsInfoes.Add(bankAccountsInfo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (BankAccountsInfoExists(bankAccountsInfo.AccNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = bankAccountsInfo.AccNo }, bankAccountsInfo);
        }

        // DELETE: api/BankAccountsInfoes/5
        [ResponseType(typeof(BankAccountsInfo))]
        public IHttpActionResult DeleteBankAccountsInfo(int id)
        {
            BankAccountsInfo bankAccountsInfo = db.BankAccountsInfoes.Find(id);
            if (bankAccountsInfo == null)
            {
                return NotFound();
            }

            db.BankAccountsInfoes.Remove(bankAccountsInfo);
            db.SaveChanges();

            return Ok(bankAccountsInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BankAccountsInfoExists(int id)
        {
            return db.BankAccountsInfoes.Count(e => e.AccNo == id) > 0;
        }
    }
}