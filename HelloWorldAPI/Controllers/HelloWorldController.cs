using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.Model;
using HelloWorld.Service.Contracts;
using HelloWorld.Service.Implementations;

namespace HelloWorldAPI.Controllers
{
    [RoutePrefix("api/HelloWorld")]
    public class HelloWorldController : ApiController
    {
        //MessageService _messageService = new MessageService();
        IMessageService _messageService;
        public HelloWorldController() { }

        public HelloWorldController(IMessageService messageService)
        {
            this._messageService = messageService;
        }

        [HttpGet]
        // GET: api/HelloWorld/{id}
        public HttpResponseMessage GetMessage(int id)
        {
            HttpResponseMessage response;
            var hello = _messageService.GetMessage(id).Message;

            if (hello.Length > 0)
                response = Request.CreateResponse(HttpStatusCode.OK, hello);
            else
                response = Request.CreateResponse(HttpStatusCode.BadRequest, hello);
            return response;
        }

        /// <summary>
        /// {"id":"2","message":"Welcome!"} returns the id;
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Create")]
        // POST: api/HelloWorld/Create
        public HttpResponseMessage Post(HelloMessage message)
        {
            //To be Implemented - Writing to the DB
            //throw new NotImplementedException();
            HttpResponseMessage response = Request.CreateResponse(_messageService.NewMessage(message));
            return response;
        }

        [HttpPut]
        [Route("Update/{id}")]
        // PUT: api/HelloWorld/5
        public void Put(int id, [FromBody]string value)
        {
            //To be Implemented
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        // DELETE: api/HelloWorld/5
        public void Delete(int id)
        {
            //To be Implemented
        }
    }
}
