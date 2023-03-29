/*
 * Safeguard Core API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using OneIdentitySafeguard.Mock.Server.Attributes;
using OneIdentitySafeguard.Mock.Server.Security;
using Microsoft.AspNetCore.Authorization;
using OneIdentitySafeguard.Mock.Server.Models;

namespace OneIdentitySafeguard.Mock.Server.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DailyMessageApiController : ControllerBase
    { 
        /// <summary>
        /// Gets the Message of the Day
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Must be an authenticated user</response>
        [HttpGet]
        [Route("/service/core/v4/DailyMessage")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DailyMessageGetAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(DailyMessage), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ApiError), description: "Must be an authenticated user")]
        public virtual IActionResult DailyMessageGetAsync([FromQuery]string fields)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DailyMessage));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"UseRss\" : true,\n  \"Address\" : \"Address\",\n  \"Message\" : \"Message\",\n  \"UpdatedDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Subject\" : \"Subject\",\n  \"UpdatedByUserId\" : 0,\n  \"UpdatedByUserDisplayName\" : \"UpdatedByUserDisplayName\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<DailyMessage>(exampleJson)
                        : default(DailyMessage);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates the Message of the Day
        /// </summary>
        /// <param name="body">Updated Message of the day</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have GlobalAdmin, UserAdmin, HelpdeskAdmin, ApplianceAdmin, OperationsAdmin, PolicyAdmin or AssetAdmin permission</response>
        [HttpPut]
        [Route("/service/core/v4/DailyMessage")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DailyMessageUpdateEntityAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(DailyMessage), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have GlobalAdmin, UserAdmin, HelpdeskAdmin, ApplianceAdmin, OperationsAdmin, PolicyAdmin or AssetAdmin permission")]
        public virtual IActionResult DailyMessageUpdateEntityAsync([FromBody]DailyMessage body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DailyMessage));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"UseRss\" : true,\n  \"Address\" : \"Address\",\n  \"Message\" : \"Message\",\n  \"UpdatedDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Subject\" : \"Subject\",\n  \"UpdatedByUserId\" : 0,\n  \"UpdatedByUserDisplayName\" : \"UpdatedByUserDisplayName\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<DailyMessage>(exampleJson)
                        : default(DailyMessage);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}