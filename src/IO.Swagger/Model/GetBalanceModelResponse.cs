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
    /// GetBalanceModelResponse
    /// </summary>
    [DataContract]
    public partial class GetBalanceModelResponse :  IEquatable<GetBalanceModelResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceModelResponse" /> class.
        /// </summary>
        /// <param name="LastBal">LastBal.</param>
        public GetBalanceModelResponse(double? LastBal = default(double?))
        {
            this.LastBal = LastBal;
        }
        
        /// <summary>
        /// Gets or Sets LastBal
        /// </summary>
        [DataMember(Name="LastBal", EmitDefaultValue=false)]
        public double? LastBal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetBalanceModelResponse {\n");
            sb.Append("  LastBal: ").Append(LastBal).Append("\n");
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
            return this.Equals(input as GetBalanceModelResponse);
        }

        /// <summary>
        /// Returns true if GetBalanceModelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBalanceModelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBalanceModelResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastBal == input.LastBal ||
                    (this.LastBal != null &&
                    this.LastBal.Equals(input.LastBal))
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
                if (this.LastBal != null)
                    hashCode = hashCode * 59 + this.LastBal.GetHashCode();
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
