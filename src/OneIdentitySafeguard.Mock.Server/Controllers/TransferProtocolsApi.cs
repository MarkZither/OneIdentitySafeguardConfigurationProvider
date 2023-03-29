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
    public class TransferProtocolsApiController : ControllerBase
    { 
        /// <summary>
        /// Gets a queryable list of transfer protocols used to archive backups
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <response code="200">Success</response>
        /// <response code="403">Must have ApplianceAdmin, OperationsAdmin, SystemAuditor or Auditor permission</response>
        [HttpGet]
        [Route("/service/core/v4/TransferProtocols")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TransferProtocolsGetAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TransferProtocol>), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have ApplianceAdmin, OperationsAdmin, SystemAuditor or Auditor permission")]
        public virtual IActionResult TransferProtocolsGetAsync([FromQuery]string filter, [FromQuery]int? page, [FromQuery]int? limit, [FromQuery]bool? count, [FromQuery]string fields, [FromQuery]string orderby, [FromQuery]string q)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<TransferProtocol>));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"SupportsCustomPort\" : true,\n  \"Description\" : \"Description\",\n  \"SupportsSshKey\" : true,\n  \"SupportsPassword\" : true,\n  \"Name\" : \"Name\"\n}, {\n  \"SupportsCustomPort\" : true,\n  \"Description\" : \"Description\",\n  \"SupportsSshKey\" : true,\n  \"SupportsPassword\" : true,\n  \"Name\" : \"Name\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<TransferProtocol>>(exampleJson)
                        : default(List<TransferProtocol>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets a transfer protocol used to archive backups
        /// </summary>
        /// <param name="id">Unique ID of transfer protocol</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have ApplianceAdmin, OperationsAdmin, SystemAuditor or Auditor permission</response>
        /// <response code="404">Platform does not exist</response>
        [HttpGet]
        [Route("/service/core/v4/TransferProtocols/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TransferProtocolsGetByIdAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(TransferProtocol), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have ApplianceAdmin, OperationsAdmin, SystemAuditor or Auditor permission")]
        public virtual IActionResult TransferProtocolsGetByIdAsync([FromRoute][Required]TransferProtocolType id, [FromQuery]string fields)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TransferProtocol));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"SupportsCustomPort\" : true,\n  \"Description\" : \"Description\",\n  \"SupportsSshKey\" : true,\n  \"SupportsPassword\" : true,\n  \"Name\" : \"Name\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<TransferProtocol>(exampleJson)
                        : default(TransferProtocol);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}