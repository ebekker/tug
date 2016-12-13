/*
 * Copyright © The DevOps Collective, Inc. All rights reserved.
 * Licnesed under GNU GPL v3. See top-level LICENSE.txt for more details.
 */

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Tug.Messages.ModelBinding;
using Tug.Model;

namespace Tug.Messages
{
    public class RegisterDscAgentRequest : DscAgentRequest
    {
        [FromBody]
        [Required]
        public RegisterDscAgentRequestBody Body
        { get; set; }
    }

    public class RegisterDscAgentResponse : DscResponse
    {
        /// <summary>
        /// We only need a single instance since there are
        /// no mutable elements in the object graph.
        /// </summary>
        public static readonly RegisterDscAgentResponse INSTANCE =
                new RegisterDscAgentResponse();

        [ToResult]
        public NoContentResult Body
        { get; } = new NoContentResult();
    }
}