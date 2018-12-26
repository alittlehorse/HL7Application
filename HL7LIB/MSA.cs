using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7LIB.ConcretcompositeType
{
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
            data[5] = new CE(this,"ErrorCondition");
        }
        public ID AcknowledgmentCode { get { return data[0] as ID; } set { data[0] = value; } }
        public ST MessageControlID { get { return data[1] as ST; } set { data[1] = value; } }
        public ST TextMessage { get { return data[2] as ST; } set { data[2] = value; } }
        public NM ExpectedSequenceNumber { get { return data[3] as NM; } set { data[3] = value; } }
        public ID DelayedAcknowledgmentType { get { return data[4] as ID; } set { data[4] = value; } }
        public CE ErrorCondition { get { return data[5] as CE; } set { data[5] = value; } }
    }
    public class MSH : compositeSegment
    {
        public MSH(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[21];
            data[0] = new ST("FieldSeparator");
            data[1] = new ST("EncodingCharacters");
            data[2] = new HD(this,"SendingApplication");
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
    public class PID : compositeSegment
    {
        public PID(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[39];
            data[0] = new SI("SetIDPID");
            data[1] = new CX(this,"PatientID");
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
    public class ERR : compositeSegment
    {
        public ERR(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[11];
            data[0] = new ELD(this,"ErrorCodeandLocation");
            data[1] = new ERL(this,"ErrorLocation");
            data[2] = new ID("Severity");
            data[3] = new CWE(this,"ApplicationErrorCode");
            data[4] = new ST("ApplicationErrorParameter");
            data[5] = new TX("DiagnosticInformation");
            data[6] = new TX("UserMessage");
            data[7] = new IS("InformPersonIndicator");
            data[8] = new CWE(this,"OverrideType");
            data[9] = new CWE(this,"OverrideReasonCode");
            data[10] = new XTN(this,"HelpDeskContactPoint");
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
}
