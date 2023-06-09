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
    public class TaskLogsApiController : ControllerBase
    { 
        /// <summary>
        /// Fetch a list of Task Ids for which there are task logs available
        /// </summary>
        /// <response code="200">Success</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/service/core/v4/TaskLogs")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TaskLogsGetAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<string>), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult TaskLogsGetAsync()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<string>));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
                        : default(List<string>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Fetch a list of logs available for the Task identified by the given Id
        /// </summary>
        /// <param name="taskId">Task Guid</param>
        /// <response code="200">Success</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/service/core/v4/TaskLogs/{taskId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TaskLogsGetLogsForTaskIdAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<string>), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult TaskLogsGetLogsForTaskIdAsync([FromRoute][Required]string taskId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<string>));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
                        : default(List<string>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Return all events from the named log for the given Task
        /// </summary>
        /// <param name="taskId">Task Guid</param>
        /// <param name="logName">Log name</param>
        /// <response code="200">Success</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/service/core/v4/TaskLogs/{taskId}/{logName}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TaskLogsGetTaskLogAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Entry>), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult TaskLogsGetTaskLogAsync([FromRoute][Required]string taskId, [FromRoute][Required]string logName)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Entry>));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Recorded\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Event\" : \"Event\",\n  \"Level\" : \"Verbose\"\n}, {\n  \"Recorded\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Event\" : \"Event\",\n  \"Level\" : \"Verbose\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Entry>>(exampleJson)
                        : default(List<Entry>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Remove all extended debug logging for platform tasks
        /// </summary>
        /// <response code="204">Success</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("/service/core/v4/TaskLogs")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TaskLogsRemoveAllLogsAsync")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult TaskLogsRemoveAllLogsAsync()
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            throw new NotImplementedException();
        }
    }
}
