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
    /// GetForexModelResponse
    /// </summary>
    [DataContract]
    public partial class GetForexModelResponse :  IEquatable<GetForexModelResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetForexModelResponse" /> class.
        /// </summary>
        /// <param name="CurrFrom">CurrFrom.</param>
        /// <param name="CurrTo">CurrTo.</param>
        /// <param name="CurrRate">CurrRate.</param>
        /// <param name="FRKey">FRKey.</param>
        /// <param name="ExpiryDatetime">ExpiryDatetime.</param>
        public GetForexModelResponse(string CurrFrom = default(string), string CurrTo = default(string), double? CurrRate = default(double?), string FRKey = default(string), DateTime? ExpiryDatetime = default(DateTime?))
        {
            this.CurrFrom = CurrFrom;
            this.CurrTo = CurrTo;
            this.CurrRate = CurrRate;
            this.FRKey = FRKey;
            this.ExpiryDatetime = ExpiryDatetime;
        }
        
        /// <summary>
        /// Gets or Sets CurrFrom
        /// </summary>
        [DataMember(Name="CurrFrom", EmitDefaultValue=false)]
        public string CurrFrom { get; set; }

        /// <summary>
        /// Gets or Sets CurrTo
        /// </summary>
        [DataMember(Name="CurrTo", EmitDefaultValue=false)]
        public string CurrTo { get; set; }

        /// <summary>
        /// Gets or Sets CurrRate
        /// </summary>
        [DataMember(Name="CurrRate", EmitDefaultValue=false)]
        public double? CurrRate { get; set; }

        /// <summary>
        /// Gets or Sets FRKey
        /// </summary>
        [DataMember(Name="FR_Key", EmitDefaultValue=false)]
        public string FRKey { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDatetime
        /// </summary>
        [DataMember(Name="Expiry_Datetime", EmitDefaultValue=false)]
        public DateTime? ExpiryDatetime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetForexModelResponse {\n");
            sb.Append("  CurrFrom: ").Append(CurrFrom).Append("\n");
            sb.Append("  CurrTo: ").Append(CurrTo).Append("\n");
            sb.Append("  CurrRate: ").Append(CurrRate).Append("\n");
            sb.Append("  FRKey: ").Append(FRKey).Append("\n");
            sb.Append("  ExpiryDatetime: ").Append(ExpiryDatetime).Append("\n");
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
            return this.Equals(input as GetForexModelResponse);
        }

        /// <summary>
        /// Returns true if GetForexModelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetForexModelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetForexModelResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrFrom == input.CurrFrom ||
                    (this.CurrFrom != null &&
                    this.CurrFrom.Equals(input.CurrFrom))
                ) && 
                (
                    this.CurrTo == input.CurrTo ||
                    (this.CurrTo != null &&
                    this.CurrTo.Equals(input.CurrTo))
                ) && 
                (
                    this.CurrRate == input.CurrRate ||
                    (this.CurrRate != null &&
                    this.CurrRate.Equals(input.CurrRate))
                ) && 
                (
                    this.FRKey == input.FRKey ||
                    (this.FRKey != null &&
                    this.FRKey.Equals(input.FRKey))
                ) && 
                (
                    this.ExpiryDatetime == input.ExpiryDatetime ||
                    (this.ExpiryDatetime != null &&
                    this.ExpiryDatetime.Equals(input.ExpiryDatetime))
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
                if (this.CurrFrom != null)
                    hashCode = hashCode * 59 + this.CurrFrom.GetHashCode();
                if (this.CurrTo != null)
                    hashCode = hashCode * 59 + this.CurrTo.GetHashCode();
                if (this.CurrRate != null)
                    hashCode = hashCode * 59 + this.CurrRate.GetHashCode();
                if (this.FRKey != null)
                    hashCode = hashCode * 59 + this.FRKey.GetHashCode();
                if (this.ExpiryDatetime != null)
                    hashCode = hashCode * 59 + this.ExpiryDatetime.GetHashCode();
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
