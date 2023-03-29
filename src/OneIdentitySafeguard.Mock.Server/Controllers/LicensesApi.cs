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
    public class LicensesApiController : ControllerBase
    { 
        /// <summary>
        /// Removes an installed license.
        /// </summary>
        /// <param name="key">License key of the license to remove.</param>
        /// <response code="204">The license was successfully removed.</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("/service/core/v4/Licenses/{key}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LicensesDeleteAsync")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult LicensesDeleteAsync([FromRoute][Required]string key)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all licenses currently staged or install on the appliance.
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <response code="200">Success</response>
        /// <response code="400">Installed licenses returned.</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/service/core/v4/Licenses")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LicensesGetAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ProductLicense>), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult LicensesGetAsync([FromQuery]string filter, [FromQuery]int? page, [FromQuery]int? limit, [FromQuery]bool? count, [FromQuery]string fields, [FromQuery]string orderby, [FromQuery]string q)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ProductLicense>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"Status\" : \"None\",\n  \"DaysRemaining\" : 0,\n  \"IsExpired\" : true,\n  \"InstallByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"TrialDays\" : 6,\n  \"SecretsBrokerLicense\" : {\n    \"SecretsUsed\" : 7,\n    \"MaxSecrets\" : 4\n  },\n  \"Type\" : \"Unknown\",\n  \"IsEnterprise\" : true,\n  \"ChangedByUserDisplayName\" : \"ChangedByUserDisplayName\",\n  \"ChangedByUserId\" : 1,\n  \"PasswordManagementLicense\" : {\n    \"MaxUsers\" : 5,\n    \"SystemsUsed\" : 2,\n    \"Version\" : 5,\n    \"MaxDesktops\" : 7,\n    \"Model\" : \"User\",\n    \"MaxSystems\" : 3,\n    \"DesktopsUsed\" : 9,\n    \"UsersUsed\" : 2\n  },\n  \"Expires\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Module\" : \"PasswordManagement\",\n  \"ChangedByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Key\" : \"Key\",\n  \"IsValid\" : true\n}, {\n  \"Status\" : \"None\",\n  \"DaysRemaining\" : 0,\n  \"IsExpired\" : true,\n  \"InstallByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"TrialDays\" : 6,\n  \"SecretsBrokerLicense\" : {\n    \"SecretsUsed\" : 7,\n    \"MaxSecrets\" : 4\n  },\n  \"Type\" : \"Unknown\",\n  \"IsEnterprise\" : true,\n  \"ChangedByUserDisplayName\" : \"ChangedByUserDisplayName\",\n  \"ChangedByUserId\" : 1,\n  \"PasswordManagementLicense\" : {\n    \"MaxUsers\" : 5,\n    \"SystemsUsed\" : 2,\n    \"Version\" : 5,\n    \"MaxDesktops\" : 7,\n    \"Model\" : \"User\",\n    \"MaxSystems\" : 3,\n    \"DesktopsUsed\" : 9,\n    \"UsersUsed\" : 2\n  },\n  \"Expires\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Module\" : \"PasswordManagement\",\n  \"ChangedByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Key\" : \"Key\",\n  \"IsValid\" : true\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ProductLicense>>(exampleJson)
                        : default(List<ProductLicense>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets installed license matching the given key.
        /// </summary>
        /// <param name="key">License key of the license to return.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <response code="200">Success</response>
        /// <response code="400">60251 - License Key missing from request.</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">No license with the given key was found.</response>
        [HttpGet]
        [Route("/service/core/v4/Licenses/{key}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LicensesGetByKeyAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProductLicense), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "60251 - License Key missing from request.")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult LicensesGetByKeyAsync([FromRoute][Required]string key, [FromQuery]string fields)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ProductLicense));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"Status\" : \"None\",\n  \"DaysRemaining\" : 0,\n  \"IsExpired\" : true,\n  \"InstallByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"TrialDays\" : 6,\n  \"SecretsBrokerLicense\" : {\n    \"SecretsUsed\" : 7,\n    \"MaxSecrets\" : 4\n  },\n  \"Type\" : \"Unknown\",\n  \"IsEnterprise\" : true,\n  \"ChangedByUserDisplayName\" : \"ChangedByUserDisplayName\",\n  \"ChangedByUserId\" : 1,\n  \"PasswordManagementLicense\" : {\n    \"MaxUsers\" : 5,\n    \"SystemsUsed\" : 2,\n    \"Version\" : 5,\n    \"MaxDesktops\" : 7,\n    \"Model\" : \"User\",\n    \"MaxSystems\" : 3,\n    \"DesktopsUsed\" : 9,\n    \"UsersUsed\" : 2\n  },\n  \"Expires\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Module\" : \"PasswordManagement\",\n  \"ChangedByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Key\" : \"Key\",\n  \"IsValid\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ProductLicense>(exampleJson)
                        : default(ProductLicense);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns whether the Software Transaction Agreement has been accepted by a user already
        /// </summary>
        /// <response code="200">Success</response>
        /// <response code="400">Failed to get STA Acceptance status.</response>
        /// <response code="401">Must be an authenticated user</response>
        [HttpGet]
        [Route("/service/core/v4/Licenses/Sta")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LicensesGetStaAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(StaAcceptance), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Failed to get STA Acceptance status.")]
        [SwaggerResponse(statusCode: 401, type: typeof(ApiError), description: "Must be an authenticated user")]
        public virtual IActionResult LicensesGetStaAsync()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(StaAcceptance));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"UserId\" : 0,\n  \"TimeOfAcceptance\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"UserDisplayName\" : \"UserDisplayName\",\n  \"Accepted\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<StaAcceptance>(exampleJson)
                        : default(StaAcceptance);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets a summary of licenses.
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <response code="200">Success</response>
        /// <response code="403">Authentication is not required</response>
        [HttpGet]
        [Route("/service/core/v4/Licenses/Summary")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LicensesGetSummaryAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<LicenseSummary>), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Authentication is not required")]
        public virtual IActionResult LicensesGetSummaryAsync([FromQuery]string filter, [FromQuery]int? page, [FromQuery]int? limit, [FromQuery]bool? count, [FromQuery]string fields, [FromQuery]string orderby, [FromQuery]string q)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<LicenseSummary>));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"Type\" : \"Unknown\",\n  \"Expires\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Module\" : \"PasswordManagement\",\n  \"IsValid\" : true\n}, {\n  \"Type\" : \"Unknown\",\n  \"Expires\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Module\" : \"PasswordManagement\",\n  \"IsValid\" : true\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<LicenseSummary>>(exampleJson)
                        : default(List<LicenseSummary>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Installs the staged license with the given signature.
        /// </summary>
        /// <param name="key">The license key of the staged license to install.</param>
        /// <response code="200">The license was installed.</response>
        /// <response code="400">60259 - Failed to move license from staged to installed.</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">No staged licenses found matching the given signature.</response>
        [HttpPost]
        [Route("/service/core/v4/Licenses/{key}/Install")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LicensesPostInstallAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProductLicense), description: "The license was installed.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "60259 - Failed to move license from staged to installed.")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult LicensesPostInstallAsync([FromRoute][Required]string key)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ProductLicense));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"Status\" : \"None\",\n  \"DaysRemaining\" : 0,\n  \"IsExpired\" : true,\n  \"InstallByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"TrialDays\" : 6,\n  \"SecretsBrokerLicense\" : {\n    \"SecretsUsed\" : 7,\n    \"MaxSecrets\" : 4\n  },\n  \"Type\" : \"Unknown\",\n  \"IsEnterprise\" : true,\n  \"ChangedByUserDisplayName\" : \"ChangedByUserDisplayName\",\n  \"ChangedByUserId\" : 1,\n  \"PasswordManagementLicense\" : {\n    \"MaxUsers\" : 5,\n    \"SystemsUsed\" : 2,\n    \"Version\" : 5,\n    \"MaxDesktops\" : 7,\n    \"Model\" : \"User\",\n    \"MaxSystems\" : 3,\n    \"DesktopsUsed\" : 9,\n    \"UsersUsed\" : 2\n  },\n  \"Expires\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Module\" : \"PasswordManagement\",\n  \"ChangedByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Key\" : \"Key\",\n  \"IsValid\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ProductLicense>(exampleJson)
                        : default(ProductLicense);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Stages a license file contained in the JSON object, Base64 encoded.
        /// </summary>
        /// <param name="body">The LicenseFile object containing the Base64 encoded license file.</param>
        /// <response code="201">The license was validated and staged.</response>
        /// <response code="400">60252 - The incoming data or license failed validation.</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("/service/core/v4/Licenses")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LicensesPostLicenseAsJsonAsync")]
        [SwaggerResponse(statusCode: 201, type: typeof(ProductLicense), description: "The license was validated and staged.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "60252 - The incoming data or license failed validation.")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult LicensesPostLicenseAsJsonAsync([FromBody]LicenseFile body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(ProductLicense));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"Status\" : \"None\",\n  \"DaysRemaining\" : 0,\n  \"IsExpired\" : true,\n  \"InstallByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"TrialDays\" : 6,\n  \"SecretsBrokerLicense\" : {\n    \"SecretsUsed\" : 7,\n    \"MaxSecrets\" : 4\n  },\n  \"Type\" : \"Unknown\",\n  \"IsEnterprise\" : true,\n  \"ChangedByUserDisplayName\" : \"ChangedByUserDisplayName\",\n  \"ChangedByUserId\" : 1,\n  \"PasswordManagementLicense\" : {\n    \"MaxUsers\" : 5,\n    \"SystemsUsed\" : 2,\n    \"Version\" : 5,\n    \"MaxDesktops\" : 7,\n    \"Model\" : \"User\",\n    \"MaxSystems\" : 3,\n    \"DesktopsUsed\" : 9,\n    \"UsersUsed\" : 2\n  },\n  \"Expires\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Module\" : \"PasswordManagement\",\n  \"ChangedByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Key\" : \"Key\",\n  \"IsValid\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ProductLicense>(exampleJson)
                        : default(ProductLicense);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Stages a license file as a raw stream.
        /// </summary>
        /// <param name="body"></param>
        /// <response code="201">The license was validated and staged.</response>
        /// <response code="400">The incoming data or license failed validation.</response>
        /// <response code="403">Forbidden</response>
        /// <response code="411">The Content-Length header is missing from the request.</response>
        [HttpPost]
        [Route("/service/core/v4/Licenses/Raw")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LicensesPostRawLicenseAsync")]
        [SwaggerResponse(statusCode: 201, type: typeof(ProductLicense), description: "The license was validated and staged.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "The incoming data or license failed validation.")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult LicensesPostRawLicenseAsync([FromBody]LicensesRawBody body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(ProductLicense));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 411 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(411);
            string exampleJson = null;
            exampleJson = "{\n  \"Status\" : \"None\",\n  \"DaysRemaining\" : 0,\n  \"IsExpired\" : true,\n  \"InstallByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"TrialDays\" : 6,\n  \"SecretsBrokerLicense\" : {\n    \"SecretsUsed\" : 7,\n    \"MaxSecrets\" : 4\n  },\n  \"Type\" : \"Unknown\",\n  \"IsEnterprise\" : true,\n  \"ChangedByUserDisplayName\" : \"ChangedByUserDisplayName\",\n  \"ChangedByUserId\" : 1,\n  \"PasswordManagementLicense\" : {\n    \"MaxUsers\" : 5,\n    \"SystemsUsed\" : 2,\n    \"Version\" : 5,\n    \"MaxDesktops\" : 7,\n    \"Model\" : \"User\",\n    \"MaxSystems\" : 3,\n    \"DesktopsUsed\" : 9,\n    \"UsersUsed\" : 2\n  },\n  \"Expires\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Module\" : \"PasswordManagement\",\n  \"ChangedByDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Key\" : \"Key\",\n  \"IsValid\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ProductLicense>(exampleJson)
                        : default(ProductLicense);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Records user&#x27;s acceptance of the Software Transaction Agreement
        /// </summary>
        /// <response code="200">The user&#x27;s acceptance was stored successfully.</response>
        /// <response code="400">Failed to store STA acceptance.</response>
        /// <response code="401">Must be an authenticated user</response>
        /// <response code="403">Must have ApplianceAdmin permission</response>
        [HttpPost]
        [Route("/service/core/v4/Licenses/Sta")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LicensesPostStaAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(StaAcceptance), description: "The user&#x27;s acceptance was stored successfully.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Failed to store STA acceptance.")]
        [SwaggerResponse(statusCode: 401, type: typeof(ApiError), description: "Must be an authenticated user")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have ApplianceAdmin permission")]
        public virtual IActionResult LicensesPostStaAsync()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(StaAcceptance));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"UserId\" : 0,\n  \"TimeOfAcceptance\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"UserDisplayName\" : \"UserDisplayName\",\n  \"Accepted\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<StaAcceptance>(exampleJson)
                        : default(StaAcceptance);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}