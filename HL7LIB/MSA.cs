using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7LIB.ConcretcompositeType
{
    /// <summary>
    /// 消息回复
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class MSA : compositeSegment
    {
        public MSA(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[6];
            data[0] = new ID("AcknowledgmentCode");
            data[1] = new ST("MessageControlID");
            data[2] = new ST("TextMessage");
            data[3] = new NM("ExpectedSequenceNumber");
            data[4] = new ID("DelayedAcknowledgmentType");
            data[5] = new CE(this, "ErrorCondition");
        }
        public ID AcknowledgmentCode { get { return data[0] as ID; } set { data[0] = value; } }
        public ST MessageControlID { get { return data[1] as ST; } set { data[1] = value; } }
        public ST TextMessage { get { return data[2] as ST; } set { data[2] = value; } }
        public NM ExpectedSequenceNumber { get { return data[3] as NM; } set { data[3] = value; } }
        public ID DelayedAcknowledgmentType { get { return data[4] as ID; } set { data[4] = value; } }
        public CE ErrorCondition { get { return data[5] as CE; } set { data[5] = value; } }
    }
    /// <summary>
    /// 消息头段
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class MSH : compositeSegment
    {
        public MSH(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[21];
            data[0] = new ST("FieldSeparator");
            data[1] = new ST("EncodingCharacters");
            data[2] = new HD(this, "SendingApplication");
            data[3] = new HD(this, "SendingFacility");
            data[4] = new HD(this, "ReceivingApplication");
            data[5] = new HD(this, "ReceivingFacility");
            data[6] = new TS("DateOrTimeOfMessage");
            data[7] = new ST("Security");
            data[8] = new MSG(this, "MessageType");
            data[9] = new ST("MessageControlID");
            data[10] = new PT(this, "ProcessingID");
            data[11] = new VID(this, "VersionID");
            data[12] = new NM("SequenceNumber");
            data[13] = new ST("ContinuationPointer");
            data[14] = new ID("AcceptAcknowledgmentType");
            data[15] = new ID("ApplicationAcknowledgmentType");
            data[16] = new ID("CountryCode");
            data[17] = new ID("CharacterSet");
            data[18] = new CE(this, "PrincipalLanguageOfMessage");
            data[19] = new ID("AlternateCharacterSetHandlingScheme");
            data[20] = new EI(this, "MessageProfileIdentifier");
        }
        public ST FieldSeparator { get { return data[0] as ST; } set { data[0] = value; } }
        public ST EncodingCharacters { get { return data[1] as ST; } set { data[1] = value; } }
        public HD SendingApplication { get { return data[2] as HD; } set { data[2] = value; } }
        public HD SendingFacility { get { return data[3] as HD; } set { data[3] = value; } }
        public HD ReceivingApplication { get { return data[4] as HD; } set { data[4] = value; } }
        public HD ReceivingFacility { get { return data[5] as HD; } set { data[5] = value; } }
        public TS DateOrTimeOfMessage { get { return data[6] as TS; } set { data[6] = value; } }
        public ST Security { get { return data[7] as ST; } set { data[7] = value; } }
        public MSG MessageType { get { return data[8] as MSG; } set { data[8] = value; } }
        public ST MessageControlID { get { return data[9] as ST; } set { data[9] = value; } }
        public PT ProcessingID { get { return data[10] as PT; } set { data[10] = value; } }
        public VID VersionID { get { return data[11] as VID; } set { data[11] = value; } }
        public NM SequenceNumber { get { return data[12] as NM; } set { data[12] = value; } }
        public ST ContinuationPointer { get { return data[13] as ST; } set { data[13] = value; } }
        public ID AcceptAcknowledgmentType { get { return data[14] as ID; } set { data[14] = value; } }
        public ID ApplicationAcknowledgmentType { get { return data[15] as ID; } set { data[15] = value; } }
        public ID CountryCode { get { return data[16] as ID; } set { data[16] = value; } }
        public ID CharacterSet { get { return data[17] as ID; } set { data[17] = value; } }
        public CE PrincipalLanguageOfMessage { get { return data[18] as CE; } set { data[18] = value; } }
        public ID AlternateCharacterSetHandlingScheme { get { return data[19] as ID; } set { data[19] = value; } }
        public EI MessageProfileIdentifier { get { return data[20] as EI; } set { data[20] = value; } }
    }
    /// <summary>
    /// Patient Identification
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class PID : compositeSegment
    {
        public PID(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[39];
            data[0] = new SI("SetIDPID");
            data[1] = new CX(this, "PatientID");
            data[2] = new CX(this, "PatientIdentifierList");
            data[3] = new CX(this, "AlternatePatientIDPID");
            data[4] = new XPN(this, "PatientName");
            data[5] = new XPN(this, "Mother_sMaidenName");
            data[6] = new TS("DateOrTimeofBirth");
            data[7] = new IS("AdministrativeSex");
            data[8] = new XPN(this, "PatientAlias");
            data[9] = new CE(this, "Race");
            data[10] = new XAD(this, "PatientAddress");
            data[11] = new IS("CountyCode");
            data[12] = new XTN(this, "PhoneNumberHome");
            data[13] = new XTN(this, "PhoneNumberBusiness");
            data[14] = new CE(this, "PrimaryLanguage");
            data[15] = new CE(this, "MaritalStatus");
            data[16] = new CE(this, "Religion");
            data[17] = new CX(this, "PatientAccountNumber");
            data[18] = new ST("SSNNumberPatient");
            data[19] = new DLN(this, "DriverLicenseNumberPatient");
            data[20] = new CX(this, "MotherIdentifier");
            data[21] = new CE(this, "EthnicGroup");
            data[22] = new ST("BirthPlace");
            data[23] = new ID("MultipleBirthIndicator");
            data[24] = new NM("BirthOrder");
            data[25] = new CE(this, "Citizenship");
            data[26] = new CE(this, "VeteransMilitaryStatus");
            data[27] = new CE(this, "Nationality");
            data[28] = new TS("PatientDeathDateandTime");
            data[29] = new ID("PatientDeathIndicator");
            data[30] = new ID("IdentityUnknownIndicator");
            data[31] = new IS("IdentityReliabilityCode");
            data[32] = new TS("LastUpdateDateOrTime");
            data[33] = new HD(this, "LastUpdateFacility");
            data[34] = new CE(this, "SpeciesCode");
            data[35] = new CE(this, "BreedCode");
            data[36] = new ST("Strain");
            data[37] = new CE(this, "ProductionClassCode");
            data[38] = new CWE(this, "TribalCitizenship");
        }
        public SI SetIDPID { get { return data[0] as SI; } set { data[0] = value; } }
        public CX PatientID { get { return data[1] as CX; } set { data[1] = value; } }
        public CX PatientIdentifierList { get { return data[2] as CX; } set { data[2] = value; } }
        public CX AlternatePatientIDPID { get { return data[3] as CX; } set { data[3] = value; } }
        public XPN PatientName { get { return data[4] as XPN; } set { data[4] = value; } }
        public XPN Mother_sMaidenName { get { return data[5] as XPN; } set { data[5] = value; } }
        public TS DateOrTimeofBirth { get { return data[6] as TS; } set { data[6] = value; } }
        public IS AdministrativeSex { get { return data[7] as IS; } set { data[7] = value; } }
        public XPN PatientAlias { get { return data[8] as XPN; } set { data[8] = value; } }
        public CE Race { get { return data[9] as CE; } set { data[9] = value; } }
        public XAD PatientAddress { get { return data[10] as XAD; } set { data[10] = value; } }
        public IS CountyCode { get { return data[11] as IS; } set { data[11] = value; } }
        public XTN PhoneNumberHome { get { return data[12] as XTN; } set { data[12] = value; } }
        public XTN PhoneNumberBusiness { get { return data[13] as XTN; } set { data[13] = value; } }
        public CE PrimaryLanguage { get { return data[14] as CE; } set { data[14] = value; } }
        public CE MaritalStatus { get { return data[15] as CE; } set { data[15] = value; } }
        public CE Religion { get { return data[16] as CE; } set { data[16] = value; } }
        public CX PatientAccountNumber { get { return data[17] as CX; } set { data[17] = value; } }
        public ST SSNNumberPatient { get { return data[18] as ST; } set { data[18] = value; } }
        public DLN DriverLicenseNumberPatient { get { return data[19] as DLN; } set { data[19] = value; } }
        public CX MotherIdentifier { get { return data[20] as CX; } set { data[20] = value; } }
        public CE EthnicGroup { get { return data[21] as CE; } set { data[21] = value; } }
        public ST BirthPlace { get { return data[22] as ST; } set { data[22] = value; } }
        public ID MultipleBirthIndicator { get { return data[23] as ID; } set { data[23] = value; } }
        public NM BirthOrder { get { return data[24] as NM; } set { data[24] = value; } }
        public CE Citizenship { get { return data[25] as CE; } set { data[25] = value; } }
        public CE VeteransMilitaryStatus { get { return data[26] as CE; } set { data[26] = value; } }
        public CE Nationality { get { return data[27] as CE; } set { data[27] = value; } }
        public TS PatientDeathDateandTime { get { return data[28] as TS; } set { data[28] = value; } }
        public ID PatientDeathIndicator { get { return data[29] as ID; } set { data[29] = value; } }
        public ID IdentityUnknownIndicator { get { return data[30] as ID; } set { data[30] = value; } }
        public IS IdentityReliabilityCode { get { return data[31] as IS; } set { data[31] = value; } }
        public TS LastUpdateDateOrTime { get { return data[32] as TS; } set { data[32] = value; } }
        public HD LastUpdateFacility { get { return data[33] as HD; } set { data[33] = value; } }
        public CE SpeciesCode { get { return data[34] as CE; } set { data[34] = value; } }
        public CE BreedCode { get { return data[35] as CE; } set { data[35] = value; } }
        public ST Strain { get { return data[36] as ST; } set { data[36] = value; } }
        public CE ProductionClassCode { get { return data[37] as CE; } set { data[37] = value; } }
        public CWE TribalCitizenship { get { return data[38] as CWE; } set { data[38] = value; } }
    }
    /// <summary>
    /// 错误类型段
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class ERR : compositeSegment
    {
        public ERR(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[11];
            data[0] = new ELD(this, "ErrorCodeandLocation");
            data[1] = new ERL(this, "ErrorLocation");
            data[2] = new ID("Severity");
            data[3] = new CWE(this, "ApplicationErrorCode");
            data[4] = new ST("ApplicationErrorParameter");
            data[5] = new TX("DiagnosticInformation");
            data[6] = new TX("UserMessage");
            data[7] = new IS("InformPersonIndicator");
            data[8] = new CWE(this, "OverrideType");
            data[9] = new CWE(this, "OverrideReasonCode");
            data[10] = new XTN(this, "HelpDeskContactPoint");
        }
        public ELD ErrorCodeandLocation { get { return data[0] as ELD; } set { data[0] = value; } }
        public ERL ErrorLocation { get { return data[1] as ERL; } set { data[1] = value; } }
        public ID Severity { get { return data[2] as ID; } set { data[2] = value; } }
        public CWE ApplicationErrorCode { get { return data[3] as CWE; } set { data[3] = value; } }
        public ST ApplicationErrorParameter { get { return data[4] as ST; } set { data[4] = value; } }
        public TX DiagnosticInformation { get { return data[5] as TX; } set { data[5] = value; } }
        public TX UserMessage { get { return data[6] as TX; } set { data[6] = value; } }
        public IS InformPersonIndicator { get { return data[7] as IS; } set { data[7] = value; } }
        public CWE OverrideType { get { return data[8] as CWE; } set { data[8] = value; } }
        public CWE OverrideReasonCode { get { return data[9] as CWE; } set { data[9] = value; } }
        public XTN HelpDeskContactPoint { get { return data[10] as XTN; } set { data[10] = value; } }
    }
    /// <summary>
    /// Notes and Comments (for Header)
    /// NTE段接在 OBR段（或者是请求细节描述段）后，或者接在一般 ORU消息的 OBX段 后
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class NTE : compositeSegment
    {
        public NTE(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[4];
            data[0] = new SI("SetIDNTE");
            data[1] = new ID("SourceofComment");
            data[2] = new FT("Comment");
            data[3] = new CE(this, "CommentType");
        }
        public SI SetIDNTE { get { return data[0] as SI; } set { data[0] = value; } }
        public ID SourceofComment { get { return data[1] as ID; } set { data[1] = value; } }
        public FT Comment { get { return data[2] as FT; } set { data[2] = value; } }
        public CE CommentType { get { return data[3] as CE; } set { data[3] = value; } }
    }
    /// <summary>
    ///  Additional Demographics,其他信息
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class PD1 : compositeSegment
    {
        public PD1(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[12];
            data[0] = new IS("LivingDependency");
            data[1] = new IS("LivingArrangement");
            data[2] = new XON(this, "PatientPrimaryFacility");
            data[3] = new XCN(this, "PatientPrimaryCareProviderNameandIDNumber");
            data[4] = new IS("StudentIndicator");
            data[5] = new IS("Handicap");
            data[6] = new IS("LivingWill");
            data[7] = new IS("OrganDonor");
            data[8] = new ID("SeparateBill");
            data[9] = new CX(this, "DuplicatePatient");
            data[10] = new CE(this, "PublicityCode");
            data[11] = new ID("ProtectionIndicator");
        }
        public IS LivingDependency { get { return data[0] as IS; } set { data[0] = value; } }
        public IS LivingArrangement { get { return data[1] as IS; } set { data[1] = value; } }
        public XON PatientPrimaryFacility { get { return data[2] as XON; } set { data[2] = value; } }
        public XCN PatientPrimaryCareProviderNameandIDNumber { get { return data[3] as XCN; } set { data[3] = value; } }
        public IS StudentIndicator { get { return data[4] as IS; } set { data[4] = value; } }
        public IS Handicap { get { return data[5] as IS; } set { data[5] = value; } }
        public IS LivingWill { get { return data[6] as IS; } set { data[6] = value; } }
        public IS OrganDonor { get { return data[7] as IS; } set { data[7] = value; } }
        public ID SeparateBill { get { return data[8] as ID; } set { data[8] = value; } }
        public CX DuplicatePatient { get { return data[9] as CX; } set { data[9] = value; } }
        public CE PublicityCode { get { return data[10] as CE; } set { data[10] = value; } }
        public ID ProtectionIndicator { get { return data[11] as ID; } set { data[11] = value; } }
    }
    /// <summary>
    ///Patient Visit
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class PV1 : compositeSegment
    {
        public PV1(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[51];
            data[0] = new IS("PatientClass");
            data[1] = new PL(this,"AssignedPatientLocation");
            data[2] = new IS("AdmissionType");
            data[3] = new CX(this,"PreadmitNumber");
            data[4] = new PL(this,"PriorPatientLocation");
            data[5] = new XCN(this,"AttendingDoctor");
            data[6] = new XCN(this,"ReferringDoctor");
            data[7] = new XCN(this,"ConsultingDoctor");
            data[8] = new IS("HospitalService");
            data[9] = new PL(this,"TemporaryLocation");
            data[10] = new IS("PreadmitTestIndicator");
            data[11] = new IS("ReadmissionIndicator");
            data[12] = new IS("AdmitSource");
            data[13] = new IS("AmbulatoryStatus");
            data[14] = new IS("VIPIndicator");
            data[15] = new XCN(this,"AdmittingDoctor");
            data[16] = new IS("PatientType");
            data[17] = new CX(this,"VisitNumber");
            data[18] = new FC(this,"FinancialClass");
            data[19] = new IS("ChargePriceIndicator");
            data[20] = new IS("CourtesyCode");
            data[21] = new IS("CreditRating");
            data[22] = new IS("ContractCode");
            data[23] = new DT("ContractEffectiveDate");
            data[24] = new NM("ContractAmount");
            data[25] = new NM("ContractPeriod");
            data[26] = new IS("InterestCode");
            data[27] = new IS("TransfertoBadDebtCode");
            data[28] = new DT("TransfertoBadDebtDate");
            data[29] = new IS("BadDebtAgencyCode");
            data[30] = new NM("BadDebtTransferAmount");
            data[31] = new NM("BadDebtRecoveryAmount");
            data[32] = new IS("DeleteAccountIndicator");
            data[33] = new DT("DeleteAccountDate");
            data[34] = new IS("DischargeDisposition");
            data[35] = new CM(this,"DischargedtoLocation");
            data[36] = new CE(this,"DietType");
            data[37] = new IS("ServicingFacility");
            data[38] = new IS("BedStatus");
            data[39] = new IS("AccountStatus");
            data[40] = new PL(this,"PendingLocation");
            data[41] = new PL(this,"PriorTemporaryLocation");
            data[42] = new TS("AdmitDateOrTime");
            data[43] = new TS("DischargeDateOrTime");
            data[44] = new NM("CurrentPatientBalance");
            data[45] = new NM("TotalCharges");
            data[46] = new NM("TotalAdjustments");
            data[47] = new NM("TotalPayments");
            data[48] = new CX(this,"AlternateVisitID");
            data[49] = new IS("VisitIndicator");
            data[50] = new XCN(this,"OtherHealthcareProvider");
        }
        public IS PatientClass { get { return data[0] as IS; } set { data[0] = value; } }
        public PL AssignedPatientLocation { get { return data[1] as PL; } set { data[1] = value; } }
        public IS AdmissionType { get { return data[2] as IS; } set { data[2] = value; } }
        public CX PreadmitNumber { get { return data[3] as CX; } set { data[3] = value; } }
        public PL PriorPatientLocation { get { return data[4] as PL; } set { data[4] = value; } }
        public XCN AttendingDoctor { get { return data[5] as XCN; } set { data[5] = value; } }
        public XCN ReferringDoctor { get { return data[6] as XCN; } set { data[6] = value; } }
        public XCN ConsultingDoctor { get { return data[7] as XCN; } set { data[7] = value; } }
        public IS HospitalService { get { return data[8] as IS; } set { data[8] = value; } }
        public PL TemporaryLocation { get { return data[9] as PL; } set { data[9] = value; } }
        public IS PreadmitTestIndicator { get { return data[10] as IS; } set { data[10] = value; } }
        public IS ReadmissionIndicator { get { return data[11] as IS; } set { data[11] = value; } }
        public IS AdmitSource { get { return data[12] as IS; } set { data[12] = value; } }
        public IS AmbulatoryStatus { get { return data[13] as IS; } set { data[13] = value; } }
        public IS VIPIndicator { get { return data[14] as IS; } set { data[14] = value; } }
        public XCN AdmittingDoctor { get { return data[15] as XCN; } set { data[15] = value; } }
        public IS PatientType { get { return data[16] as IS; } set { data[16] = value; } }
        public CX VisitNumber { get { return data[17] as CX; } set { data[17] = value; } }
        public FC FinancialClass { get { return data[18] as FC; } set { data[18] = value; } }
        public IS ChargePriceIndicator { get { return data[19] as IS; } set { data[19] = value; } }
        public IS CourtesyCode { get { return data[20] as IS; } set { data[20] = value; } }
        public IS CreditRating { get { return data[21] as IS; } set { data[21] = value; } }
        public IS ContractCode { get { return data[22] as IS; } set { data[22] = value; } }
        public DT ContractEffectiveDate { get { return data[23] as DT; } set { data[23] = value; } }
        public NM ContractAmount { get { return data[24] as NM; } set { data[24] = value; } }
        public NM ContractPeriod { get { return data[25] as NM; } set { data[25] = value; } }
        public IS InterestCode { get { return data[26] as IS; } set { data[26] = value; } }
        public IS TransfertoBadDebtCode { get { return data[27] as IS; } set { data[27] = value; } }
        public DT TransfertoBadDebtDate { get { return data[28] as DT; } set { data[28] = value; } }
        public IS BadDebtAgencyCode { get { return data[29] as IS; } set { data[29] = value; } }
        public NM BadDebtTransferAmount { get { return data[30] as NM; } set { data[30] = value; } }
        public NM BadDebtRecoveryAmount { get { return data[31] as NM; } set { data[31] = value; } }
        public IS DeleteAccountIndicator { get { return data[32] as IS; } set { data[32] = value; } }
        public DT DeleteAccountDate { get { return data[33] as DT; } set { data[33] = value; } }
        public IS DischargeDisposition { get { return data[34] as IS; } set { data[34] = value; } }
        public CM DischargedtoLocation { get { return data[35] as CM; } set { data[35] = value; } }
        public CE DietType { get { return data[36] as CE; } set { data[36] = value; } }
        public IS ServicingFacility { get { return data[37] as IS; } set { data[37] = value; } }
        public IS BedStatus { get { return data[38] as IS; } set { data[38] = value; } }
        public IS AccountStatus { get { return data[39] as IS; } set { data[39] = value; } }
        public PL PendingLocation { get { return data[40] as PL; } set { data[40] = value; } }
        public PL PriorTemporaryLocation { get { return data[41] as PL; } set { data[41] = value; } }
        public TS AdmitDateOrTime { get { return data[42] as TS; } set { data[42] = value; } }
        public TS DischargeDateOrTime { get { return data[43] as TS; } set { data[43] = value; } }
        public NM CurrentPatientBalance { get { return data[44] as NM; } set { data[44] = value; } }
        public NM TotalCharges { get { return data[45] as NM; } set { data[45] = value; } }
        public NM TotalAdjustments { get { return data[46] as NM; } set { data[46] = value; } }
        public NM TotalPayments { get { return data[47] as NM; } set { data[47] = value; } }
        public CX AlternateVisitID { get { return data[48] as CX; } set { data[48] = value; } }
        public IS VisitIndicator { get { return data[49] as IS; } set { data[49] = value; } }
        public XCN OtherHealthcareProvider { get { return data[50] as XCN; } set { data[50] = value; } }
    }
    /// <summary>
    /// PV2 : patient visit - additional information segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class PV2 : compositeSegment
    {
        public PV2(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[37];
            data[0] = new PL(this,"PriorPendingLocation");
            data[1] = new CE(this,"AccommodationCode");
            data[2] = new CE(this,"AdmitReason");
            data[3] = new CE(this,"TransferReason");
            data[4] = new ST("PatientValuables");
            data[5] = new ST("PatientValuablesLocation");
            data[6] = new IS("VisitUserCode");
            data[7] = new TS("ExpectedAdmitDateOrTime");
            data[8] = new TS("ExpectedDischargeDateOrTime");
            data[9] = new NM("EstimatedLengthofInpatientStay");
            data[10] = new NM("ActualLengthofInpatientStay");
            data[11] = new ST("VisitDescription");
            data[12] = new XCN(this,"ReferralSourceCode");
            data[13] = new DT("PreviousServiceDate");
            data[14] = new ID("RetentionIndicator");
            data[15] = new ID("EmploymentIllnessRelatedIndicator");
            data[16] = new IS("PurgeStatusCode");
            data[17] = new DT("PurgeStatusDate");
            data[18] = new IS("SpecialProgramCode");
            data[19] = new NM("ExpectedNumberofInsurancePlans");
            data[20] = new IS("VisitPublicityCode");
            data[21] = new ID("VisitProtectionIndicator");
            data[22] = new XON(this,"ClinicOrganizationName");
            data[23] = new IS("PatientStatusCode");
            data[24] = new IS("VisitPriorityCode");
            data[25] = new DT("PreviousTreatmentDate");
            data[26] = new IS("ExpectedDischargeDisposition");
            data[27] = new DT("SignatureonFileDate");
            data[28] = new DT("FirstSimilarIllnessDate");
            data[29] = new CE(this,"PatientChargeAdjustmentCode");
            data[30] = new IS("RecurringServiceCode");
            data[31] = new ID("BillingMediaCode");
            data[32] = new TS("ExpectedSurgeryDateandTime");
            data[33] = new ID("MilitaryPartnershipCode");
            data[34] = new ID("MilitaryNonAvailabilityCode");
            data[35] = new ID("NewbornBabyIndicator");
            data[36] = new ID("BabyDetainedIndicator");
        }
        public PL PriorPendingLocation { get { return data[0] as PL; } set { data[0] = value; } }
        public CE AccommodationCode { get { return data[1] as CE; } set { data[1] = value; } }
        public CE AdmitReason { get { return data[2] as CE; } set { data[2] = value; } }
        public CE TransferReason { get { return data[3] as CE; } set { data[3] = value; } }
        public ST PatientValuables { get { return data[4] as ST; } set { data[4] = value; } }
        public ST PatientValuablesLocation { get { return data[5] as ST; } set { data[5] = value; } }
        public IS VisitUserCode { get { return data[6] as IS; } set { data[6] = value; } }
        public TS ExpectedAdmitDateOrTime { get { return data[7] as TS; } set { data[7] = value; } }
        public TS ExpectedDischargeDateOrTime { get { return data[8] as TS; } set { data[8] = value; } }
        public NM EstimatedLengthofInpatientStay { get { return data[9] as NM; } set { data[9] = value; } }
        public NM ActualLengthofInpatientStay { get { return data[10] as NM; } set { data[10] = value; } }
        public ST VisitDescription { get { return data[11] as ST; } set { data[11] = value; } }
        public XCN ReferralSourceCode { get { return data[12] as XCN; } set { data[12] = value; } }
        public DT PreviousServiceDate { get { return data[13] as DT; } set { data[13] = value; } }
        public ID RetentionIndicator { get { return data[14] as ID; } set { data[14] = value; } }
        public ID EmploymentIllnessRelatedIndicator { get { return data[15] as ID; } set { data[15] = value; } }
        public IS PurgeStatusCode { get { return data[16] as IS; } set { data[16] = value; } }
        public DT PurgeStatusDate { get { return data[17] as DT; } set { data[17] = value; } }
        public IS SpecialProgramCode { get { return data[18] as IS; } set { data[18] = value; } }
        public NM ExpectedNumberofInsurancePlans { get { return data[19] as NM; } set { data[19] = value; } }
        public IS VisitPublicityCode { get { return data[20] as IS; } set { data[20] = value; } }
        public ID VisitProtectionIndicator { get { return data[21] as ID; } set { data[21] = value; } }
        public XON ClinicOrganizationName { get { return data[22] as XON; } set { data[22] = value; } }
        public IS PatientStatusCode { get { return data[23] as IS; } set { data[23] = value; } }
        public IS VisitPriorityCode { get { return data[24] as IS; } set { data[24] = value; } }
        public DT PreviousTreatmentDate { get { return data[25] as DT; } set { data[25] = value; } }
        public IS ExpectedDischargeDisposition { get { return data[26] as IS; } set { data[26] = value; } }
        public DT SignatureonFileDate { get { return data[27] as DT; } set { data[27] = value; } }
        public DT FirstSimilarIllnessDate { get { return data[28] as DT; } set { data[28] = value; } }
        public CE PatientChargeAdjustmentCode { get { return data[29] as CE; } set { data[29] = value; } }
        public IS RecurringServiceCode { get { return data[30] as IS; } set { data[30] = value; } }
        public ID BillingMediaCode { get { return data[31] as ID; } set { data[31] = value; } }
        public TS ExpectedSurgeryDateandTime { get { return data[32] as TS; } set { data[32] = value; } }
        public ID MilitaryPartnershipCode { get { return data[33] as ID; } set { data[33] = value; } }
        public ID MilitaryNonAvailabilityCode { get { return data[34] as ID; } set { data[34] = value; } }
        public ID NewbornBabyIndicator { get { return data[35] as ID; } set { data[35] = value; } }
        public ID BabyDetainedIndicator { get { return data[36] as ID; } set { data[36] = value; } }
    }
    /// <summary>
    /// IN1 : insurance segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class IN1 : compositeMessage
    {
        public IN1(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[47];
            data[0] = new CE(this,"InsurancePlanID");
            data[1] = new CX(this,"InsuranceCompanyID");
            data[2] = new XON(this,"InsuranceCompanyName");
            data[3] = new XAD(this,"InsuranceCompanyAddress");
            data[4] = new XPN(this,"InsuranceCoContactPerson");
            data[5] = new XTN(this,"InsuranceCoPhoneNumber");
            data[6] = new ST("GroupNumber");
            data[7] = new XON(this,"GroupName");
            data[8] = new CX(this,"InsuredGroupEmpID");
            data[9] = new XON(this,"InsuredGroupEmpName");
            data[10] = new DT("PlanEffectiveDate");
            data[11] = new DT("PlanExpirationDate");
            data[12] = new CM(this,"AuthorizationInformation");
            data[13] = new IS("PlanType");
            data[14] = new XPN(this,"NameOfInsured");
            data[15] = new CE(this,"InsuredRelationshipToPatient");
            data[16] = new TS("InsuredDateOfBirth");
            data[17] = new XAD(this,"InsuredAddress");
            data[18] = new IS("AssignmentOfBenefits");
            data[19] = new IS("CoordinationOfBenefits");
            data[20] = new ST("CoordOfBen.Priority");
            data[21] = new ID("NoticeOfAdmissionFlag");
            data[22] = new DT("NoticeOfAdmissionDate");
            data[23] = new ID("ReportOfEligibilityFlag");
            data[24] = new DT("ReportOfEligibilityDate");
            data[25] = new IS("ReleaseInformationCode");
            data[26] = new TS("VerificationDateOrTime");
            data[27] = new XCN(this,"VerificationBy");
            data[28] = new IS("TypeOfAgreementCode");
            data[29] = new IS("BillingStatus");
            data[30] = new NM("LifetimeReserveDays");
            data[31] = new NM("DelayBeforeL.R.Day");
            data[32] = new IS("CompanyPlanCode");
            data[33] = new ST("PolicyNumber");
            data[34] = new CP(this,"PolicyDeductible");
            data[35] = new CP(this,"PolicyLimitAmount");
            data[36] = new NM("PolicyLimitDays");
            data[37] = new CP(this,"RoomRateSemiPrivate");
            data[38] = new CP(this,"RoomRatePrivate");
            data[39] = new CE(this, "InsuredEmploymentStatus");
            data[40] = new IS("InsuredSex");
            data[41] = new XAD(this, "InsuredEmployerAddress");
            data[42] = new ST("VerificationStatus");
            data[43] = new IS("PriorInsurancePlanID");
            data[44] = new IS("CoverageType");
            data[45] = new IS("Handicap");
            data[46] = new CX(this, "InsuredIDNumber");
        }
        public CE InsurancePlanID { get { return data[0] as CE; } set { data[0] = value; } }
        public CX InsuranceCompanyID { get { return data[1] as CX; } set { data[1] = value; } }
        public XON InsuranceCompanyName { get { return data[2] as XON; } set { data[2] = value; } }
        public XAD InsuranceCompanyAddress { get { return data[3] as XAD; } set { data[3] = value; } }
        public XPN InsuranceCoContactPerson { get { return data[4] as XPN; } set { data[4] = value; } }
        public XTN InsuranceCoPhoneNumber { get { return data[5] as XTN; } set { data[5] = value; } }
        public ST GroupNumber { get { return data[6] as ST; } set { data[6] = value; } }
        public XON GroupName { get { return data[7] as XON; } set { data[7] = value; } }
        public CX InsuredGroupEmpID { get { return data[8] as CX; } set { data[8] = value; } }
        public XON InsuredGroupEmpName { get { return data[9] as XON; } set { data[9] = value; } }
        public DT PlanEffectiveDate { get { return data[10] as DT; } set { data[10] = value; } }
        public DT PlanExpirationDate { get { return data[11] as DT; } set { data[11] = value; } }
        public CM AuthorizationInformation { get { return data[12] as CM; } set { data[12] = value; } }
        public IS PlanType { get { return data[13] as IS; } set { data[13] = value; } }
        public XPN NameOfInsured { get { return data[14] as XPN; } set { data[14] = value; } }
        public CE InsuredRelationshipToPatient { get { return data[15] as CE; } set { data[15] = value; } }
        public TS InsuredDateOfBirth { get { return data[16] as TS; } set { data[16] = value; } }
        public XAD InsuredAddress { get { return data[17] as XAD; } set { data[17] = value; } }
        public IS AssignmentOfBenefits { get { return data[18] as IS; } set { data[18] = value; } }
        public IS CoordinationOfBenefits { get { return data[19] as IS; } set { data[19] = value; } }
        public ST CoordOfBen_Priority { get { return data[20] as ST; } set { data[20] = value; } }
        public ID NoticeOfAdmissionFlag { get { return data[21] as ID; } set { data[21] = value; } }
        public DT NoticeOfAdmissionDate { get { return data[22] as DT; } set { data[22] = value; } }
        public ID ReportOfEligibilityFlag { get { return data[23] as ID; } set { data[23] = value; } }
        public DT ReportOfEligibilityDate { get { return data[24] as DT; } set { data[24] = value; } }
        public IS ReleaseInformationCode { get { return data[25] as IS; } set { data[25] = value; } }
        public TS VerificationDateOrTime { get { return data[26] as TS; } set { data[26] = value; } }
        public XCN VerificationBy { get { return data[27] as XCN; } set { data[27] = value; } }
        public IS TypeOfAgreementCode { get { return data[28] as IS; } set { data[28] = value; } }
        public IS BillingStatus { get { return data[29] as IS; } set { data[29] = value; } }
        public NM LifetimeReserveDays { get { return data[30] as NM; } set { data[30] = value; } }
        public NM DelayBeforeL_R_Day { get { return data[31] as NM; } set { data[31] = value; } }
        public IS CompanyPlanCode { get { return data[32] as IS; } set { data[32] = value; } }
        public ST PolicyNumber { get { return data[33] as ST; } set { data[33] = value; } }
        public CP PolicyDeductible { get { return data[34] as CP; } set { data[34] = value; } }
        public CP PolicyLimitAmount { get { return data[35] as CP; } set { data[35] = value; } }
        public NM PolicyLimitDays { get { return data[36] as NM; } set { data[36] = value; } }
        public CP RoomRateSemiPrivate { get { return data[37] as CP; } set { data[37] = value; } }
        public CP RoomRatePrivate { get { return data[38] as CP; } set { data[38] = value; } }
        public CE InsuredEmploymentStatus { get { return data[39] as CE; } set { data[39] = value; } }
        public IS InsuredSex { get { return data[40] as IS; } set { data[40] = value; } }
        public XAD InsuredEmployerAddress { get { return data[41] as XAD; } set { data[41] = value; } }
        public ST VerificationStatus { get { return data[42] as ST; } set { data[42] = value; } }
        public IS PriorInsurancePlanID { get { return data[43] as IS; } set { data[43] = value; } }
        public IS CoverageType { get { return data[44] as IS; } set { data[44] = value; } }
        public IS Handicap { get { return data[45] as IS; } set { data[45] = value; } }
        public CX InsuredIDNumber { get { return data[46] as CX; } set { data[46] = value; } }
    }
    /// <summary>
    /// IN2 : insurance additional information segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class IN2 : compositeSegment
    {
        public IN2(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[72];
            data[0] = new CX(this,"InsuredEmployeeID");
            data[1] = new ST("InsuredSocialSecurityNumber");
            data[2] = new XCN(this, "InsuredEmployerNameandID");
            data[3] = new IS("EmployerInformationData");
            data[4] = new IS("MailClaimParty");
            data[5] = new ST("MedicareHealthInsCardNumber");
            data[6] = new XPN(this, "MedicaidCaseName");
            data[7] = new ST("MedicaidCaseNumber");
            data[8] = new XPN(this, "MilitarySponsorName");
            data[9] = new ST("MilitaryIDNumber");
            data[10] = new CE(this, "DependentOfMilitaryRecipient");
            data[11] = new ST("MilitaryOrganization");
            data[12] = new ST("MilitaryStation");
            data[13] = new IS("MilitaryService");
            data[14] = new IS("MilitaryRankOrGrade");
            data[15] = new IS("MilitaryStatus");
            data[16] = new DT("MilitaryRetireDate");
            data[17] = new ID("MilitaryNonAvailCertOnFile");
            data[18] = new ID("BabyCoverage");
            data[19] = new ID("CombineBabyBill");
            data[20] = new ST("BloodDeductible");
            data[21] = new XPN(this, "SpecialCoverageApprovalName");
            data[22] = new ST("SpecialCoverageApprovalTitle");
            data[23] = new IS("NonCoveredInsuranceCode");
            data[24] = new CX(this, "PayorID");
            data[25] = new CX(this, "PayorSubscriberID");
            data[26] = new IS("EligibilitySource");
            data[27] = new CM(this, "RoomCoverageTypeOrAmount");
            data[28] = new CM(this, "PolicyTypeOrAmount");
            data[29] = new CM(this, "DailyDeductible");
            data[30] = new IS("LivingDependency");
            data[31] = new IS("AmbulatoryStatus");
            data[32] = new CE(this, "Citizenship");
            data[33] = new CE(this, "PrimaryLanguage");
            data[34] = new IS("LivingArrangement");
            data[35] = new CE(this, "PublicityCode");
            data[36] = new ID("ProtectionIndicator");
            data[37] = new IS("StudentIndicator");
            data[38] = new CE(this, "Religion");
            data[39] = new XPN(this, "MotherMaidenName");
            data[40] = new CE(this, "Nationality");
            data[41] = new CE(this, "EthnicGroup");
            data[42] = new CE(this, "MaritalStatus");
            data[43] = new DT("InsuredEmploymentStartDate");
            data[44] = new DT("EmploymentStopDate");
            data[45] = new ST("JobTitle");
            data[46] = new JCC(this, "JobCodeOrClass");
            data[47] = new IS("JobStatus");
            data[48] = new XPN(this, "EmployerContactPersonName");
            data[49] = new XTN(this, "EmployerContactPersonPhoneNumber");
            data[50] = new IS("EmployerContactReason");
            data[51] = new XPN(this, "InsuredContactPersonName");
            data[52] = new XTN(this, "InsuredContactPersonPhoneNumber");
            data[53] = new IS("InsuredContactPersonReason");
            data[54] = new DT("RelationshipToThePatientStartDate");
            data[55] = new DT("RelationshipToThePatientStopDate");
            data[56] = new IS("InsuranceCo.ContactReason");
            data[57] = new XTN(this, "InsuranceCoContactPhoneNumber");
            data[58] = new IS("PolicyScope");
            data[59] = new IS("PolicySource");
            data[60] = new CX(this, "PatientMemberNumber");
            data[61] = new CE(this, "GuarantorRelationshipToInsured");
            data[62] = new XTN(this, "InsuredPhoneNumberHome");
            data[63] = new XTN(this, "InsuredEmployerPhoneNumber");
            data[64] = new CE(this, "MilitaryHandicappedProgram");
            data[65] = new ID("SuspendFlag");
            data[66] = new ID("CopayLimitFlag");
            data[67] = new ID("StoplossLimitFlag");
            data[68] = new XON(this, "InsuredOrganizationNameAndID");
            data[69] = new XON(this, "InsuredEmployerOrganizationNameAndID");
            data[70] = new CE(this, "Race");
            data[71] = new CE(this, "HCFAPatientRelationshiptoInsured");
        }
        public CX InsuredEmployeeID { get { return data[0] as CX; } set { data[0] = value; } }
        public ST InsuredSocialSecurityNumber { get { return data[1] as ST; } set { data[1] = value; } }
        public XCN InsuredEmployerNameandID { get { return data[2] as XCN; } set { data[2] = value; } }
        public IS EmployerInformationData { get { return data[3] as IS; } set { data[3] = value; } }
        public IS MailClaimParty { get { return data[4] as IS; } set { data[4] = value; } }
        public ST MedicareHealthInsCardNumber { get { return data[5] as ST; } set { data[5] = value; } }
        public XPN MedicaidCaseName { get { return data[6] as XPN; } set { data[6] = value; } }
        public ST MedicaidCaseNumber { get { return data[7] as ST; } set { data[7] = value; } }
        public XPN MilitarySponsorName { get { return data[8] as XPN; } set { data[8] = value; } }
        public ST MilitaryIDNumber { get { return data[9] as ST; } set { data[9] = value; } }
        public CE DependentOfMilitaryRecipient { get { return data[10] as CE; } set { data[10] = value; } }
        public ST MilitaryOrganization { get { return data[11] as ST; } set { data[11] = value; } }
        public ST MilitaryStation { get { return data[12] as ST; } set { data[12] = value; } }
        public IS MilitaryService { get { return data[13] as IS; } set { data[13] = value; } }
        public IS MilitaryRankOrGrade { get { return data[14] as IS; } set { data[14] = value; } }
        public IS MilitaryStatus { get { return data[15] as IS; } set { data[15] = value; } }
        public DT MilitaryRetireDate { get { return data[16] as DT; } set { data[16] = value; } }
        public ID MilitaryNonAvailCertOnFile { get { return data[17] as ID; } set { data[17] = value; } }
        public ID BabyCoverage { get { return data[18] as ID; } set { data[18] = value; } }
        public ID CombineBabyBill { get { return data[19] as ID; } set { data[19] = value; } }
        public ST BloodDeductible { get { return data[20] as ST; } set { data[20] = value; } }
        public XPN SpecialCoverageApprovalName { get { return data[21] as XPN; } set { data[21] = value; } }
        public ST SpecialCoverageApprovalTitle { get { return data[22] as ST; } set { data[22] = value; } }
        public IS NonCoveredInsuranceCode { get { return data[23] as IS; } set { data[23] = value; } }
        public CX PayorID { get { return data[24] as CX; } set { data[24] = value; } }
        public CX PayorSubscriberID { get { return data[25] as CX; } set { data[25] = value; } }
        public IS EligibilitySource { get { return data[26] as IS; } set { data[26] = value; } }
        public CM RoomCoverageTypeOrAmount { get { return data[27] as CM; } set { data[27] = value; } }
        public CM PolicyTypeOrAmount { get { return data[28] as CM; } set { data[28] = value; } }
        public CM DailyDeductible { get { return data[29] as CM; } set { data[29] = value; } }
        public IS LivingDependency { get { return data[30] as IS; } set { data[30] = value; } }
        public IS AmbulatoryStatus { get { return data[31] as IS; } set { data[31] = value; } }
        public CE Citizenship { get { return data[32] as CE; } set { data[32] = value; } }
        public CE PrimaryLanguage { get { return data[33] as CE; } set { data[33] = value; } }
        public IS LivingArrangement { get { return data[34] as IS; } set { data[34] = value; } }
        public CE PublicityCode { get { return data[35] as CE; } set { data[35] = value; } }
        public ID ProtectionIndicator { get { return data[36] as ID; } set { data[36] = value; } }
        public IS StudentIndicator { get { return data[37] as IS; } set { data[37] = value; } }
        public CE Religion { get { return data[38] as CE; } set { data[38] = value; } }
        public XPN MotherMaidenName { get { return data[39] as XPN; } set { data[39] = value; } }
        public CE Nationality { get { return data[40] as CE; } set { data[40] = value; } }
        public CE EthnicGroup { get { return data[41] as CE; } set { data[41] = value; } }
        public CE MaritalStatus { get { return data[42] as CE; } set { data[42] = value; } }
        public DT InsuredEmploymentStartDate { get { return data[43] as DT; } set { data[43] = value; } }
        public DT EmploymentStopDate { get { return data[44] as DT; } set { data[44] = value; } }
        public ST JobTitle { get { return data[45] as ST; } set { data[45] = value; } }
        public JCC JobCodeOrClass { get { return data[46] as JCC; } set { data[46] = value; } }
        public IS JobStatus { get { return data[47] as IS; } set { data[47] = value; } }
        public XPN EmployerContactPersonName { get { return data[48] as XPN; } set { data[48] = value; } }
        public XTN EmployerContactPersonPhoneNumber { get { return data[49] as XTN; } set { data[49] = value; } }
        public IS EmployerContactReason { get { return data[50] as IS; } set { data[50] = value; } }
        public XPN InsuredContactPersonName { get { return data[51] as XPN; } set { data[51] = value; } }
        public XTN InsuredContactPersonPhoneNumber { get { return data[52] as XTN; } set { data[52] = value; } }
        public IS InsuredContactPersonReason { get { return data[53] as IS; } set { data[53] = value; } }
        public DT RelationshipToThePatientStartDate { get { return data[54] as DT; } set { data[54] = value; } }
        public DT RelationshipToThePatientStopDate { get { return data[55] as DT; } set { data[55] = value; } }
        public IS InsuranceCo_ContactReason { get { return data[56] as IS; } set { data[56] = value; } }
        public XTN InsuranceCoContactPhoneNumber { get { return data[57] as XTN; } set { data[57] = value; } }
        public IS PolicyScope { get { return data[58] as IS; } set { data[58] = value; } }
        public IS PolicySource { get { return data[59] as IS; } set { data[59] = value; } }
        public CX PatientMemberNumber { get { return data[60] as CX; } set { data[60] = value; } }
        public CE GuarantorRelationshipToInsured { get { return data[61] as CE; } set { data[61] = value; } }
        public XTN InsuredPhoneNumberHome { get { return data[62] as XTN; } set { data[62] = value; } }
        public XTN InsuredEmployerPhoneNumber { get { return data[63] as XTN; } set { data[63] = value; } }
        public CE MilitaryHandicappedProgram { get { return data[64] as CE; } set { data[64] = value; } }
        public ID SuspendFlag { get { return data[65] as ID; } set { data[65] = value; } }
        public ID CopayLimitFlag { get { return data[66] as ID; } set { data[66] = value; } }
        public ID StoplossLimitFlag { get { return data[67] as ID; } set { data[67] = value; } }
        public XON InsuredOrganizationNameAndID { get { return data[68] as XON; } set { data[68] = value; } }
        public XON InsuredEmployerOrganizationNameAndID { get { return data[69] as XON; } set { data[69] = value; } }
        public CE Race { get { return data[70] as CE; } set { data[70] = value; } }
        public CE HCFAPatientRelationshiptoInsured { get { return data[71] as CE; } set { data[71] = value; } }
    }
    /// <summary>
    ///IN3 : insurance additional information, certification segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class IN3 : compositeSegment
    {
        public IN3(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[24];
            data[0] = new CX(this,"CertificationNumber");
            data[1] = new XCN(this, "CertifiedBy");
            data[2] = new ID("CertificationRequired");
            data[3] = new CM(this, "Penalty");
            data[4] = new TS("CertificationDateOrTime");
            data[5] = new TS("CertificationModifyDateOrTime");
            data[6] = new XCN(this, "Operator");
            data[7] = new DT("CertificationBeginDate");
            data[8] = new DT("CertificationEndDate");
            data[9] = new CM(this, "Days");
            data[10] = new CE(this, "NonConcurCodeOrDescription");
            data[11] = new TS("NonConcurEffectiveDateOrTime");
            data[12] = new XCN(this, "PhysicianReviewer");
            data[13] = new ST("CertificationContact");
            data[14] = new XTN(this, "CertificationContactPhoneNumber");
            data[15] = new CE(this, "AppealReason");
            data[16] = new CE(this, "CertificationAgency");
            data[17] = new XTN(this, "CertificationAgencyPhoneNumber");
            data[18] = new CM(this, "PreCertificationReqOrWindow");
            data[19] = new ST("CaseManager");
            data[20] = new DT("SecondOpinionDate");
            data[21] = new IS("SecondOpinionStatus");
            data[22] = new IS("SecondOpinionDocumentationReceived");
            data[23] = new XCN(this, "SecondOpinionPhysician");
        }
        public CX CertificationNumber { get { return data[0] as CX; } set { data[0] = value; } }
        public XCN CertifiedBy { get { return data[1] as XCN; } set { data[1] = value; } }
        public ID CertificationRequired { get { return data[2] as ID; } set { data[2] = value; } }
        public CM Penalty { get { return data[3] as CM; } set { data[3] = value; } }
        public TS CertificationDateOrTime { get { return data[4] as TS; } set { data[4] = value; } }
        public TS CertificationModifyDateOrTime { get { return data[5] as TS; } set { data[5] = value; } }
        public XCN Operator { get { return data[6] as XCN; } set { data[6] = value; } }
        public DT CertificationBeginDate { get { return data[7] as DT; } set { data[7] = value; } }
        public DT CertificationEndDate { get { return data[8] as DT; } set { data[8] = value; } }
        public CM Days { get { return data[9] as CM; } set { data[9] = value; } }
        public CE NonConcurCodeOrDescription { get { return data[10] as CE; } set { data[10] = value; } }
        public TS NonConcurEffectiveDateOrTime { get { return data[11] as TS; } set { data[11] = value; } }
        public XCN PhysicianReviewer { get { return data[12] as XCN; } set { data[12] = value; } }
        public ST CertificationContact { get { return data[13] as ST; } set { data[13] = value; } }
        public XTN CertificationContactPhoneNumber { get { return data[14] as XTN; } set { data[14] = value; } }
        public CE AppealReason { get { return data[15] as CE; } set { data[15] = value; } }
        public CE CertificationAgency { get { return data[16] as CE; } set { data[16] = value; } }
        public XTN CertificationAgencyPhoneNumber { get { return data[17] as XTN; } set { data[17] = value; } }
        public CM PreCertificationReqOrWindow { get { return data[18] as CM; } set { data[18] = value; } }
        public ST CaseManager { get { return data[19] as ST; } set { data[19] = value; } }
        public DT SecondOpinionDate { get { return data[20] as DT; } set { data[20] = value; } }
        public IS SecondOpinionStatus { get { return data[21] as IS; } set { data[21] = value; } }
        public IS SecondOpinionDocumentationReceived { get { return data[22] as IS; } set { data[22] = value; } }
        public XCN SecondOpinionPhysician { get { return data[23] as XCN; } set { data[23] = value; } }
    }
    /// <summary>
    /// GT1 : guarantor segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class GT1 : compositeSegment
    {
        public GT1(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[55];
            data[0] = new SI("SetID");
            data[1] = new CX(this,"GuarantorNumber");
            data[2] = new XPN(this, "GuarantorName");
            data[3] = new XPN(this, "GuarantorSpouseName");
            data[4] = new XAD(this, "GuarantorAddress");
            data[5] = new XTN(this, "GuarantorPhNumHome");
            data[6] = new XTN(this, "GuarantorPhNumBusiness");
            data[7] = new TS("GuarantorDateOrTimeOfBirth");
            data[8] = new IS("GuarantorSex");
            data[9] = new IS("GuarantorType");
            data[10] = new CE(this, "GuarantorRelationship");
            data[11] = new ST("GuarantorSSN");
            data[12] = new DT("GuarantorDateBegin");
            data[13] = new DT("GuarantorDateEnd");
            data[14] = new NM("GuarantorPriority");
            data[15] = new XPN(this, "GuarantorEmployerName");
            data[16] = new XAD(this, "GuarantorEmployerAddress");
            data[17] = new XTN(this, "GuarantorEmployerPhoneNumber");
            data[18] = new CX(this, "GuarantorEmployeeIDNumber");
            data[19] = new IS("GuarantorEmploymentStatus");
            data[20] = new XON(this, "GuarantorOrganizationName");
            data[21] = new ID("GuarantorBillingHoldFlag");
            data[22] = new CE(this, "GuarantorCreditRatingCode");
            data[23] = new TS("GuarantorDeathDateAndTime");
            data[24] = new ID("GuarantorDeathFlag");
            data[25] = new CE(this, "GuarantorChargeAdjustmentCode");
            data[26] = new CP(this, "GuarantorHouseholdAnnualIncome");
            data[27] = new NM("GuarantorHouseholdSize");
            data[28] = new CX(this, "GuarantorEmployerIDNumber");
            data[29] = new CE(this, "GuarantorMaritalStatusCode");
            data[30] = new DT("GuarantorHireEffectiveDate");
            data[31] = new DT("EmploymentStopDate");
            data[32] = new IS("LivingDependency");
            data[33] = new IS("AmbulatoryStatus");
            data[34] = new CE(this, "Citizenship");
            data[35] = new CE(this, "PrimaryLanguage");
            data[36] = new IS("LivingArrangement");
            data[37] = new CE(this, "PublicityCode");
            data[38] = new ID("ProtectionIndicator");
            data[39] = new IS("StudentIndicator");
            data[40] = new CE(this, "Religion");
            data[41] = new XPN(this, "MotherMaidenName");
            data[42] = new CE(this, "Nationality");
            data[43] = new CE(this, "EthnicGroup");
            data[44] = new XPN(this, "ContactPersonName");
            data[45] = new XTN(this, "ContactPersonTelephoneNumber");
            data[46] = new CE(this, "ContactReason");
            data[47] = new IS("ContactRelationship");
            data[48] = new ST("JobTitle");
            data[49] = new JCC(this, "JobCodeOrClass");
            data[50] = new XON(this, "GuarantorEmployerOrganizationName");
            data[51] = new IS("Handicap");
            data[52] = new IS("JobStatus");
            data[53] = new FC(this, "GuarantorFinancialClass");
            data[54] = new CE(this, "GuarantorRace");
        }
        public SI SetID { get { return data[0] as SI; } set { data[0] = value; } }
        public CX GuarantorNumber { get { return data[1] as CX; } set { data[1] = value; } }
        public XPN GuarantorName { get { return data[2] as XPN; } set { data[2] = value; } }
        public XPN GuarantorSpouseName { get { return data[3] as XPN; } set { data[3] = value; } }
        public XAD GuarantorAddress { get { return data[4] as XAD; } set { data[4] = value; } }
        public XTN GuarantorPhNumHome { get { return data[5] as XTN; } set { data[5] = value; } }
        public XTN GuarantorPhNumBusiness { get { return data[6] as XTN; } set { data[6] = value; } }
        public TS GuarantorDateOrTimeOfBirth { get { return data[7] as TS; } set { data[7] = value; } }
        public IS GuarantorSex { get { return data[8] as IS; } set { data[8] = value; } }
        public IS GuarantorType { get { return data[9] as IS; } set { data[9] = value; } }
        public CE GuarantorRelationship { get { return data[10] as CE; } set { data[10] = value; } }
        public ST GuarantorSSN { get { return data[11] as ST; } set { data[11] = value; } }
        public DT GuarantorDateBegin { get { return data[12] as DT; } set { data[12] = value; } }
        public DT GuarantorDateEnd { get { return data[13] as DT; } set { data[13] = value; } }
        public NM GuarantorPriority { get { return data[14] as NM; } set { data[14] = value; } }
        public XPN GuarantorEmployerName { get { return data[15] as XPN; } set { data[15] = value; } }
        public XAD GuarantorEmployerAddress { get { return data[16] as XAD; } set { data[16] = value; } }
        public XTN GuarantorEmployerPhoneNumber { get { return data[17] as XTN; } set { data[17] = value; } }
        public CX GuarantorEmployeeIDNumber { get { return data[18] as CX; } set { data[18] = value; } }
        public IS GuarantorEmploymentStatus { get { return data[19] as IS; } set { data[19] = value; } }
        public XON GuarantorOrganizationName { get { return data[20] as XON; } set { data[20] = value; } }
        public ID GuarantorBillingHoldFlag { get { return data[21] as ID; } set { data[21] = value; } }
        public CE GuarantorCreditRatingCode { get { return data[22] as CE; } set { data[22] = value; } }
        public TS GuarantorDeathDateAndTime { get { return data[23] as TS; } set { data[23] = value; } }
        public ID GuarantorDeathFlag { get { return data[24] as ID; } set { data[24] = value; } }
        public CE GuarantorChargeAdjustmentCode { get { return data[25] as CE; } set { data[25] = value; } }
        public CP GuarantorHouseholdAnnualIncome { get { return data[26] as CP; } set { data[26] = value; } }
        public NM GuarantorHouseholdSize { get { return data[27] as NM; } set { data[27] = value; } }
        public CX GuarantorEmployerIDNumber { get { return data[28] as CX; } set { data[28] = value; } }
        public CE GuarantorMaritalStatusCode { get { return data[29] as CE; } set { data[29] = value; } }
        public DT GuarantorHireEffectiveDate { get { return data[30] as DT; } set { data[30] = value; } }
        public DT EmploymentStopDate { get { return data[31] as DT; } set { data[31] = value; } }
        public IS LivingDependency { get { return data[32] as IS; } set { data[32] = value; } }
        public IS AmbulatoryStatus { get { return data[33] as IS; } set { data[33] = value; } }
        public CE Citizenship { get { return data[34] as CE; } set { data[34] = value; } }
        public CE PrimaryLanguage { get { return data[35] as CE; } set { data[35] = value; } }
        public IS LivingArrangement { get { return data[36] as IS; } set { data[36] = value; } }
        public CE PublicityCode { get { return data[37] as CE; } set { data[37] = value; } }
        public ID ProtectionIndicator { get { return data[38] as ID; } set { data[38] = value; } }
        public IS StudentIndicator { get { return data[39] as IS; } set { data[39] = value; } }
        public CE Religion { get { return data[40] as CE; } set { data[40] = value; } }
        public XPN MotherMaidenName { get { return data[41] as XPN; } set { data[41] = value; } }
        public CE Nationality { get { return data[42] as CE; } set { data[42] = value; } }
        public CE EthnicGroup { get { return data[43] as CE; } set { data[43] = value; } }
        public XPN ContactPersonName { get { return data[44] as XPN; } set { data[44] = value; } }
        public XTN ContactPersonTelephoneNumber { get { return data[45] as XTN; } set { data[45] = value; } }
        public CE ContactReason { get { return data[46] as CE; } set { data[46] = value; } }
        public IS ContactRelationship { get { return data[47] as IS; } set { data[47] = value; } }
        public ST JobTitle { get { return data[48] as ST; } set { data[48] = value; } }
        public JCC JobCodeOrClass { get { return data[49] as JCC; } set { data[49] = value; } }
        public XON GuarantorEmployerOrganizationName { get { return data[50] as XON; } set { data[50] = value; } }
        public IS Handicap { get { return data[51] as IS; } set { data[51] = value; } }
        public IS JobStatus { get { return data[52] as IS; } set { data[52] = value; } }
        public FC GuarantorFinancialClass { get { return data[53] as FC; } set { data[53] = value; } }
        public CE GuarantorRace { get { return data[54] as CE; } set { data[54] = value; } }
    }
    /// <summary>
    /// AL1 : patient allergy information segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class AL1 : compositeSegment
    {
        public AL1(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[6];
            data[0] = new SI("SetID");
            data[1] = new IS("AllergyType");
            data[2] = new CE(this,"AllergyCodeOrMnemonicOrDescription");
            data[3] = new IS("AllergySeverity");
            data[4] = new ST("AllergyReaction");
            data[5] = new DT("IdentificationDate");
        }
        public SI SetID { get { return data[0] as SI; } set { data[0] = value; } }
        public IS AllergyType { get { return data[1] as IS; } set { data[1] = value; } }
        public CE AllergyCodeOrMnemonicOrDescription { get { return data[2] as CE; } set { data[2] = value; } }
        public IS AllergySeverity { get { return data[3] as IS; } set { data[3] = value; } }
        public ST AllergyReaction { get { return data[4] as ST; } set { data[4] = value; } }
        public DT IdentificationDate { get { return data[5] as DT; } set { data[5] = value; } }
    }
    /// <summary>
    /// ORC : common order segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class ORC : compositeSegment
    {
        public ORC(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[24];
            data[0] = new ID("OrderControl");
            data[1] = new EI(this,"PlacerOrderNumber");
            data[2] = new EI(this, "FillerOrderNumber");
            data[3] = new EI(this, "PlacerGroupNumber");
            data[4] = new ID("OrderStatus");
            data[5] = new ID("ResponseFlag");
            data[6] = new TQ(this, "QuantityOrTiming");
            data[7] = new CM(this, "Parent");
            data[8] = new TS("DateOrTimeofTransaction");
            data[9] = new XCN(this, "EnteredBy");
            data[10] = new XCN(this, "VerifiedBy");
            data[11] = new XCN(this, "OrderingProvider");
            data[12] = new PL(this, "EntererLocation");
            data[13] = new XTN(this, "CallBackPhoneNumber");
            data[14] = new TS("OrderEffectiveDateOrTime");
            data[15] = new CE(this, "OrderControlCodeReason");
            data[16] = new CE(this, "EnteringOrganization");
            data[17] = new CE(this, "EnteringDevice");
            data[18] = new XCN(this, "ActionBy");
            data[19] = new CE(this, "AdvancedBeneficiaryNoticeCode");
            data[20] = new XON(this, "OrderingFacilityName");
            data[21] = new XAD(this, "OrderingFacilityAddress");
            data[22] = new XTN(this, "OrderingFacilityPhoneNumber");
            data[23] = new XAD(this, "OrderingProviderAddress");
        }
        public ID OrderControl { get { return data[0] as ID; } set { data[0] = value; } }
        public EI PlacerOrderNumber { get { return data[1] as EI; } set { data[1] = value; } }
        public EI FillerOrderNumber { get { return data[2] as EI; } set { data[2] = value; } }
        public EI PlacerGroupNumber { get { return data[3] as EI; } set { data[3] = value; } }
        public ID OrderStatus { get { return data[4] as ID; } set { data[4] = value; } }
        public ID ResponseFlag { get { return data[5] as ID; } set { data[5] = value; } }
        public TQ QuantityOrTiming { get { return data[6] as TQ; } set { data[6] = value; } }
        public CM Parent { get { return data[7] as CM; } set { data[7] = value; } }
        public TS DateOrTimeofTransaction { get { return data[8] as TS; } set { data[8] = value; } }
        public XCN EnteredBy { get { return data[9] as XCN; } set { data[9] = value; } }
        public XCN VerifiedBy { get { return data[10] as XCN; } set { data[10] = value; } }
        public XCN OrderingProvider { get { return data[11] as XCN; } set { data[11] = value; } }
        public PL EntererLocation { get { return data[12] as PL; } set { data[12] = value; } }
        public XTN CallBackPhoneNumber { get { return data[13] as XTN; } set { data[13] = value; } }
        public TS OrderEffectiveDateOrTime { get { return data[14] as TS; } set { data[14] = value; } }
        public CE OrderControlCodeReason { get { return data[15] as CE; } set { data[15] = value; } }
        public CE EnteringOrganization { get { return data[16] as CE; } set { data[16] = value; } }
        public CE EnteringDevice { get { return data[17] as CE; } set { data[17] = value; } }
        public XCN ActionBy { get { return data[18] as XCN; } set { data[18] = value; } }
        public CE AdvancedBeneficiaryNoticeCode { get { return data[19] as CE; } set { data[19] = value; } }
        public XON OrderingFacilityName { get { return data[20] as XON; } set { data[20] = value; } }
        public XAD OrderingFacilityAddress { get { return data[21] as XAD; } set { data[21] = value; } }
        public XTN OrderingFacilityPhoneNumber { get { return data[22] as XTN; } set { data[22] = value; } }
        public XAD OrderingProviderAddress { get { return data[23] as XAD; } set { data[23] = value; } }
    }
    /// <summary>
    /// OBR : observation request segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class OBR : compositeSegment
    {
        public OBR(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[45];
            data[0] = new SI("SetIDOBR");
            data[1] = new EI(this,"PlacerOrderNumber");
            data[2] = new EI(this, "FillerOrderNumber");
            data[3] = new CE(this, "UniversalServiceID");
            data[4] = new ID("PriorityOBR");
            data[5] = new TS("RequestedDateOrtime");
            data[6] = new TS("ObservationDateOrTime");
            data[7] = new TS("ObservationEndDateOrTime");
            data[8] = new CQ(this, "CollectionVolume");
            data[9] = new XCN(this, "CollectorIdentifier");
            data[10] = new ID("SpecimenActionCode");
            data[11] = new CE(this, "DangerCode");
            data[12] = new ST("RelevantClinicalInfo.");
            data[13] = new TS("SpecimenReceivedDateOrTime");
            data[14] = new CM(this, "SpecimenSource");
            data[15] = new XCN(this, "OrderingProvider");
            data[16] = new XTN(this, "OrderCallbackPhoneNumber");
            data[17] = new ST("PlacerField1");
            data[18] = new ST("PlacerField2");
            data[19] = new ST("FillerField1");
            data[20] = new ST("FillerField2");
            data[21] = new TS("ResultsRptOrStatusChngDateOrTime");
            data[22] = new CM(this, "ChargetoPractice");
            data[23] = new ID("DiagnosticServSectID");
            data[24] = new ID("ResultStatus");
            data[25] = new CM(this, "ParentResult");
            data[26] = new TQ(this, "QuantityOrTiming");
            data[27] = new XCN(this, "ResultCopiesTo");
            data[28] = new CM(this, "Parent");
            data[29] = new ID("TransportationMode");
            data[30] = new CE(this, "ReasonforStudy");
            data[31] = new CM(this, "PrincipalResultInterpreter");
            data[32] = new CM(this, "AssistantResultInterpreter");
            data[33] = new CM(this, "Technician");
            data[34] = new CM(this, "Transcriptionist");
            data[35] = new TS("ScheduledDateOrTime");
            data[36] = new NM("NumberofSampleContainers");
            data[37] = new CE(this, "TransportLogisticsofCollectedSample");
            data[38] = new CE(this, "CollectorComment");
            data[39] = new CE(this, "TransportArrangementResponsibility");
            data[40] = new ID("TransportArranged");
            data[41] = new ID("EscortRequired");
            data[42] = new CE(this, "PlannedPatientTransportComment");
            data[43] = new CE(this, "ProcedureCode");
            data[44] = new CE(this, "ProcedureCodeModifier");
        }
        public SI SetIDOBR { get { return data[0] as SI; } set { data[0] = value; } }
        public EI PlacerOrderNumber { get { return data[1] as EI; } set { data[1] = value; } }
        public EI FillerOrderNumber { get { return data[2] as EI; } set { data[2] = value; } }
        public CE UniversalServiceID { get { return data[3] as CE; } set { data[3] = value; } }
        public ID PriorityOBR { get { return data[4] as ID; } set { data[4] = value; } }
        public TS RequestedDateOrtime { get { return data[5] as TS; } set { data[5] = value; } }
        public TS ObservationDateOrTime { get { return data[6] as TS; } set { data[6] = value; } }
        public TS ObservationEndDateOrTime { get { return data[7] as TS; } set { data[7] = value; } }
        public CQ CollectionVolume { get { return data[8] as CQ; } set { data[8] = value; } }
        public XCN CollectorIdentifier { get { return data[9] as XCN; } set { data[9] = value; } }
        public ID SpecimenActionCode { get { return data[10] as ID; } set { data[10] = value; } }
        public CE DangerCode { get { return data[11] as CE; } set { data[11] = value; } }
        public ST RelevantClinicalInfo
{ get { return data[12] as ST; } set { data[12] = value; } }
        public TS SpecimenReceivedDateOrTime { get { return data[13] as TS; } set { data[13] = value; } }
        public CM SpecimenSource { get { return data[14] as CM; } set { data[14] = value; } }
        public XCN OrderingProvider { get { return data[15] as XCN; } set { data[15] = value; } }
        public XTN OrderCallbackPhoneNumber { get { return data[16] as XTN; } set { data[16] = value; } }
        public ST PlacerField1 { get { return data[17] as ST; } set { data[17] = value; } }
        public ST PlacerField2 { get { return data[18] as ST; } set { data[18] = value; } }
        public ST FillerField1 { get { return data[19] as ST; } set { data[19] = value; } }
        public ST FillerField2 { get { return data[20] as ST; } set { data[20] = value; } }
        public TS ResultsRptOrStatusChngDateOrTime { get { return data[21] as TS; } set { data[21] = value; } }
        public CM ChargetoPractice { get { return data[22] as CM; } set { data[22] = value; } }
        public ID DiagnosticServSectID { get { return data[23] as ID; } set { data[23] = value; } }
        public ID ResultStatus { get { return data[24] as ID; } set { data[24] = value; } }
        public CM ParentResult { get { return data[25] as CM; } set { data[25] = value; } }
        public TQ QuantityOrTiming { get { return data[26] as TQ; } set { data[26] = value; } }
        public XCN ResultCopiesTo { get { return data[27] as XCN; } set { data[27] = value; } }
        public CM Parent { get { return data[28] as CM; } set { data[28] = value; } }
        public ID TransportationMode { get { return data[29] as ID; } set { data[29] = value; } }
        public CE ReasonforStudy { get { return data[30] as CE; } set { data[30] = value; } }
        public CM PrincipalResultInterpreter { get { return data[31] as CM; } set { data[31] = value; } }
        public CM AssistantResultInterpreter { get { return data[32] as CM; } set { data[32] = value; } }
        public CM Technician { get { return data[33] as CM; } set { data[33] = value; } }
        public CM Transcriptionist { get { return data[34] as CM; } set { data[34] = value; } }
        public TS ScheduledDateOrTime { get { return data[35] as TS; } set { data[35] = value; } }
        public NM NumberofSampleContainers { get { return data[36] as NM; } set { data[36] = value; } }
        public CE TransportLogisticsofCollectedSample { get { return data[37] as CE; } set { data[37] = value; } }
        public CE CollectorComment { get { return data[38] as CE; } set { data[38] = value; } }
        public CE TransportArrangementResponsibility { get { return data[39] as CE; } set { data[39] = value; } }
        public ID TransportArranged { get { return data[40] as ID; } set { data[40] = value; } }
        public ID EscortRequired { get { return data[41] as ID; } set { data[41] = value; } }
        public CE PlannedPatientTransportComment { get { return data[42] as CE; } set { data[42] = value; } }
        public CE ProcedureCode { get { return data[43] as CE; } set { data[43] = value; } }
        public CE ProcedureCodeModifier { get { return data[44] as CE; } set { data[44] = value; } }
    }
    /// <summary>
    /// CTI : clinical trial identification segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class CTI : compositeSegment
    {
        public CTI(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new EI(this,"SponsorStudyID");
            data[1] = new CE(this,"StudyPhaseIdentifier");
            data[2] = new CE(this,"StudyScheduledTimePoint");
        }
        public EI SponsorStudyID { get { return data[0] as EI; } set { data[0] = value; } }
        public CE StudyPhaseIdentifier { get { return data[1] as CE; } set { data[1] = value; } }
        public CE StudyScheduledTimePoint { get { return data[2] as CE; } set { data[2] = value; } }
    }
    /// <summary>
    /// BLG : billing segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class BLG : compositeSegment
    {
        public BLG(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new CM(this,"WhentoCharge");
            data[1] = new ID("ChargeType");
            data[2] = new CX(this,"AccountID");
        }
        public CM WhentoCharge { get { return data[0] as CM; } set { data[0] = value; } }
        public ID ChargeType { get { return data[1] as ID; } set { data[1] = value; } }
        public CX AccountID { get { return data[2] as CX; } set { data[2] = value; } }
    }
    /// <summary>
    /// DG1 : diagnosis segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class DG1 : compositeSegment
    {
        public DG1(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[19];
            data[0] = new SI("SetIDDG1");
            data[1] = new ID("DiagnosisCodingMethod");
            data[2] = new CE(this,"DiagnosisCodeDG1");
            data[3] = new ST("DiagnosisDescription");
            data[4] = new TS("DiagnosisDateOrTime");
            data[5] = new IS("DiagnosisType");
            data[6] = new CE(this,"MajorDiagnosticCategory");
            data[7] = new CE(this, "DiagnosticRelatedGroup");
            data[8] = new ID("DRGApprovalIndicator");
            data[9] = new IS("DRGGrouperReviewCode");
            data[10] = new CE(this,"OutlierType");
            data[11] = new NM("OutlierDays");
            data[12] = new CP(this,"OutlierCost");
            data[13] = new ST("GrouperVersionAndType");
            data[14] = new ID("DiagnosisPriority");
            data[15] = new XCN(this, "DiagnosingClinician");
            data[16] = new IS("DiagnosisClassification");
            data[17] = new ID("ConfidentialIndicator");
            data[18] = new TS("AttestationDateOrTime");
        }
        public SI SetIDDG1 { get { return data[0] as SI; } set { data[0] = value; } }
        public ID DiagnosisCodingMethod { get { return data[1] as ID; } set { data[1] = value; } }
        public CE DiagnosisCodeDG1 { get { return data[2] as CE; } set { data[2] = value; } }
        public ST DiagnosisDescription { get { return data[3] as ST; } set { data[3] = value; } }
        public TS DiagnosisDateOrTime { get { return data[4] as TS; } set { data[4] = value; } }
        public IS DiagnosisType { get { return data[5] as IS; } set { data[5] = value; } }
        public CE MajorDiagnosticCategory { get { return data[6] as CE; } set { data[6] = value; } }
        public CE DiagnosticRelatedGroup { get { return data[7] as CE; } set { data[7] = value; } }
        public ID DRGApprovalIndicator { get { return data[8] as ID; } set { data[8] = value; } }
        public IS DRGGrouperReviewCode { get { return data[9] as IS; } set { data[9] = value; } }
        public CE OutlierType { get { return data[10] as CE; } set { data[10] = value; } }
        public NM OutlierDays { get { return data[11] as NM; } set { data[11] = value; } }
        public CP OutlierCost { get { return data[12] as CP; } set { data[12] = value; } }
        public ST GrouperVersionAndType { get { return data[13] as ST; } set { data[13] = value; } }
        public ID DiagnosisPriority { get { return data[14] as ID; } set { data[14] = value; } }
        public XCN DiagnosingClinician { get { return data[15] as XCN; } set { data[15] = value; } }
        public IS DiagnosisClassification { get { return data[16] as IS; } set { data[16] = value; } }
        public ID ConfidentialIndicator { get { return data[17] as ID; } set { data[17] = value; } }
        public TS AttestationDateOrTime { get { return data[18] as TS; } set { data[18] = value; } }
    }
    /// <summary>
    /// OBX : observation/result segment
    /// </summary>
    /// <seealso cref="HL7LIB.compositeSegment" />
    public class OBX : compositeSegment
    {
        public OBX(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[17];
            data[0] = new SI("SetIDOBX");
            data[1] = new ID("ValueType");
            data[2] = new CE(this,"ObservationIdentifier");
            data[3] = new ST("ObservationSubID");
            data[4] = new VARIES("ObservationValue");
            data[5] = new CE(this, "Units");
            data[6] = new ST("ReferencesRange");
            data[7] = new ID("AbnormalFlags");
            data[8] = new NM("Probability");
            data[9] = new ID("NatureofAbnormalTest");
            data[10] = new ID("ObservationResultStatus");
            data[11] = new TS("DateLastObsNormalValues");
            data[12] = new ST("UserDefinedAccessChecks");
            data[13] = new TS("DateOrTimeoftheObservation");
            data[14] = new CE(this, "ProducerID");
            data[15] = new XCN(this, "ResponsibleObserver");
            data[16] = new CE(this, "ObservationMethod");
        }
        public SI SetIDOBX { get { return data[0] as SI; } set { data[0] = value; } }
        public ID ValueType { get { return data[1] as ID; } set { data[1] = value; } }
        public CE ObservationIdentifier { get { return data[2] as CE; } set { data[2] = value; } }
        public ST ObservationSubID { get { return data[3] as ST; } set { data[3] = value; } }
        public VARIES ObservationValue { get { return data[4] as VARIES; } set { data[4] = value; } }
        public CE Units { get { return data[5] as CE; } set { data[5] = value; } }
        public ST ReferencesRange { get { return data[6] as ST; } set { data[6] = value; } }
        public ID AbnormalFlags { get { return data[7] as ID; } set { data[7] = value; } }
        public NM Probability { get { return data[8] as NM; } set { data[8] = value; } }
        public ID NatureofAbnormalTest { get { return data[9] as ID; } set { data[9] = value; } }
        public ID ObservationResultStatus { get { return data[10] as ID; } set { data[10] = value; } }
        public TS DateLastObsNormalValues { get { return data[11] as TS; } set { data[11] = value; } }
        public ST UserDefinedAccessChecks { get { return data[12] as ST; } set { data[12] = value; } }
        public TS DateOrTimeoftheObservation { get { return data[13] as TS; } set { data[13] = value; } }
        public CE ProducerID { get { return data[14] as CE; } set { data[14] = value; } }
        public XCN ResponsibleObserver { get { return data[15] as XCN; } set { data[15] = value; } }
        public CE ObservationMethod { get { return data[16] as CE; } set { data[16] = value; } }
    }
}