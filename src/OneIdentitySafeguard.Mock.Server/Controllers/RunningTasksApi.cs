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
    public class RunningTasksApiController : ControllerBase
    { 
        /// <summary>
        /// Cancels the queued or running task, whenever possible
        /// </summary>
        /// <param name="taskName">Name of tasks to filter by. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="id">Unique identifier of the Task</param>
        /// <response code="204">Success - No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have AssetAdmin or PartitionAdmin permission</response>
        [HttpDelete]
        [Route("/service/core/v4/RunningTasks/{taskName}/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("RunningTasksCancelPlatformTaskAsync")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have AssetAdmin or PartitionAdmin permission")]
        public virtual IActionResult RunningTasksCancelPlatformTaskAsync([FromRoute][Required]TaskNames taskName, [FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a list of running tasks
        /// </summary>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have ApplianceAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission</response>
        [HttpGet]
        [Route("/service/core/v4/RunningTasks")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("RunningTasksGetAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<RunningTask>), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have ApplianceAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission")]
        public virtual IActionResult RunningTasksGetAsync([FromQuery]DateTime? startDate, [FromQuery]DateTime? endDate, [FromQuery]string filter, [FromQuery]int? page, [FromQuery]int? limit, [FromQuery]bool? count, [FromQuery]string fields, [FromQuery]string orderby, [FromQuery]string q)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<RunningTask>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"AssetPartitionId\" : 0,\n  \"ProfileId\" : 5,\n  \"TaskId\" : \"TaskId\",\n  \"AccountId\" : 1,\n  \"SyncGroupName\" : \"SyncGroupName\",\n  \"ProfileName\" : \"ProfileName\",\n  \"AssetName\" : \"AssetName\",\n  \"Name\" : \"Unknown\",\n  \"AssetDiscoveryJobName\" : \"AssetDiscoveryJobName\",\n  \"AssetPartitionName\" : \"AssetPartitionName\",\n  \"SyncGroupId\" : 5,\n  \"UserProperties\" : {\n    \"UserWasHelpdeskAdmin\" : true,\n    \"UserName\" : \"UserName\",\n    \"UserWasPartitionOwner\" : true,\n    \"DomainName\" : \"DomainName\",\n    \"UserWasSystemAuditor\" : true,\n    \"UserWasAuditor\" : true,\n    \"UserWasApplianceAdmin\" : true,\n    \"UserWasGlobalAdmin\" : true,\n    \"UserWasDirectoryAdmin\" : true,\n    \"UserWasOperationsAdmin\" : true,\n    \"UserWasApplicationAuditor\" : true,\n    \"ClientIpAddress\" : \"ClientIpAddress\",\n    \"UserWasAssetAdmin\" : true,\n    \"UserWasUserAdmin\" : true,\n    \"UserDisplayName\" : \"UserDisplayName\",\n    \"UserWasPolicyAdmin\" : true\n  },\n  \"AssetDiscoveryType\" : \"Directory\",\n  \"ApplianceId\" : \"ApplianceId\",\n  \"AssetId\" : 6,\n  \"RequestStatus\" : {\n    \"EndTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"Message\" : \"Message\",\n    \"State\" : \"Unknown\",\n    \"PercentComplete\" : 2,\n    \"Cancellable\" : true,\n    \"StartTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"QueuedDuration\" : \"QueuedDuration\",\n    \"RunningDuration\" : \"RunningDuration\",\n    \"AcceptanceDuration\" : \"AcceptanceDuration\",\n    \"AcceptedTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"TotalDuration\" : \"TotalDuration\"\n  },\n  \"AccountName\" : \"AccountName\"\n}, {\n  \"AssetPartitionId\" : 0,\n  \"ProfileId\" : 5,\n  \"TaskId\" : \"TaskId\",\n  \"AccountId\" : 1,\n  \"SyncGroupName\" : \"SyncGroupName\",\n  \"ProfileName\" : \"ProfileName\",\n  \"AssetName\" : \"AssetName\",\n  \"Name\" : \"Unknown\",\n  \"AssetDiscoveryJobName\" : \"AssetDiscoveryJobName\",\n  \"AssetPartitionName\" : \"AssetPartitionName\",\n  \"SyncGroupId\" : 5,\n  \"UserProperties\" : {\n    \"UserWasHelpdeskAdmin\" : true,\n    \"UserName\" : \"UserName\",\n    \"UserWasPartitionOwner\" : true,\n    \"DomainName\" : \"DomainName\",\n    \"UserWasSystemAuditor\" : true,\n    \"UserWasAuditor\" : true,\n    \"UserWasApplianceAdmin\" : true,\n    \"UserWasGlobalAdmin\" : true,\n    \"UserWasDirectoryAdmin\" : true,\n    \"UserWasOperationsAdmin\" : true,\n    \"UserWasApplicationAuditor\" : true,\n    \"ClientIpAddress\" : \"ClientIpAddress\",\n    \"UserWasAssetAdmin\" : true,\n    \"UserWasUserAdmin\" : true,\n    \"UserDisplayName\" : \"UserDisplayName\",\n    \"UserWasPolicyAdmin\" : true\n  },\n  \"AssetDiscoveryType\" : \"Directory\",\n  \"ApplianceId\" : \"ApplianceId\",\n  \"AssetId\" : 6,\n  \"RequestStatus\" : {\n    \"EndTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"Message\" : \"Message\",\n    \"State\" : \"Unknown\",\n    \"PercentComplete\" : 2,\n    \"Cancellable\" : true,\n    \"StartTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"QueuedDuration\" : \"QueuedDuration\",\n    \"RunningDuration\" : \"RunningDuration\",\n    \"AcceptanceDuration\" : \"AcceptanceDuration\",\n    \"AcceptedTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"TotalDuration\" : \"TotalDuration\"\n  },\n  \"AccountName\" : \"AccountName\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<RunningTask>>(exampleJson)
                        : default(List<RunningTask>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets a single running task
        /// </summary>
        /// <param name="taskName">Name of tasks to filter by. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="id">Unique identifier of the Task</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have AssetAdmin, PartitionAdmin, ApplicationAuditor or Auditor permission</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/service/core/v4/RunningTasks/{taskName}/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("RunningTasksGetByIdAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(RunningTask), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have AssetAdmin, PartitionAdmin, ApplicationAuditor or Auditor permission")]
        public virtual IActionResult RunningTasksGetByIdAsync([FromRoute][Required]TaskNames taskName, [FromRoute][Required]string id, [FromQuery]string fields)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(RunningTask));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"AssetPartitionId\" : 0,\n  \"ProfileId\" : 5,\n  \"TaskId\" : \"TaskId\",\n  \"AccountId\" : 1,\n  \"SyncGroupName\" : \"SyncGroupName\",\n  \"ProfileName\" : \"ProfileName\",\n  \"AssetName\" : \"AssetName\",\n  \"Name\" : \"Unknown\",\n  \"AssetDiscoveryJobName\" : \"AssetDiscoveryJobName\",\n  \"AssetPartitionName\" : \"AssetPartitionName\",\n  \"SyncGroupId\" : 5,\n  \"UserProperties\" : {\n    \"UserWasHelpdeskAdmin\" : true,\n    \"UserName\" : \"UserName\",\n    \"UserWasPartitionOwner\" : true,\n    \"DomainName\" : \"DomainName\",\n    \"UserWasSystemAuditor\" : true,\n    \"UserWasAuditor\" : true,\n    \"UserWasApplianceAdmin\" : true,\n    \"UserWasGlobalAdmin\" : true,\n    \"UserWasDirectoryAdmin\" : true,\n    \"UserWasOperationsAdmin\" : true,\n    \"UserWasApplicationAuditor\" : true,\n    \"ClientIpAddress\" : \"ClientIpAddress\",\n    \"UserWasAssetAdmin\" : true,\n    \"UserWasUserAdmin\" : true,\n    \"UserDisplayName\" : \"UserDisplayName\",\n    \"UserWasPolicyAdmin\" : true\n  },\n  \"AssetDiscoveryType\" : \"Directory\",\n  \"ApplianceId\" : \"ApplianceId\",\n  \"AssetId\" : 6,\n  \"RequestStatus\" : {\n    \"EndTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"Message\" : \"Message\",\n    \"State\" : \"Unknown\",\n    \"PercentComplete\" : 2,\n    \"Cancellable\" : true,\n    \"StartTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"QueuedDuration\" : \"QueuedDuration\",\n    \"RunningDuration\" : \"RunningDuration\",\n    \"AcceptanceDuration\" : \"AcceptanceDuration\",\n    \"AcceptedTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"TotalDuration\" : \"TotalDuration\"\n  },\n  \"AccountName\" : \"AccountName\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<RunningTask>(exampleJson)
                        : default(RunningTask);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets a list of running tasks by task name
        /// </summary>
        /// <param name="taskName">Name of tasks to filter by. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have AssetAdmin, PartitionAdmin, ApplicationAuditor or Auditor permission</response>
        [HttpGet]
        [Route("/service/core/v4/RunningTasks/{taskName}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("RunningTasksGetByNameAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<RunningTask>), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have AssetAdmin, PartitionAdmin, ApplicationAuditor or Auditor permission")]
        public virtual IActionResult RunningTasksGetByNameAsync([FromRoute][Required]TaskNames taskName, [FromQuery]DateTime? startDate, [FromQuery]DateTime? endDate, [FromQuery]string filter, [FromQuery]int? page, [FromQuery]int? limit, [FromQuery]bool? count, [FromQuery]string fields, [FromQuery]string orderby, [FromQuery]string q)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<RunningTask>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"AssetPartitionId\" : 0,\n  \"ProfileId\" : 5,\n  \"TaskId\" : \"TaskId\",\n  \"AccountId\" : 1,\n  \"SyncGroupName\" : \"SyncGroupName\",\n  \"ProfileName\" : \"ProfileName\",\n  \"AssetName\" : \"AssetName\",\n  \"Name\" : \"Unknown\",\n  \"AssetDiscoveryJobName\" : \"AssetDiscoveryJobName\",\n  \"AssetPartitionName\" : \"AssetPartitionName\",\n  \"SyncGroupId\" : 5,\n  \"UserProperties\" : {\n    \"UserWasHelpdeskAdmin\" : true,\n    \"UserName\" : \"UserName\",\n    \"UserWasPartitionOwner\" : true,\n    \"DomainName\" : \"DomainName\",\n    \"UserWasSystemAuditor\" : true,\n    \"UserWasAuditor\" : true,\n    \"UserWasApplianceAdmin\" : true,\n    \"UserWasGlobalAdmin\" : true,\n    \"UserWasDirectoryAdmin\" : true,\n    \"UserWasOperationsAdmin\" : true,\n    \"UserWasApplicationAuditor\" : true,\n    \"ClientIpAddress\" : \"ClientIpAddress\",\n    \"UserWasAssetAdmin\" : true,\n    \"UserWasUserAdmin\" : true,\n    \"UserDisplayName\" : \"UserDisplayName\",\n    \"UserWasPolicyAdmin\" : true\n  },\n  \"AssetDiscoveryType\" : \"Directory\",\n  \"ApplianceId\" : \"ApplianceId\",\n  \"AssetId\" : 6,\n  \"RequestStatus\" : {\n    \"EndTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"Message\" : \"Message\",\n    \"State\" : \"Unknown\",\n    \"PercentComplete\" : 2,\n    \"Cancellable\" : true,\n    \"StartTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"QueuedDuration\" : \"QueuedDuration\",\n    \"RunningDuration\" : \"RunningDuration\",\n    \"AcceptanceDuration\" : \"AcceptanceDuration\",\n    \"AcceptedTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"TotalDuration\" : \"TotalDuration\"\n  },\n  \"AccountName\" : \"AccountName\"\n}, {\n  \"AssetPartitionId\" : 0,\n  \"ProfileId\" : 5,\n  \"TaskId\" : \"TaskId\",\n  \"AccountId\" : 1,\n  \"SyncGroupName\" : \"SyncGroupName\",\n  \"ProfileName\" : \"ProfileName\",\n  \"AssetName\" : \"AssetName\",\n  \"Name\" : \"Unknown\",\n  \"AssetDiscoveryJobName\" : \"AssetDiscoveryJobName\",\n  \"AssetPartitionName\" : \"AssetPartitionName\",\n  \"SyncGroupId\" : 5,\n  \"UserProperties\" : {\n    \"UserWasHelpdeskAdmin\" : true,\n    \"UserName\" : \"UserName\",\n    \"UserWasPartitionOwner\" : true,\n    \"DomainName\" : \"DomainName\",\n    \"UserWasSystemAuditor\" : true,\n    \"UserWasAuditor\" : true,\n    \"UserWasApplianceAdmin\" : true,\n    \"UserWasGlobalAdmin\" : true,\n    \"UserWasDirectoryAdmin\" : true,\n    \"UserWasOperationsAdmin\" : true,\n    \"UserWasApplicationAuditor\" : true,\n    \"ClientIpAddress\" : \"ClientIpAddress\",\n    \"UserWasAssetAdmin\" : true,\n    \"UserWasUserAdmin\" : true,\n    \"UserDisplayName\" : \"UserDisplayName\",\n    \"UserWasPolicyAdmin\" : true\n  },\n  \"AssetDiscoveryType\" : \"Directory\",\n  \"ApplianceId\" : \"ApplianceId\",\n  \"AssetId\" : 6,\n  \"RequestStatus\" : {\n    \"EndTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"Message\" : \"Message\",\n    \"State\" : \"Unknown\",\n    \"PercentComplete\" : 2,\n    \"Cancellable\" : true,\n    \"StartTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"QueuedDuration\" : \"QueuedDuration\",\n    \"RunningDuration\" : \"RunningDuration\",\n    \"AcceptanceDuration\" : \"AcceptanceDuration\",\n    \"AcceptedTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"TotalDuration\" : \"TotalDuration\"\n  },\n  \"AccountName\" : \"AccountName\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<RunningTask>>(exampleJson)
                        : default(List<RunningTask>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
