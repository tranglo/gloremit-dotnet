/* 
 * GloRemit - REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// GetCancellationStatusModelResponse
    /// </summary>
    [DataContract]
    public partial class GetCancellationStatusModelResponse :  IEquatable<GetCancellationStatusModelResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCancellationStatusModelResponse" /> class.
        /// </summary>
        /// <param name="TrxStatus">TrxStatus.</param>
        /// <param name="CancelID">CancelID.</param>
        /// <param name="TransID">TransID.</param>
        /// <param name="StatusUpdated">StatusUpdated.</param>
        /// <param name="Description">Description.</param>
        public GetCancellationStatusModelResponse(string TrxStatus = default(string), string CancelID = default(string), string TransID = default(string), DateTime? StatusUpdated = default(DateTime?), string Description = default(string))
        {
            this.TrxStatus = TrxStatus;
            this.CancelID = CancelID;
            this.TransID = TransID;
            this.StatusUpdated = StatusUpdated;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets TrxStatus
        /// </summary>
        [DataMember(Name="TrxStatus", EmitDefaultValue=false)]
        public string TrxStatus { get; set; }

        /// <summary>
        /// Gets or Sets CancelID
        /// </summary>
        [DataMember(Name="CancelID", EmitDefaultValue=false)]
        public string CancelID { get; set; }

        /// <summary>
        /// Gets or Sets TransID
        /// </summary>
        [DataMember(Name="transID", EmitDefaultValue=false)]
        public string TransID { get; set; }

        /// <summary>
        /// Gets or Sets StatusUpdated
        /// </summary>
        [DataMember(Name="StatusUpdated", EmitDefaultValue=false)]
        public DateTime? StatusUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCancellationStatusModelResponse {\n");
            sb.Append("  TrxStatus: ").Append(TrxStatus).Append("\n");
            sb.Append("  CancelID: ").Append(CancelID).Append("\n");
            sb.Append("  TransID: ").Append(TransID).Append("\n");
            sb.Append("  StatusUpdated: ").Append(StatusUpdated).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetCancellationStatusModelResponse);
        }

        /// <summary>
        /// Returns true if GetCancellationStatusModelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCancellationStatusModelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCancellationStatusModelResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrxStatus == input.TrxStatus ||
                    (this.TrxStatus != null &&
                    this.TrxStatus.Equals(input.TrxStatus))
                ) && 
                (
                    this.CancelID == input.CancelID ||
                    (this.CancelID != null &&
                    this.CancelID.Equals(input.CancelID))
                ) && 
                (
                    this.TransID == input.TransID ||
                    (this.TransID != null &&
                    this.TransID.Equals(input.TransID))
                ) && 
                (
                    this.StatusUpdated == input.StatusUpdated ||
                    (this.StatusUpdated != null &&
                    this.StatusUpdated.Equals(input.StatusUpdated))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TrxStatus != null)
                    hashCode = hashCode * 59 + this.TrxStatus.GetHashCode();
                if (this.CancelID != null)
                    hashCode = hashCode * 59 + this.CancelID.GetHashCode();
                if (this.TransID != null)
                    hashCode = hashCode * 59 + this.TransID.GetHashCode();
                if (this.StatusUpdated != null)
                    hashCode = hashCode * 59 + this.StatusUpdated.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
