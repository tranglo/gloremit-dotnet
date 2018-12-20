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
    /// GetValidationModelResponse
    /// </summary>
    [DataContract]
    public partial class GetValidationModelResponse :  IEquatable<GetValidationModelResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetValidationModelResponse" /> class.
        /// </summary>
        /// <param name="ValidateStatus">ValidateStatus.</param>
        /// <param name="TransID">TransID.</param>
        /// <param name="BeneficiaryName">BeneficiaryName.</param>
        /// <param name="Description">Description.</param>
        public GetValidationModelResponse(string ValidateStatus = default(string), string TransID = default(string), string BeneficiaryName = default(string), string Description = default(string))
        {
            this.ValidateStatus = ValidateStatus;
            this.TransID = TransID;
            this.BeneficiaryName = BeneficiaryName;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets ValidateStatus
        /// </summary>
        [DataMember(Name="ValidateStatus", EmitDefaultValue=false)]
        public string ValidateStatus { get; set; }

        /// <summary>
        /// Gets or Sets TransID
        /// </summary>
        [DataMember(Name="transID", EmitDefaultValue=false)]
        public string TransID { get; set; }

        /// <summary>
        /// Gets or Sets BeneficiaryName
        /// </summary>
        [DataMember(Name="BeneficiaryName", EmitDefaultValue=false)]
        public string BeneficiaryName { get; set; }

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
            sb.Append("class GetValidationModelResponse {\n");
            sb.Append("  ValidateStatus: ").Append(ValidateStatus).Append("\n");
            sb.Append("  TransID: ").Append(TransID).Append("\n");
            sb.Append("  BeneficiaryName: ").Append(BeneficiaryName).Append("\n");
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
            return this.Equals(input as GetValidationModelResponse);
        }

        /// <summary>
        /// Returns true if GetValidationModelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetValidationModelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetValidationModelResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidateStatus == input.ValidateStatus ||
                    (this.ValidateStatus != null &&
                    this.ValidateStatus.Equals(input.ValidateStatus))
                ) && 
                (
                    this.TransID == input.TransID ||
                    (this.TransID != null &&
                    this.TransID.Equals(input.TransID))
                ) && 
                (
                    this.BeneficiaryName == input.BeneficiaryName ||
                    (this.BeneficiaryName != null &&
                    this.BeneficiaryName.Equals(input.BeneficiaryName))
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
                if (this.ValidateStatus != null)
                    hashCode = hashCode * 59 + this.ValidateStatus.GetHashCode();
                if (this.TransID != null)
                    hashCode = hashCode * 59 + this.TransID.GetHashCode();
                if (this.BeneficiaryName != null)
                    hashCode = hashCode * 59 + this.BeneficiaryName.GetHashCode();
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