using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class CustomerDeltum
    {
        /// <summary>
        /// Code Company
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Code Organization
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// Master no of client
        /// </summary>
        public string NoMaster { get; set; }
        /// <summary>
        /// CIF Number
        /// </summary>
        public string NoCif { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string InfoNameFull { get; set; }
        /// <summary>
        /// Native Name
        /// </summary>
        public string InfoNameNative { get; set; }
        /// <summary>
        /// First Name
        /// </summary>
        public string InfoNameFirst { get; set; }
        /// <summary>
        /// Middle Name
        /// </summary>
        public string InfoNameMid { get; set; }
        /// <summary>
        /// Last Name
        /// </summary>
        public string InfoNameLast { get; set; }
        /// <summary>
        /// CIF Status
        /// </summary>
        public int? CifStatus { get; set; }
        /// <summary>
        /// CIF Issue Place
        /// </summary>
        public string CifIplace { get; set; }
        /// <summary>
        /// Joint Status
        /// </summary>
        public int? CifJoint { get; set; }
        /// <summary>
        /// CIF Creation Date [HOST]
        /// </summary>
        public int? CifDateCreate { get; set; }
        /// <summary>
        /// CIF Updated Date [HOST]
        /// </summary>
        public int? CifDateUpdate { get; set; }
        /// <summary>
        /// System Current Level
        /// </summary>
        public int? RiskNew { get; set; }
        /// <summary>
        /// System Previous Level
        /// </summary>
        public int? RiskPrev { get; set; }
        /// <summary>
        /// Manual Level
        /// </summary>
        public int? RiskManual { get; set; }
        /// <summary>
        /// Host Level
        /// </summary>
        public int? RiskHost { get; set; }
        /// <summary>
        /// Entity Type (Individual/Corporate)
        /// </summary>
        public int? InfoType { get; set; }
        /// <summary>
        /// ID Type
        /// </summary>
        public int? Id1Type { get; set; }
        /// <summary>
        /// ID Number (IC/ Biz Reg No.)
        /// </summary>
        public string Id1No { get; set; }
        /// <summary>
        /// ID Issue Date
        /// </summary>
        public int? Id1Idate { get; set; }
        /// <summary>
        /// ID Verify Date
        /// </summary>
        public int? Id1Vdate { get; set; }
        /// <summary>
        /// ID Issue Place
        /// </summary>
        public string Id1Iplace { get; set; }
        /// <summary>
        /// ID Expiry Date
        /// </summary>
        public int? Id1Edate { get; set; }
        /// <summary>
        /// Secondary ID Type
        /// </summary>
        public int? Id2Type { get; set; }
        /// <summary>
        /// Secondary ID Number
        /// </summary>
        public string Id2No { get; set; }
        /// <summary>
        /// Secondary ID Issue Date
        /// </summary>
        public int? Id2Idate { get; set; }
        /// <summary>
        /// Secondary ID Verify Date
        /// </summary>
        public int? Id2Vdate { get; set; }
        /// <summary>
        /// Secondary ID Issue Place
        /// </summary>
        public string Id2Iplace { get; set; }
        /// <summary>
        /// Secondary ID Expiry Date
        /// </summary>
        public int? Id2Edate { get; set; }
        /// <summary>
        /// Nationality
        /// </summary>
        public string InfoNat { get; set; }
        /// <summary>
        /// Residence
        /// </summary>
        public string InfoRes { get; set; }
        /// <summary>
        /// Age
        /// </summary>
        public int? InfoAge { get; set; }
        /// <summary>
        /// Date of Birth
        /// </summary>
        public int? IndoDob { get; set; }
        /// <summary>
        /// Gender
        /// </summary>
        public int? InfoGen { get; set; }
        /// <summary>
        /// Marital Status
        /// </summary>
        public int? InfoMarry { get; set; }
        /// <summary>
        /// Home  Number
        /// </summary>
        public int? ConHome { get; set; }
        /// <summary>
        /// Mobile Number
        /// </summary>
        public int? ConMobile { get; set; }
        /// <summary>
        /// Office Number
        /// </summary>
        public int? ConOffice { get; set; }
        /// <summary>
        /// Email Address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Race
        /// </summary>
        public string InfoRace { get; set; }
        /// <summary>
        /// Religion
        /// </summary>
        public string InfoReli { get; set; }
        /// <summary>
        /// Education Level
        /// </summary>
        public string InfoEdu { get; set; }
        /// <summary>
        /// Primary Language
        /// </summary>
        public string InfoLang { get; set; }
        /// <summary>
        /// Occupation
        /// </summary>
        public string InfoOcc { get; set; }
        /// <summary>
        /// Occupation/Industry Sector
        /// </summary>
        public string InfoOsect { get; set; }
        /// <summary>
        /// Occupation Year
        /// </summary>
        public string InfoOyear { get; set; }
        /// <summary>
        /// Business Line
        /// </summary>
        public string InfoBline { get; set; }
        /// <summary>
        /// Business/industry Sector
        /// </summary>
        public string InfoBsect { get; set; }
        /// <summary>
        /// Source of Fund
        /// </summary>
        public string InfoSof { get; set; }
        /// <summary>
        /// Annual Income Range
        /// </summary>
        public string InfoIcome { get; set; }
        /// <summary>
        /// Agent Code
        /// </summary>
        public string InfoAgent { get; set; }
        /// <summary>
        /// Death Date
        /// </summary>
        public string InfoDdate { get; set; }
        /// <summary>
        /// Address Line 1
        /// </summary>
        public string AddL1 { get; set; }
        /// <summary>
        /// Postcode
        /// </summary>
        public string AddPcode { get; set; }
        /// <summary>
        /// Address Line 2
        /// </summary>
        public string AddL2 { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public string AddCity { get; set; }
        /// <summary>
        /// Address Line 3
        /// </summary>
        public string AddL3 { get; set; }
        /// <summary>
        /// State
        /// </summary>
        public string AddState { get; set; }
        /// <summary>
        /// Address Line 4
        /// </summary>
        public string AddL4 { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public string AddCountry { get; set; }
        /// <summary>
        /// Staff Flag
        /// </summary>
        public int? FlagStaff { get; set; }
        /// <summary>
        /// E-KYC Flag
        /// </summary>
        public int? FlagEkyc { get; set; }
        /// <summary>
        /// Investigation Flag (STR)
        /// </summary>
        public int? FlagStr { get; set; }
        /// <summary>
        /// Watchlist Hit Flag
        /// </summary>
        public int? FlagWlist { get; set; }
        /// <summary>
        /// HNW Flag
        /// </summary>
        public int? FlatHnw { get; set; }
        /// <summary>
        /// Blacklist Flag
        /// </summary>
        public int? FlagBlist { get; set; }
        /// <summary>
        /// Legal Flag
        /// </summary>
        public int? FlagLegal { get; set; }
        /// <summary>
        /// PEP Flag
        /// </summary>
        public int? FlagPep { get; set; }
        /// <summary>
        /// CRS Flag
        /// </summary>
        public int? FlagCrs { get; set; }
        /// <summary>
        /// SOC Flag
        /// </summary>
        public int? FlagSoc { get; set; }
        /// <summary>
        /// PDPA Flag
        /// </summary>
        public int? FlagPdpa { get; set; }
        /// <summary>
        /// FI/Non-FI Flag
        /// </summary>
        public int? FlagFi { get; set; }
        /// <summary>
        /// Bumi Flag
        /// </summary>
        public int? FlagBumi { get; set; }
        /// <summary>
        /// Other Flag
        /// </summary>
        public int? FlagOther { get; set; }
        /// <summary>
        /// False Positive Flag
        /// </summary>
        public int? FlagFpos { get; set; }
        /// <summary>
        /// False Positive Date
        /// </summary>
        public int? FposDate { get; set; }
        /// <summary>
        /// Employer Name
        /// </summary>
        public string EmpName { get; set; }
        /// <summary>
        /// Year Employed
        /// </summary>
        public int? EmpYear { get; set; }
        /// <summary>
        /// Address Line 1
        /// </summary>
        public string EmpAdd1 { get; set; }
        /// <summary>
        /// Postcode
        /// </summary>
        public string EmpPcode { get; set; }
        /// <summary>
        /// Address Line 2
        /// </summary>
        public string EmpAdd2 { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public string EmpCity { get; set; }
        /// <summary>
        /// Address Line 3
        /// </summary>
        public string EmpAdd3 { get; set; }
        /// <summary>
        /// State
        /// </summary>
        public string EmpState { get; set; }
        /// <summary>
        /// Address Line 4
        /// </summary>
        public string EmpAdd4 { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public string EmpCountry { get; set; }
        /// <summary>
        /// Fatca Flag
        /// </summary>
        public int? FlagFatca { get; set; }
        /// <summary>
        /// Tin Number
        /// </summary>
        public string FatcaNo { get; set; }
        public string DataValue01 { get; set; }
        public string DataValue02 { get; set; }
        public string DataValue03 { get; set; }
        public string DataValue04 { get; set; }
        public string DataValue05 { get; set; }
        public string DataValue06 { get; set; }
        public string DataValue07 { get; set; }
        public string DataValue08 { get; set; }
        public string DataValue09 { get; set; }
        public string DataValue10 { get; set; }
        public string DataValue11 { get; set; }
        public string DataValue12 { get; set; }
        public string DataValue13 { get; set; }
        public string DataValue14 { get; set; }
        public string DataValue15 { get; set; }
        public string DataValue16 { get; set; }
        public string DataValue17 { get; set; }
        public string DataValue18 { get; set; }
        public string DataValue19 { get; set; }
        public string DataValue20 { get; set; }
        public string DataValue21 { get; set; }
        public string DataValue22 { get; set; }
        public string DataValue23 { get; set; }
        public string DataValue24 { get; set; }
        public string DataValue25 { get; set; }
        public string DataValue26 { get; set; }
        public string DataValue27 { get; set; }
        public string DataValue28 { get; set; }
        public string DataValue29 { get; set; }
        public string DataValue30 { get; set; }
        public string DataValue31 { get; set; }
        public string DataValue32 { get; set; }
        public string DataValue33 { get; set; }
        public string DataValue34 { get; set; }
        public string DataValue35 { get; set; }
        public string DataValue36 { get; set; }
        public string DataValue37 { get; set; }
        public string DataValue38 { get; set; }
        public string DataValue39 { get; set; }
        public string DataValue40 { get; set; }
        public string DataValue41 { get; set; }
        public string DataValue42 { get; set; }
        public string DataValue43 { get; set; }
        public string DataValue44 { get; set; }
        public string DataValue45 { get; set; }
        public string DataValue46 { get; set; }
        public string DataValue47 { get; set; }
        public string DataValue48 { get; set; }
        public string DataValue49 { get; set; }
        public string DataValue50 { get; set; }
        public string DataValue51 { get; set; }
        public string DataValue52 { get; set; }
        public string DataValue53 { get; set; }
        public string DataValue54 { get; set; }
        public string DataValue55 { get; set; }
        public int? BatchDate { get; set; }
        public string BatchNo { get; set; }
        /// <summary>
        /// Date creation
        /// </summary>
        public DateTime AuditCreatedDate { get; set; }
        /// <summary>
        /// User who create
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who updating
        /// </summary>
        public string AuditUpdatedUser { get; set; }
        /// <summary>
        /// Flag to indicate this NO_MASTER is primary
        /// </summary>
        public int FlagPrime { get; set; }
        /// <summary>
        /// Risk score computed by system
        /// </summary>
        public int RiskScore { get; set; }
        /// <summary>
        /// Date on merging cif
        /// </summary>
        public DateTime AuditMergedDate { get; set; }
    }
}
