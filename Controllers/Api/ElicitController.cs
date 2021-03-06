using ElicitInc.Models.Response;
using ElicitInc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ElicitInc.Controllers.Api
{
    [RoutePrefix("api/elicit")]
    public class ElicitController : ApiController
    {

        IElicitService _elicitService;

        public ElicitController(IElicitService elicitService)
        {
            _elicitService = elicitService;
        }

        [Route(), HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                return Ok(new ItemsResponse<Elicit>
                {
                    Items = _elicitService.ReadAll(),
                    IsSuccessful = true
                });
            }
            catch (Exception ex)
            {
                {
                    return BadRequest(ex.Message);
                };
            }
        }
        //***************************************** POST *****************************************
        //[Route(), HttpPost]
        //public IHttpActionResult Post(ElicitAddRequest model)
        //{
        //    try
        //    {
        //        ItemResponse<int> response = new ItemResponse<int>
        //        {
        //            Item = _elicitService.Post(model),
        //            IsSuccessful = true
        //        };
        //        return Ok(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //******************************************** PUT ****************************************

        //[Route("{id:int}"), HttpPut]
        //public IHttpActionResult Put(ElicitUpdateRequest model)
        //{
        //    try
        //    {
        //        _elicitService.Put(model);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        ////******************************************** GET BY ID ****************************************

        //[Route("{id:int}"), HttpGet]
        //public IHttpActionResult GetById(int id)
        //{
        //    try
        //    {
        //        ItemsResponse<Project> response = new ItemsResponse<Project>
        //        {
        //            Items = _elicitService.ReadById(id)
        //        };
        //        return Ok(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //******************************************** DELETE ****************************************
        //[Route("{id:int}"), HttpDelete]
        //public IHttpActionResult Delete(int id)
        //{
        //    try
        //    {
        //        ItemResponse<int> response = new ItemResponse<int>
        //        {
        //            Item = _elicitService.Delete(id)
        //        };
        //        //
        //        return Ok(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    //}
    //{
    }
}