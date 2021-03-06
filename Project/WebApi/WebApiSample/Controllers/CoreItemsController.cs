﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.DataLayer;

namespace WebApplication1.Controllers
{
    public class CoreItemsController : ApiController
    {
        DataSampleEntities coreItemData;
        public CoreItemsController() {
            coreItemData = new DataSampleEntities();
        }
        public HttpResponseMessage Get(string itemNumber)
        {
            CoreItem cItem;
            cItem = coreItemData.CoreItems.Where(x => x.ItemNumber == itemNumber).FirstOrDefault();
            if (cItem != null)
                return Request.CreateResponse(HttpStatusCode.OK, cItem);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound, "Item not found in system with Item Number:" + itemNumber);
        }

        //public IHttpActionResult Get(string itemNumber)
        //{
        //    CoreItem cItem;
        //    cItem = coreItemData.CoreItems.Where(x => x.ItemNumber == itemNumber).FirstOrDefault();
        //    if (cItem != null)
        //        return Ok(cItem);
        //    else
        //        return NotFound();
        //}

        public IEnumerable<CoreItem> Get()
        {

            return coreItemData.CoreItems.ToList(); 
        }

        

        public CoreItem Put(string itemNumber, CoreItem coreItemToUpdate)
        {
            CoreItem coreItem =  coreItemData.CoreItems.Where(x => x.ItemNumber == itemNumber).FirstOrDefault();

            coreItem.ItemDescription = coreItemToUpdate.ItemDescription;
            coreItem.Price = coreItemToUpdate.Price;

            coreItemData.SaveChanges();
           

            return coreItemToUpdate;
        }
    }
}
