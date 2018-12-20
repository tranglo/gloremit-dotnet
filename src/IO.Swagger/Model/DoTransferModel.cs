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
    /// DoTransferModel
    /// </summary>
    [DataContract]
    public partial class DoTransferModel :  IEquatable<DoTransferModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoTransferModel" /> class.
        /// </summary>
        /// <param name="UIDBranch">UIDBranch.</param>
        /// <param name="TransID">TransID.</param>
        /// <param name="SFirstName">SFirstName.</param>
        /// <param name="SLastName">SLastName.</param>
        /// <param name="SIdType">SIdType.</param>
        /// <param name="SIdNum">SIdNum.</param>
        /// <param name="SIdExpiry">SIdExpiry.</param>
        /// <param name="SContactNum">SContactNum.</param>
        /// <param name="SOccupation">SOccupation.</param>
        /// <param name="SFundSource">SFundSource.</param>
        /// <param name="SBirthDate">SBirthDate.</param>
        /// <param name="SEmail">SEmail.</param>
        /// <param name="SAddress">SAddress.</param>
        /// <param name="SCity">SCity.</param>
        /// <param name="SPostCode">SPostCode.</param>
        /// <param name="SCountry">SCountry.</param>
        /// <param name="SCurrency">SCurrency.</param>
        /// <param name="BCountry">BCountry.</param>
        /// <param name="BCurrency">BCurrency.</param>
        /// <param name="TrxValue">TrxValue.</param>
        /// <param name="BFirstName">BFirstName.</param>
        /// <param name="BLastName">BLastName.</param>
        /// <param name="BAccType">BAccType.</param>
        /// <param name="BIssuerCode">BIssuerCode.</param>
        /// <param name="BankProvince">BankProvince.</param>
        /// <param name="BankCity">BankCity.</param>
        /// <param name="BankBranchName">BankBranchName.</param>
        /// <param name="BankBranchCode">BankBranchCode.</param>
        /// <param name="BAccNum">BAccNum.</param>
        /// <param name="BIdType">BIdType.</param>
        /// <param name="BIdNum">BIdNum.</param>
        /// <param name="BContactNum">BContactNum.</param>
        /// <param name="Relationship">Relationship.</param>
        /// <param name="BAddress">BAddress.</param>
        /// <param name="BCity">BCity.</param>
        /// <param name="BPostCode">BPostCode.</param>
        /// <param name="BEmail">BEmail.</param>
        /// <param name="BProvinceCode">BProvinceCode.</param>
        /// <param name="BRegencyCode">BRegencyCode.</param>
        /// <param name="BPayoutID">BPayoutID.</param>
        /// <param name="BPayoutPIN">BPayoutPIN.</param>
        /// <param name="SAmount">SAmount.</param>
        /// <param name="FRKey">FRKey.</param>
        /// <param name="BPurposeCode">BPurposeCode.</param>
        public DoTransferModel(string UIDBranch = default(string), string TransID = default(string), string SFirstName = default(string), string SLastName = default(string), int? SIdType = default(int?), string SIdNum = default(string), string SIdExpiry = default(string), string SContactNum = default(string), string SOccupation = default(string), string SFundSource = default(string), string SBirthDate = default(string), string SEmail = default(string), string SAddress = default(string), string SCity = default(string), string SPostCode = default(string), string SCountry = default(string), string SCurrency = default(string), string BCountry = default(string), string BCurrency = default(string), double? TrxValue = default(double?), string BFirstName = default(string), string BLastName = default(string), int? BAccType = default(int?), string BIssuerCode = default(string), string BankProvince = default(string), string BankCity = default(string), string BankBranchName = default(string), string BankBranchCode = default(string), string BAccNum = default(string), int? BIdType = default(int?), string BIdNum = default(string), string BContactNum = default(string), string Relationship = default(string), string BAddress = default(string), string BCity = default(string), string BPostCode = default(string), string BEmail = default(string), string BProvinceCode = default(string), string BRegencyCode = default(string), string BPayoutID = default(string), string BPayoutPIN = default(string), double? SAmount = default(double?), string FRKey = default(string), int? BPurposeCode = default(int?))
        {
            this.UIDBranch = UIDBranch;
            this.TransID = TransID;
            this.SFirstName = SFirstName;
            this.SLastName = SLastName;
            this.SIdType = SIdType;
            this.SIdNum = SIdNum;
            this.SIdExpiry = SIdExpiry;
            this.SContactNum = SContactNum;
            this.SOccupation = SOccupation;
            this.SFundSource = SFundSource;
            this.SBirthDate = SBirthDate;
            this.SEmail = SEmail;
            this.SAddress = SAddress;
            this.SCity = SCity;
            this.SPostCode = SPostCode;
            this.SCountry = SCountry;
            this.SCurrency = SCurrency;
            this.BCountry = BCountry;
            this.BCurrency = BCurrency;
            this.TrxValue = TrxValue;
            this.BFirstName = BFirstName;
            this.BLastName = BLastName;
            this.BAccType = BAccType;
            this.BIssuerCode = BIssuerCode;
            this.BankProvince = BankProvince;
            this.BankCity = BankCity;
            this.BankBranchName = BankBranchName;
            this.BankBranchCode = BankBranchCode;
            this.BAccNum = BAccNum;
            this.BIdType = BIdType;
            this.BIdNum = BIdNum;
            this.BContactNum = BContactNum;
            this.Relationship = Relationship;
            this.BAddress = BAddress;
            this.BCity = BCity;
            this.BPostCode = BPostCode;
            this.BEmail = BEmail;
            this.BProvinceCode = BProvinceCode;
            this.BRegencyCode = BRegencyCode;
            this.BPayoutID = BPayoutID;
            this.BPayoutPIN = BPayoutPIN;
            this.SAmount = SAmount;
            this.FRKey = FRKey;
            this.BPurposeCode = BPurposeCode;
        }
        
        /// <summary>
        /// Gets or Sets UIDBranch
        /// </summary>
        [DataMember(Name="UIDBranch", EmitDefaultValue=false)]
        public string UIDBranch { get; set; }

        /// <summary>
        /// Gets or Sets TransID
        /// </summary>
        [DataMember(Name="transID", EmitDefaultValue=false)]
        public string TransID { get; set; }

        /// <summary>
        /// Gets or Sets SFirstName
        /// </summary>
        [DataMember(Name="sFirstName", EmitDefaultValue=false)]
        public string SFirstName { get; set; }

        /// <summary>
        /// Gets or Sets SLastName
        /// </summary>
        [DataMember(Name="sLastName", EmitDefaultValue=false)]
        public string SLastName { get; set; }

        /// <summary>
        /// Gets or Sets SIdType
        /// </summary>
        [DataMember(Name="sIdType", EmitDefaultValue=false)]
        public int? SIdType { get; set; }

        /// <summary>
        /// Gets or Sets SIdNum
        /// </summary>
        [DataMember(Name="sIdNum", EmitDefaultValue=false)]
        public string SIdNum { get; set; }

        /// <summary>
        /// Gets or Sets SIdExpiry
        /// </summary>
        [DataMember(Name="sIdExpiry", EmitDefaultValue=false)]
        public string SIdExpiry { get; set; }

        /// <summary>
        /// Gets or Sets SContactNum
        /// </summary>
        [DataMember(Name="sContactNum", EmitDefaultValue=false)]
        public string SContactNum { get; set; }

        /// <summary>
        /// Gets or Sets SOccupation
        /// </summary>
        [DataMember(Name="sOccupation", EmitDefaultValue=false)]
        public string SOccupation { get; set; }

        /// <summary>
        /// Gets or Sets SFundSource
        /// </summary>
        [DataMember(Name="sFundSource", EmitDefaultValue=false)]
        public string SFundSource { get; set; }

        /// <summary>
        /// Gets or Sets SBirthDate
        /// </summary>
        [DataMember(Name="sBirthDate", EmitDefaultValue=false)]
        public string SBirthDate { get; set; }

        /// <summary>
        /// Gets or Sets SEmail
        /// </summary>
        [DataMember(Name="sEmail", EmitDefaultValue=false)]
        public string SEmail { get; set; }

        /// <summary>
        /// Gets or Sets SAddress
        /// </summary>
        [DataMember(Name="sAddress", EmitDefaultValue=false)]
        public string SAddress { get; set; }

        /// <summary>
        /// Gets or Sets SCity
        /// </summary>
        [DataMember(Name="sCity", EmitDefaultValue=false)]
        public string SCity { get; set; }

        /// <summary>
        /// Gets or Sets SPostCode
        /// </summary>
        [DataMember(Name="sPostCode", EmitDefaultValue=false)]
        public string SPostCode { get; set; }

        /// <summary>
        /// Gets or Sets SCountry
        /// </summary>
        [DataMember(Name="sCountry", EmitDefaultValue=false)]
        public string SCountry { get; set; }

        /// <summary>
        /// Gets or Sets SCurrency
        /// </summary>
        [DataMember(Name="sCurrency", EmitDefaultValue=false)]
        public string SCurrency { get; set; }

        /// <summary>
        /// Gets or Sets BCountry
        /// </summary>
        [DataMember(Name="bCountry", EmitDefaultValue=false)]
        public string BCountry { get; set; }

        /// <summary>
        /// Gets or Sets BCurrency
        /// </summary>
        [DataMember(Name="bCurrency", EmitDefaultValue=false)]
        public string BCurrency { get; set; }

        /// <summary>
        /// Gets or Sets TrxValue
        /// </summary>
        [DataMember(Name="trxValue", EmitDefaultValue=false)]
        public double? TrxValue { get; set; }

        /// <summary>
        /// Gets or Sets BFirstName
        /// </summary>
        [DataMember(Name="bFirstName", EmitDefaultValue=false)]
        public string BFirstName { get; set; }

        /// <summary>
        /// Gets or Sets BLastName
        /// </summary>
        [DataMember(Name="bLastName", EmitDefaultValue=false)]
        public string BLastName { get; set; }

        /// <summary>
        /// Gets or Sets BAccType
        /// </summary>
        [DataMember(Name="bAccType", EmitDefaultValue=false)]
        public int? BAccType { get; set; }

        /// <summary>
        /// Gets or Sets BIssuerCode
        /// </summary>
        [DataMember(Name="bIssuerCode", EmitDefaultValue=false)]
        public string BIssuerCode { get; set; }

        /// <summary>
        /// Gets or Sets BankProvince
        /// </summary>
        [DataMember(Name="BankProvince", EmitDefaultValue=false)]
        public string BankProvince { get; set; }

        /// <summary>
        /// Gets or Sets BankCity
        /// </summary>
        [DataMember(Name="BankCity", EmitDefaultValue=false)]
        public string BankCity { get; set; }

        /// <summary>
        /// Gets or Sets BankBranchName
        /// </summary>
        [DataMember(Name="BankBranchName", EmitDefaultValue=false)]
        public string BankBranchName { get; set; }

        /// <summary>
        /// Gets or Sets BankBranchCode
        /// </summary>
        [DataMember(Name="BankBranchCode", EmitDefaultValue=false)]
        public string BankBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets BAccNum
        /// </summary>
        [DataMember(Name="bAccNum", EmitDefaultValue=false)]
        public string BAccNum { get; set; }

        /// <summary>
        /// Gets or Sets BIdType
        /// </summary>
        [DataMember(Name="bIdType", EmitDefaultValue=false)]
        public int? BIdType { get; set; }

        /// <summary>
        /// Gets or Sets BIdNum
        /// </summary>
        [DataMember(Name="bIdNum", EmitDefaultValue=false)]
        public string BIdNum { get; set; }

        /// <summary>
        /// Gets or Sets BContactNum
        /// </summary>
        [DataMember(Name="bContactNum", EmitDefaultValue=false)]
        public string BContactNum { get; set; }

        /// <summary>
        /// Gets or Sets Relationship
        /// </summary>
        [DataMember(Name="Relationship", EmitDefaultValue=false)]
        public string Relationship { get; set; }

        /// <summary>
        /// Gets or Sets BAddress
        /// </summary>
        [DataMember(Name="bAddress", EmitDefaultValue=false)]
        public string BAddress { get; set; }

        /// <summary>
        /// Gets or Sets BCity
        /// </summary>
        [DataMember(Name="bCity", EmitDefaultValue=false)]
        public string BCity { get; set; }

        /// <summary>
        /// Gets or Sets BPostCode
        /// </summary>
        [DataMember(Name="bPostCode", EmitDefaultValue=false)]
        public string BPostCode { get; set; }

        /// <summary>
        /// Gets or Sets BEmail
        /// </summary>
        [DataMember(Name="bEmail", EmitDefaultValue=false)]
        public string BEmail { get; set; }

        /// <summary>
        /// Gets or Sets BProvinceCode
        /// </summary>
        [DataMember(Name="bProvinceCode", EmitDefaultValue=false)]
        public string BProvinceCode { get; set; }

        /// <summary>
        /// Gets or Sets BRegencyCode
        /// </summary>
        [DataMember(Name="bRegencyCode", EmitDefaultValue=false)]
        public string BRegencyCode { get; set; }

        /// <summary>
        /// Gets or Sets BPayoutID
        /// </summary>
        [DataMember(Name="bPayoutID", EmitDefaultValue=false)]
        public string BPayoutID { get; set; }

        /// <summary>
        /// Gets or Sets BPayoutPIN
        /// </summary>
        [DataMember(Name="bPayoutPIN", EmitDefaultValue=false)]
        public string BPayoutPIN { get; set; }

        /// <summary>
        /// Gets or Sets SAmount
        /// </summary>
        [DataMember(Name="sAmount", EmitDefaultValue=false)]
        public double? SAmount { get; set; }

        /// <summary>
        /// Gets or Sets FRKey
        /// </summary>
        [DataMember(Name="FR_Key", EmitDefaultValue=false)]
        public string FRKey { get; set; }

        /// <summary>
        /// Gets or Sets BPurposeCode
        /// </summary>
        [DataMember(Name="bPurposeCode", EmitDefaultValue=false)]
        public int? BPurposeCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DoTransferModel {\n");
            sb.Append("  UIDBranch: ").Append(UIDBranch).Append("\n");
            sb.Append("  TransID: ").Append(TransID).Append("\n");
            sb.Append("  SFirstName: ").Append(SFirstName).Append("\n");
            sb.Append("  SLastName: ").Append(SLastName).Append("\n");
            sb.Append("  SIdType: ").Append(SIdType).Append("\n");
            sb.Append("  SIdNum: ").Append(SIdNum).Append("\n");
            sb.Append("  SIdExpiry: ").Append(SIdExpiry).Append("\n");
            sb.Append("  SContactNum: ").Append(SContactNum).Append("\n");
            sb.Append("  SOccupation: ").Append(SOccupation).Append("\n");
            sb.Append("  SFundSource: ").Append(SFundSource).Append("\n");
            sb.Append("  SBirthDate: ").Append(SBirthDate).Append("\n");
            sb.Append("  SEmail: ").Append(SEmail).Append("\n");
            sb.Append("  SAddress: ").Append(SAddress).Append("\n");
            sb.Append("  SCity: ").Append(SCity).Append("\n");
            sb.Append("  SPostCode: ").Append(SPostCode).Append("\n");
            sb.Append("  SCountry: ").Append(SCountry).Append("\n");
            sb.Append("  SCurrency: ").Append(SCurrency).Append("\n");
            sb.Append("  BCountry: ").Append(BCountry).Append("\n");
            sb.Append("  BCurrency: ").Append(BCurrency).Append("\n");
            sb.Append("  TrxValue: ").Append(TrxValue).Append("\n");
            sb.Append("  BFirstName: ").Append(BFirstName).Append("\n");
            sb.Append("  BLastName: ").Append(BLastName).Append("\n");
            sb.Append("  BAccType: ").Append(BAccType).Append("\n");
            sb.Append("  BIssuerCode: ").Append(BIssuerCode).Append("\n");
            sb.Append("  BankProvince: ").Append(BankProvince).Append("\n");
            sb.Append("  BankCity: ").Append(BankCity).Append("\n");
            sb.Append("  BankBranchName: ").Append(BankBranchName).Append("\n");
            sb.Append("  BankBranchCode: ").Append(BankBranchCode).Append("\n");
            sb.Append("  BAccNum: ").Append(BAccNum).Append("\n");
            sb.Append("  BIdType: ").Append(BIdType).Append("\n");
            sb.Append("  BIdNum: ").Append(BIdNum).Append("\n");
            sb.Append("  BContactNum: ").Append(BContactNum).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
            sb.Append("  BAddress: ").Append(BAddress).Append("\n");
            sb.Append("  BCity: ").Append(BCity).Append("\n");
            sb.Append("  BPostCode: ").Append(BPostCode).Append("\n");
            sb.Append("  BEmail: ").Append(BEmail).Append("\n");
            sb.Append("  BProvinceCode: ").Append(BProvinceCode).Append("\n");
            sb.Append("  BRegencyCode: ").Append(BRegencyCode).Append("\n");
            sb.Append("  BPayoutID: ").Append(BPayoutID).Append("\n");
            sb.Append("  BPayoutPIN: ").Append(BPayoutPIN).Append("\n");
            sb.Append("  SAmount: ").Append(SAmount).Append("\n");
            sb.Append("  FRKey: ").Append(FRKey).Append("\n");
            sb.Append("  BPurposeCode: ").Append(BPurposeCode).Append("\n");
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
            return this.Equals(input as DoTransferModel);
        }

        /// <summary>
        /// Returns true if DoTransferModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DoTransferModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoTransferModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UIDBranch == input.UIDBranch ||
                    (this.UIDBranch != null &&
                    this.UIDBranch.Equals(input.UIDBranch))
                ) && 
                (
                    this.TransID == input.TransID ||
                    (this.TransID != null &&
                    this.TransID.Equals(input.TransID))
                ) && 
                (
                    this.SFirstName == input.SFirstName ||
                    (this.SFirstName != null &&
                    this.SFirstName.Equals(input.SFirstName))
                ) && 
                (
                    this.SLastName == input.SLastName ||
                    (this.SLastName != null &&
                    this.SLastName.Equals(input.SLastName))
                ) && 
                (
                    this.SIdType == input.SIdType ||
                    (this.SIdType != null &&
                    this.SIdType.Equals(input.SIdType))
                ) && 
                (
                    this.SIdNum == input.SIdNum ||
                    (this.SIdNum != null &&
                    this.SIdNum.Equals(input.SIdNum))
                ) && 
                (
                    this.SIdExpiry == input.SIdExpiry ||
                    (this.SIdExpiry != null &&
                    this.SIdExpiry.Equals(input.SIdExpiry))
                ) && 
                (
                    this.SContactNum == input.SContactNum ||
                    (this.SContactNum != null &&
                    this.SContactNum.Equals(input.SContactNum))
                ) && 
                (
                    this.SOccupation == input.SOccupation ||
                    (this.SOccupation != null &&
                    this.SOccupation.Equals(input.SOccupation))
                ) && 
                (
                    this.SFundSource == input.SFundSource ||
                    (this.SFundSource != null &&
                    this.SFundSource.Equals(input.SFundSource))
                ) && 
                (
                    this.SBirthDate == input.SBirthDate ||
                    (this.SBirthDate != null &&
                    this.SBirthDate.Equals(input.SBirthDate))
                ) && 
                (
                    this.SEmail == input.SEmail ||
                    (this.SEmail != null &&
                    this.SEmail.Equals(input.SEmail))
                ) && 
                (
                    this.SAddress == input.SAddress ||
                    (this.SAddress != null &&
                    this.SAddress.Equals(input.SAddress))
                ) && 
                (
                    this.SCity == input.SCity ||
                    (this.SCity != null &&
                    this.SCity.Equals(input.SCity))
                ) && 
                (
                    this.SPostCode == input.SPostCode ||
                    (this.SPostCode != null &&
                    this.SPostCode.Equals(input.SPostCode))
                ) && 
                (
                    this.SCountry == input.SCountry ||
                    (this.SCountry != null &&
                    this.SCountry.Equals(input.SCountry))
                ) && 
                (
                    this.SCurrency == input.SCurrency ||
                    (this.SCurrency != null &&
                    this.SCurrency.Equals(input.SCurrency))
                ) && 
                (
                    this.BCountry == input.BCountry ||
                    (this.BCountry != null &&
                    this.BCountry.Equals(input.BCountry))
                ) && 
                (
                    this.BCurrency == input.BCurrency ||
                    (this.BCurrency != null &&
                    this.BCurrency.Equals(input.BCurrency))
                ) && 
                (
                    this.TrxValue == input.TrxValue ||
                    (this.TrxValue != null &&
                    this.TrxValue.Equals(input.TrxValue))
                ) && 
                (
                    this.BFirstName == input.BFirstName ||
                    (this.BFirstName != null &&
                    this.BFirstName.Equals(input.BFirstName))
                ) && 
                (
                    this.BLastName == input.BLastName ||
                    (this.BLastName != null &&
                    this.BLastName.Equals(input.BLastName))
                ) && 
                (
                    this.BAccType == input.BAccType ||
                    (this.BAccType != null &&
                    this.BAccType.Equals(input.BAccType))
                ) && 
                (
                    this.BIssuerCode == input.BIssuerCode ||
                    (this.BIssuerCode != null &&
                    this.BIssuerCode.Equals(input.BIssuerCode))
                ) && 
                (
                    this.BankProvince == input.BankProvince ||
                    (this.BankProvince != null &&
                    this.BankProvince.Equals(input.BankProvince))
                ) && 
                (
                    this.BankCity == input.BankCity ||
                    (this.BankCity != null &&
                    this.BankCity.Equals(input.BankCity))
                ) && 
                (
                    this.BankBranchName == input.BankBranchName ||
                    (this.BankBranchName != null &&
                    this.BankBranchName.Equals(input.BankBranchName))
                ) && 
                (
                    this.BankBranchCode == input.BankBranchCode ||
                    (this.BankBranchCode != null &&
                    this.BankBranchCode.Equals(input.BankBranchCode))
                ) && 
                (
                    this.BAccNum == input.BAccNum ||
                    (this.BAccNum != null &&
                    this.BAccNum.Equals(input.BAccNum))
                ) && 
                (
                    this.BIdType == input.BIdType ||
                    (this.BIdType != null &&
                    this.BIdType.Equals(input.BIdType))
                ) && 
                (
                    this.BIdNum == input.BIdNum ||
                    (this.BIdNum != null &&
                    this.BIdNum.Equals(input.BIdNum))
                ) && 
                (
                    this.BContactNum == input.BContactNum ||
                    (this.BContactNum != null &&
                    this.BContactNum.Equals(input.BContactNum))
                ) && 
                (
                    this.Relationship == input.Relationship ||
                    (this.Relationship != null &&
                    this.Relationship.Equals(input.Relationship))
                ) && 
                (
                    this.BAddress == input.BAddress ||
                    (this.BAddress != null &&
                    this.BAddress.Equals(input.BAddress))
                ) && 
                (
                    this.BCity == input.BCity ||
                    (this.BCity != null &&
                    this.BCity.Equals(input.BCity))
                ) && 
                (
                    this.BPostCode == input.BPostCode ||
                    (this.BPostCode != null &&
                    this.BPostCode.Equals(input.BPostCode))
                ) && 
                (
                    this.BEmail == input.BEmail ||
                    (this.BEmail != null &&
                    this.BEmail.Equals(input.BEmail))
                ) && 
                (
                    this.BProvinceCode == input.BProvinceCode ||
                    (this.BProvinceCode != null &&
                    this.BProvinceCode.Equals(input.BProvinceCode))
                ) && 
                (
                    this.BRegencyCode == input.BRegencyCode ||
                    (this.BRegencyCode != null &&
                    this.BRegencyCode.Equals(input.BRegencyCode))
                ) && 
                (
                    this.BPayoutID == input.BPayoutID ||
                    (this.BPayoutID != null &&
                    this.BPayoutID.Equals(input.BPayoutID))
                ) && 
                (
                    this.BPayoutPIN == input.BPayoutPIN ||
                    (this.BPayoutPIN != null &&
                    this.BPayoutPIN.Equals(input.BPayoutPIN))
                ) && 
                (
                    this.SAmount == input.SAmount ||
                    (this.SAmount != null &&
                    this.SAmount.Equals(input.SAmount))
                ) && 
                (
                    this.FRKey == input.FRKey ||
                    (this.FRKey != null &&
                    this.FRKey.Equals(input.FRKey))
                ) && 
                (
                    this.BPurposeCode == input.BPurposeCode ||
                    (this.BPurposeCode != null &&
                    this.BPurposeCode.Equals(input.BPurposeCode))
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
                if (this.UIDBranch != null)
                    hashCode = hashCode * 59 + this.UIDBranch.GetHashCode();
                if (this.TransID != null)
                    hashCode = hashCode * 59 + this.TransID.GetHashCode();
                if (this.SFirstName != null)
                    hashCode = hashCode * 59 + this.SFirstName.GetHashCode();
                if (this.SLastName != null)
                    hashCode = hashCode * 59 + this.SLastName.GetHashCode();
                if (this.SIdType != null)
                    hashCode = hashCode * 59 + this.SIdType.GetHashCode();
                if (this.SIdNum != null)
                    hashCode = hashCode * 59 + this.SIdNum.GetHashCode();
                if (this.SIdExpiry != null)
                    hashCode = hashCode * 59 + this.SIdExpiry.GetHashCode();
                if (this.SContactNum != null)
                    hashCode = hashCode * 59 + this.SContactNum.GetHashCode();
                if (this.SOccupation != null)
                    hashCode = hashCode * 59 + this.SOccupation.GetHashCode();
                if (this.SFundSource != null)
                    hashCode = hashCode * 59 + this.SFundSource.GetHashCode();
                if (this.SBirthDate != null)
                    hashCode = hashCode * 59 + this.SBirthDate.GetHashCode();
                if (this.SEmail != null)
                    hashCode = hashCode * 59 + this.SEmail.GetHashCode();
                if (this.SAddress != null)
                    hashCode = hashCode * 59 + this.SAddress.GetHashCode();
                if (this.SCity != null)
                    hashCode = hashCode * 59 + this.SCity.GetHashCode();
                if (this.SPostCode != null)
                    hashCode = hashCode * 59 + this.SPostCode.GetHashCode();
                if (this.SCountry != null)
                    hashCode = hashCode * 59 + this.SCountry.GetHashCode();
                if (this.SCurrency != null)
                    hashCode = hashCode * 59 + this.SCurrency.GetHashCode();
                if (this.BCountry != null)
                    hashCode = hashCode * 59 + this.BCountry.GetHashCode();
                if (this.BCurrency != null)
                    hashCode = hashCode * 59 + this.BCurrency.GetHashCode();
                if (this.TrxValue != null)
                    hashCode = hashCode * 59 + this.TrxValue.GetHashCode();
                if (this.BFirstName != null)
                    hashCode = hashCode * 59 + this.BFirstName.GetHashCode();
                if (this.BLastName != null)
                    hashCode = hashCode * 59 + this.BLastName.GetHashCode();
                if (this.BAccType != null)
                    hashCode = hashCode * 59 + this.BAccType.GetHashCode();
                if (this.BIssuerCode != null)
                    hashCode = hashCode * 59 + this.BIssuerCode.GetHashCode();
                if (this.BankProvince != null)
                    hashCode = hashCode * 59 + this.BankProvince.GetHashCode();
                if (this.BankCity != null)
                    hashCode = hashCode * 59 + this.BankCity.GetHashCode();
                if (this.BankBranchName != null)
                    hashCode = hashCode * 59 + this.BankBranchName.GetHashCode();
                if (this.BankBranchCode != null)
                    hashCode = hashCode * 59 + this.BankBranchCode.GetHashCode();
                if (this.BAccNum != null)
                    hashCode = hashCode * 59 + this.BAccNum.GetHashCode();
                if (this.BIdType != null)
                    hashCode = hashCode * 59 + this.BIdType.GetHashCode();
                if (this.BIdNum != null)
                    hashCode = hashCode * 59 + this.BIdNum.GetHashCode();
                if (this.BContactNum != null)
                    hashCode = hashCode * 59 + this.BContactNum.GetHashCode();
                if (this.Relationship != null)
                    hashCode = hashCode * 59 + this.Relationship.GetHashCode();
                if (this.BAddress != null)
                    hashCode = hashCode * 59 + this.BAddress.GetHashCode();
                if (this.BCity != null)
                    hashCode = hashCode * 59 + this.BCity.GetHashCode();
                if (this.BPostCode != null)
                    hashCode = hashCode * 59 + this.BPostCode.GetHashCode();
                if (this.BEmail != null)
                    hashCode = hashCode * 59 + this.BEmail.GetHashCode();
                if (this.BProvinceCode != null)
                    hashCode = hashCode * 59 + this.BProvinceCode.GetHashCode();
                if (this.BRegencyCode != null)
                    hashCode = hashCode * 59 + this.BRegencyCode.GetHashCode();
                if (this.BPayoutID != null)
                    hashCode = hashCode * 59 + this.BPayoutID.GetHashCode();
                if (this.BPayoutPIN != null)
                    hashCode = hashCode * 59 + this.BPayoutPIN.GetHashCode();
                if (this.SAmount != null)
                    hashCode = hashCode * 59 + this.SAmount.GetHashCode();
                if (this.FRKey != null)
                    hashCode = hashCode * 59 + this.FRKey.GetHashCode();
                if (this.BPurposeCode != null)
                    hashCode = hashCode * 59 + this.BPurposeCode.GetHashCode();
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
