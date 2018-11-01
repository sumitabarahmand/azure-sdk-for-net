// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.InfrastructureInsights.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This object represents an alert resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Alert : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        public Alert()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">The Azure Region where the resource
        /// lives</param>
        /// <param name="closedTimestamp">Timestamp when the alert was
        /// closed.</param>
        /// <param name="createdTimestamp">Timestamp when the alert was
        /// created.</param>
        /// <param name="description">Description of the alert.</param>
        /// <param name="faultId">Gets or sets the fault ID of the
        /// alert.</param>
        /// <param name="alertId">Gets or sets the ID of the alert.</param>
        /// <param name="faultTypeId">Gets or sets the fault type ID of the
        /// alert.</param>
        /// <param name="lastUpdatedTimestamp">Timestamp when the alert was
        /// last updated.</param>
        /// <param name="alertProperties">Properties of the alert.</param>
        /// <param name="remediation">Gets or sets the admin friendly
        /// remediation instructions for the alert.</param>
        /// <param name="resourceRegistrationId">Gets or sets the registration
        /// ID of the resource associated with the alert. If the alert is not
        /// associated with a resource, the resource registration ID is
        /// null.</param>
        /// <param name="resourceProviderRegistrationId">Gets or sets the
        /// registration ID of the service the alert belongs to.</param>
        /// <param name="severity">Severity of the alert.</param>
        /// <param name="state">State of the alert.</param>
        /// <param name="title">Gets or sets the Resource ID for the impacted
        /// item.</param>
        /// <param name="impactedResourceId">Gets or sets the Resource ID for
        /// the impacted item.</param>
        /// <param name="impactedResourceDisplayName">Display name for the
        /// impacted item.</param>
        /// <param name="closedByUserAlias">User alias who closed the
        /// alert.</param>
        /// <param name="hasValidRemediationAction">Indicates if the alert can
        /// be remediated.</param>
        public Alert(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string closedTimestamp = default(string), string createdTimestamp = default(string), IList<IDictionary<string, string>> description = default(IList<IDictionary<string, string>>), string faultId = default(string), string alertId = default(string), string faultTypeId = default(string), string lastUpdatedTimestamp = default(string), IDictionary<string, string> alertProperties = default(IDictionary<string, string>), IList<IDictionary<string, string>> remediation = default(IList<IDictionary<string, string>>), string resourceRegistrationId = default(string), string resourceProviderRegistrationId = default(string), string severity = default(string), string state = default(string), string title = default(string), string impactedResourceId = default(string), string impactedResourceDisplayName = default(string), string closedByUserAlias = default(string), string hasValidRemediationAction = default(string))
            : base(id, name, type, tags, location)
        {
            ClosedTimestamp = closedTimestamp;
            CreatedTimestamp = createdTimestamp;
            Description = description;
            FaultId = faultId;
            AlertId = alertId;
            FaultTypeId = faultTypeId;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            AlertProperties = alertProperties;
            Remediation = remediation;
            ResourceRegistrationId = resourceRegistrationId;
            ResourceProviderRegistrationId = resourceProviderRegistrationId;
            Severity = severity;
            State = state;
            Title = title;
            ImpactedResourceId = impactedResourceId;
            ImpactedResourceDisplayName = impactedResourceDisplayName;
            ClosedByUserAlias = closedByUserAlias;
            HasValidRemediationAction = hasValidRemediationAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets timestamp when the alert was closed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.closedTimestamp")]
        public string ClosedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets timestamp when the alert was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTimestamp")]
        public string CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets description of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public IList<IDictionary<string, string>> Description { get; set; }

        /// <summary>
        /// Gets or sets the fault ID of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.faultId")]
        public string FaultId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertId")]
        public string AlertId { get; set; }

        /// <summary>
        /// Gets or sets the fault type ID of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.faultTypeId")]
        public string FaultTypeId { get; set; }

        /// <summary>
        /// Gets or sets timestamp when the alert was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedTimestamp")]
        public string LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets properties of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertProperties")]
        public IDictionary<string, string> AlertProperties { get; set; }

        /// <summary>
        /// Gets or sets the admin friendly remediation instructions for the
        /// alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remediation")]
        public IList<IDictionary<string, string>> Remediation { get; set; }

        /// <summary>
        /// Gets or sets the registration ID of the resource associated with
        /// the alert. If the alert is not associated with a resource, the
        /// resource registration ID is null.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceRegistrationId")]
        public string ResourceRegistrationId { get; set; }

        /// <summary>
        /// Gets or sets the registration ID of the service the alert belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceProviderRegistrationId")]
        public string ResourceProviderRegistrationId { get; set; }

        /// <summary>
        /// Gets or sets severity of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets state of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the Resource ID for the impacted item.
        /// </summary>
        [JsonProperty(PropertyName = "properties.title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Resource ID for the impacted item.
        /// </summary>
        [JsonProperty(PropertyName = "properties.impactedResourceId")]
        public string ImpactedResourceId { get; set; }

        /// <summary>
        /// Gets or sets display name for the impacted item.
        /// </summary>
        [JsonProperty(PropertyName = "properties.impactedResourceDisplayName")]
        public string ImpactedResourceDisplayName { get; set; }

        /// <summary>
        /// Gets or sets user alias who closed the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.closedByUserAlias")]
        public string ClosedByUserAlias { get; set; }

        /// <summary>
        /// Gets or sets indicates if the alert can be remediated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasValidRemediationAction")]
        public string HasValidRemediationAction { get; set; }

    }
}
