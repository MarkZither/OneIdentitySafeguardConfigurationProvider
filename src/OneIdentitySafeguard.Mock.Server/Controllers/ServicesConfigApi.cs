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
    public class ServicesConfigApiController : ControllerBase
    { 
        /// <summary>
        /// Gets the status of the services configuration
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Must be an authenticated user</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/service/core/v4/ServicesConfig")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ServicesConfigGetAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(ServicesConfig), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult ServicesConfigGetAsync([FromQuery]string fields)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ServicesConfig));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"PasswordRequestsEnabled\" : true,\n  \"SshKeyDiscoveryEnabled\" : true,\n  \"SshKeyCheckEnabled\" : true,\n  \"SessionRequestsEnabled\" : true,\n  \"DirectorySyncEnabled\" : true,\n  \"PasswordChangeEnabled\" : true,\n  \"DiscoverServicesEnabled\" : true,\n  \"SshKeyChangeEnabled\" : true,\n  \"SshKeyRequestsEnabled\" : true,\n  \"PasswordCheckEnabled\" : true,\n  \"AssetDiscoveryEnabled\" : true,\n  \"DiscoverAccountsEnabled\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ServicesConfig>(exampleJson)
                        : default(ServicesConfig);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets the status of the specified services configuration
        /// </summary>
        /// <param name="serviceName">Name of service to check if enabled</param>
        /// <response code="200">Success</response>
        /// <response code="401">Must be an authenticated user</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/service/core/v4/ServicesConfig/{serviceName}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ServicesConfigGetServiceAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(bool?), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult ServicesConfigGetServiceAsync([FromRoute][Required]ServiceEnabled serviceName)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(bool?));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "true";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<bool?>(exampleJson)
                        : default(bool?);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates the services configuration
        /// </summary>
        /// <param name="body">Updated ServicesConfig</param>
        /// <response code="200">Success</response>
        /// <response code="400">ServicesConfig did not pass validation</response>
        /// <response code="403">Must have ApplianceAdmin permission</response>
        [HttpPut]
        [Route("/service/core/v4/ServicesConfig")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ServicesConfigUpdateEntityAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(ServicesConfig), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "ServicesConfig did not pass validation")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have ApplianceAdmin permission")]
        public virtual IActionResult ServicesConfigUpdateEntityAsync([FromBody]ServicesConfig body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ServicesConfig));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"PasswordRequestsEnabled\" : true,\n  \"SshKeyDiscoveryEnabled\" : true,\n  \"SshKeyCheckEnabled\" : true,\n  \"SessionRequestsEnabled\" : true,\n  \"DirectorySyncEnabled\" : true,\n  \"PasswordChangeEnabled\" : true,\n  \"DiscoverServicesEnabled\" : true,\n  \"SshKeyChangeEnabled\" : true,\n  \"SshKeyRequestsEnabled\" : true,\n  \"PasswordCheckEnabled\" : true,\n  \"AssetDiscoveryEnabled\" : true,\n  \"DiscoverAccountsEnabled\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ServicesConfig>(exampleJson)
                        : default(ServicesConfig);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates the specified services configuration
        /// </summary>
        /// <param name="serviceName">Name of service to set enabled</param>
        /// <param name="body">Whether service is enabled</param>
        /// <response code="200">Success</response>
        /// <response code="400">ServicesConfig did not pass validation</response>
        /// <response code="403">Must have ApplianceAdmin permission</response>
        [HttpPut]
        [Route("/service/core/v4/ServicesConfig/{serviceName}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ServicesConfigUpdateServiceAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(bool?), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "ServicesConfig did not pass validation")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have ApplianceAdmin permission")]
        public virtual IActionResult ServicesConfigUpdateServiceAsync([FromRoute][Required]ServiceEnabled serviceName, [FromBody]bool? body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(bool?));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "true";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<bool?>(exampleJson)
                        : default(bool?);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
