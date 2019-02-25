using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7LIB;
/// <summary>
/// Concret composite Field
/// </summary>
namespace HL7LIB.ConcretcompositeType
{
    /// <summary>
    /// 编码元素
    /// </summary>
    public class CE : compositeField
    {
        public CE(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[6];
            data[0] = new ST("identifier");
            data[1] = new ST("text");
            data[2] = new ST("nameofcodingsystem");
            data[3] = new ST("alternateidentifier");
            data[4] = new ST("alternatetext");
            data[5] = new ST("nameofalternatecodingsystem");
        }
        public ST identifier { get { return data[0] as ST; } set { data[0] = value; } }
        public ST text { get { return data[1] as ST; } set { data[1] = value; } }
        public ST nameofcodingsystem { get { return data[2] as ST; } set { data[2] = value; } }
        public ST alternateidentifier { get { return data[3] as ST; } set { data[3] = value; } }
        public ST alternatetext { get { return data[4] as ST; } set { data[4] = value; } }
        public ST nameofalternatecodingsystem { get { return data[5] as ST; } set { data[5] = value; } }
    }
    public class FN : compositeField
    {
        public FN(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[5];
            data[0] = new ST("surname");
            data[1] = new ST("ownsurnameprefix");
            data[2] = new ST("ownsurname");
            data[3] = new ST("surnameprefixfrompartnerOrspouse");
            data[4] = new ST("surnamefrompartnerOrspouse");
        }
        public ST surname { get { return data[0] as ST; } set { data[0] = value; } }
        public ST ownsurnameprefix { get { return data[1] as ST; } set { data[1] = value; } }
        public ST ownsurname { get { return data[2] as ST; } set { data[2] = value; } }
        public ST surnameprefixfrompartnerOrspouse { get { return data[3] as ST; } set { data[3] = value; } }
        public ST surnamefrompartnerOrspouse { get { return data[4] as ST; } set { data[4] = value; } }
    }
    public class CX : compositeField
    {
        public CX(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[5];
            data[0] = new ID("versionID");
            data[1] = new CE(this,"internationalizationcode");
            data[2] = new CE(this,"internationalversionID");
            data[3] = new ST("entityidentifier");
            data[4] = new IS("namespaceID");
        }
        public ID versionID { get { return data[0] as ID; } set { data[0] = value; } }
        public CE internationalizationcode { get { return data[1] as CE; } set { data[1] = value; } }
        public CE internationalversionID { get { return data[2] as CE; } set { data[2] = value; } }
        public ST entityidentifier { get { return data[3] as ST; } set { data[3] = value; } }
        public IS namespaceID { get { return data[4] as IS; } set { data[4] = value; } }
    }
    public class XCN : compositeField
    {
        public XCN(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[11];
            data[0] = new CM(this,"familylastnameprefix");
            data[1] = new ST("givenname");
            data[2] = new ST("middleinitialorname");
            data[3] = new IS("sourcetable");
            data[4] = new HD(this,"assigningauthority");
            data[5] = new ID("nametypecode");
            data[6] = new ST("identifiercheckdigit");
            data[7] = new ID("codeidentifyingthecheckdigitschemeemployed");
            data[8] = new IS("identifiertypecode");
            data[9] = new HD(this,"assigningfacility");
            data[10] = new ID("NameRepresentationcode");
        }
        public CM familylastnameprefix { get { return data[0] as CM; } set { data[0] = value; } }
        public ST givenname { get { return data[1] as ST; } set { data[1] = value; } }
        public ST middleinitialorname { get { return data[2] as ST; } set { data[2] = value; } }
        public IS sourcetable { get { return data[3] as IS; } set { data[3] = value; } }
        public HD assigningauthority { get { return data[4] as HD; } set { data[4] = value; } }
        public ID nametypecode { get { return data[5] as ID; } set { data[5] = value; } }
        public ST identifiercheckdigit { get { return data[6] as ST; } set { data[6] = value; } }
        public ID codeidentifyingthecheckdigitschemeemployed { get { return data[7] as ID; } set { data[7] = value; } }
        public IS identifiertypecode { get { return data[8] as IS; } set { data[8] = value; } }
        public HD assigningfacility { get { return data[9] as HD; } set { data[9] = value; } }
        public ID NameRepresentationcode { get { return data[10] as ID; } set { data[10] = value; } }
    }
    public class HD : compositeField
    {
        public HD(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new SI("SetIDPID");
            data[1] = new CX(this,"PatientID");
            data[2] = new CX(this,"PatientIdentifierList");
        }
        public SI SetIDPID { get { return data[0] as SI; } set { data[0] = value; } }
        public CX PatientID { get { return data[1] as CX; } set { data[1] = value; } }
        public CX PatientIdentifierList { get { return data[2] as CX; } set { data[2] = value; } }
    }
    public class MSG : compositeField
    {
        public MSG(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new ID("messagecode");
            data[1] = new ID("triggerevent");
            data[2] = new ID("messagestructure");
        }
        public ID messagecode { get { return data[0] as ID; } set { data[0] = value; } }
        public ID triggerevent { get { return data[1] as ID; } set { data[1] = value; } }
        public ID messagestructure { get { return data[2] as ID; } set { data[2] = value; } }
    }
    public class PT : compositeField
    {
        public PT(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[2];
            data[0] = new ID("processingID");
            data[1] = new ID("processingmode");
        }
        public ID processingID { get { return data[0] as ID; } set { data[0] = value; } }
        public ID processingmode { get { return data[1] as ID; } set { data[1] = value; } }
    }
    public class VID : compositeField
    {
        public VID(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new ID("versionID");
            data[1] = new CE(this,"internationalizationcode");
            data[2] = new CE(this,"internationalversionID");
        }
        public ID versionID { get { return data[0] as ID; } set { data[0] = value; } }
        public CE internationalizationcode { get { return data[1] as CE; } set { data[1] = value; } }
        public CE internationalversionID { get { return data[2] as CE; } set { data[2] = value; } }
    }


    public class ELD : compositeField
    {
        public ELD(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[4];
            data[0] = new ST("segmentID");
            data[1] = new NM("segmentsequence");
            data[2] = new NM("fieldposition");
            data[3] = new CE(this,"codeidentifyingerror");
        }
        public ST segmentID { get { return data[0] as ST; } set { data[0] = value; } }
        public NM segmentsequence { get { return data[1] as NM; } set { data[1] = value; } }
        public NM fieldposition { get { return data[2] as NM; } set { data[2] = value; } }
        public CE codeidentifyingerror { get { return data[3] as CE; } set { data[3] = value; } }
    }

    public class ERL : compositeField
    {
        public ERL(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[6];
            data[0] = new ST("segmentID");
            data[1] = new NM("segmentsequence");
            data[2] = new NM("fieldposition");
            data[3] = new NM("fieldrepeition");
            data[4] = new NM("componentnumber");
            data[5] = new NM("subcomponentnumber");
        }
        public ST segmentID { get { return data[0] as ST; } set { data[0] = value; } }
        public NM segmentsequence { get { return data[1] as NM; } set { data[1] = value; } }
        public NM fieldposition { get { return data[2] as NM; } set { data[2] = value; } }
        public NM fieldrepeition { get { return data[3] as NM; } set { data[3] = value; } }
        public NM componentnumber { get { return data[4] as NM; } set { data[4] = value; } }
        public NM subcomponentnumber { get { return data[5] as NM; } set { data[5] = value; } }
    }
    public class CM : compositeField
    {
        public CM(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new ID("Message Code");
            data[1] = new ID("Trigger Event");
            data[2] = new ID("Message Structure");
        }
        public ID MessageCode
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public ID TriggerEvent
        {
            get { return data[1] as ID; }
            set { data[1] = value; }
        }
        public ID MessageStructure
        {
            get { return data[2] as ID; }
            set { data[2] = value; }
        }
    }
    public class EI : compositeField
    {
        public EI(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[4];
            data[0] = new ST("entityidentifier");
            data[1] = new IS("namespaceID");
            data[2] = new ST("universalID");
            data[3] = new ID("universalIDtype");
        }
        public ST entityidentifier { get { return data[0] as ST; } set { data[0] = value; } }
        public IS namespaceID { get { return data[1] as IS; } set { data[1] = value; } }
        public ST universalID { get { return data[2] as ST; } set { data[2] = value; } }
        public ID universalIDtype { get { return data[3] as ID; } set { data[3] = value; } }
    }
    public class XPN : compositeField
    {
        public XPN(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[7];

            data[0] = new FN(this,"familyname");
            data[1] = new ST("givenname");
            data[2] = new ST("secondandfurthergivennamesorinitialsthereof");
            data[3] = new ID("nameassemblyorder");
            data[4] = new TS("effectivedate");
            data[5] = new TS("expirationdate");
            data[6] = new ST("professionalsuffix");
        }
        public FN familyname { get { return data[0] as FN; } set { data[0] = value; } }
        public ST givenname { get { return data[1] as ST; } set { data[1] = value; } }
        public ST secondandfurthergivennamesorinitialsthereof { get { return data[2] as ST; } set { data[2] = value; } }
        public ID nameassemblyorder { get { return data[3] as ID; } set { data[3] = value; } }
        public TS effectivedate { get { return data[4] as TS; } set { data[4] = value; } }
        public TS expirationdate { get { return data[5] as TS; } set { data[5] = value; } }
        public ST professionalsuffix { get { return data[6] as ST; } set { data[6] = value; } }
    }

    public class XAD : compositeField
    {
        public XAD(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[14];
            data[0] = new SAD("streetaddress");
            data[1] = new ST("otherdesignation");
            data[2] = new ST("city");
            data[3] = new ST("stateorprovince");
            data[4] = new ST("ziporpostalcode");
            data[5] = new ID("country");
            data[6] = new ID("addresstype");
            data[7] = new ST("othergeographicdesignation");
            data[8] = new IS("countyOrparishcode");
            data[9] = new IS("censustract");
            data[10] = new ID("addressrepresentationcode");
            data[11] = new DR("addressvalidityrange");
            data[12] = new TS("effectivedate");
            data[13] = new TS("expirationdate");
        }
        public SAD streetaddress { get { return data[0] as SAD; } set { data[0] = value; } }
        public ST otherdesignation { get { return data[1] as ST; } set { data[1] = value; } }
        public ST city { get { return data[2] as ST; } set { data[2] = value; } }
        public ST stateorprovince { get { return data[3] as ST; } set { data[3] = value; } }
        public ST ziporpostalcode { get { return data[4] as ST; } set { data[4] = value; } }
        public ID country { get { return data[5] as ID; } set { data[5] = value; } }
        public ID addresstype { get { return data[6] as ID; } set { data[6] = value; } }
        public ST othergeographicdesignation { get { return data[7] as ST; } set { data[7] = value; } }
        public IS countyOrparishcode { get { return data[8] as IS; } set { data[8] = value; } }
        public IS censustract { get { return data[9] as IS; } set { data[9] = value; } }
        public ID addressrepresentationcode { get { return data[10] as ID; } set { data[10] = value; } }
        public DR addressvalidityrange { get { return data[11] as DR; } set { data[11] = value; } }
        public TS effectivedate { get { return data[12] as TS; } set { data[12] = value; } }
        public TS expirationdate { get { return data[13] as TS; } set { data[13] = value; } }
    }

    public class XTN : compositeField
    {
        public XTN(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[12];
            data[0] = new ST("telephonenumber");
            data[1] = new ID("telecommunicationusecode");
            data[2] = new ID("telecommunicationequipmenttype");
            data[3] = new ST("emailaddress");
            data[4] = new NM("countrycode");
            data[5] = new NM("areaOrcitycode");
            data[6] = new NM("localnumber");
            data[7] = new NM("extension");
            data[8] = new ST("anytext");
            data[9] = new ST("extensionprefix");
            data[10] = new ST("speeddialcode");
            data[11] = new ST("unformattedtelephonenumber");
        }
        public ST telephonenumber { get { return data[0] as ST; } set { data[0] = value; } }
        public ID telecommunicationusecode { get { return data[1] as ID; } set { data[1] = value; } }
        public ID telecommunicationequipmenttype { get { return data[2] as ID; } set { data[2] = value; } }
        public ST emailaddress { get { return data[3] as ST; } set { data[3] = value; } }
        public NM countrycode { get { return data[4] as NM; } set { data[4] = value; } }
        public NM areaOrcitycode { get { return data[5] as NM; } set { data[5] = value; } }
        public NM localnumber { get { return data[6] as NM; } set { data[6] = value; } }
        public NM extension { get { return data[7] as NM; } set { data[7] = value; } }
        public ST anytext { get { return data[8] as ST; } set { data[8] = value; } }
        public ST extensionprefix { get { return data[9] as ST; } set { data[9] = value; } }
        public ST speeddialcode { get { return data[10] as ST; } set { data[10] = value; } }
        public ST unformattedtelephonenumber { get { return data[11] as ST; } set { data[11] = value; } }
    }

    public class DLN : compositeField
    {
        public DLN(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new ST("driverlicensenumber");
            data[1] = new IS("issuingstate_province_country");
            data[2] = new DT("expirationdate");
        }
        public ST driverlicensenumber { get { return data[0] as ST; } set { data[0] = value; } }
        public IS issuingstate_province_country { get { return data[1] as IS; } set { data[1] = value; } }
        public DT expirationdate { get { return data[2] as DT; } set { data[2] = value; } }
    }

    public class CWE : compositeField
    {
        public CWE(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[9];
            data[0] = new ST("identifier");
            data[1] = new ST("text");
            data[2] = new ID("nameofcodingsystem");
            data[3] = new ST("alternateidentifier");
            data[4] = new ST("alternatetext");
            data[5] = new ID("nameofalternatecodingsystem");
            data[6] = new ST("codingsystemversionID");
            data[7] = new ST("alternatecodingsystemversionID");
            data[8] = new ST("originaltext");
        }
        public ST identifier { get { return data[0] as ST; } set { data[0] = value; } }
        public ST text { get { return data[1] as ST; } set { data[1] = value; } }
        public ID nameofcodingsystem { get { return data[2] as ID; } set { data[2] = value; } }
        public ST alternateidentifier { get { return data[3] as ST; } set { data[3] = value; } }
        public ST alternatetext { get { return data[4] as ST; } set { data[4] = value; } }
        public ID nameofalternatecodingsystem { get { return data[5] as ID; } set { data[5] = value; } }
        public ST codingsystemversionID { get { return data[6] as ST; } set { data[6] = value; } }
        public ST alternatecodingsystemversionID { get { return data[7] as ST; } set { data[7] = value; } }
        public ST originaltext { get { return data[8] as ST; } set { data[8] = value; } }
    }

  
    public class XON : compositeField
    {
        public XON(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[8];
            data[0] = new ST("organizationname");
            data[1] = new IS("organizationnametypecode");
            data[2] = new NM("checkdigit");
            data[3] = new ID("codeidentifyingthecheckdigitschemeemployed");
            data[4] = new HD(this,"assigningauthority");
            data[5] = new IS("identifiertypecode");
            data[6] = new HD(this,"assigningfacilityID");
            data[7] = new ID("NameRepresentationcode");
        }
        public ST organizationname { get { return data[0] as ST; } set { data[0] = value; } }
        public IS organizationnametypecode { get { return data[1] as IS; } set { data[1] = value; } }
        public NM checkdigit { get { return data[2] as NM; } set { data[2] = value; } }
        public ID codeidentifyingthecheckdigitschemeemployed { get { return data[3] as ID; } set { data[3] = value; } }
        public HD assigningauthority { get { return data[4] as HD; } set { data[4] = value; } }
        public IS identifiertypecode { get { return data[5] as IS; } set { data[5] = value; } }
        public HD assigningfacilityID { get { return data[6] as HD; } set { data[6] = value; } }
        public ID NameRepresentationcode { get { return data[7] as ID; } set { data[7] = value; } }
    }

    public class PL : compositeField
    {
        public PL(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[8];
            data[0] = new IS("pointofcare");
            data[1] = new IS("room");
            data[2] = new IS("bed");
            data[3] = new IS("locationstatus");
            data[4] = new IS("personlocationtype");
            data[5] = new IS("building");
            data[6] = new IS("floor");
            data[7] = new ST("Locationdescription");
        }
        public IS pointofcare { get { return data[0] as IS; } set { data[0] = value; } }
        public IS room { get { return data[1] as IS; } set { data[1] = value; } }
        public IS bed { get { return data[2] as IS; } set { data[2] = value; } }
        public IS locationstatus { get { return data[3] as IS; } set { data[3] = value; } }
        public IS personlocationtype { get { return data[4] as IS; } set { data[4] = value; } }
        public IS building { get { return data[5] as IS; } set { data[5] = value; } }
        public IS floor { get { return data[6] as IS; } set { data[6] = value; } }
        public ST Locationdescription { get { return data[7] as ST; } set { data[7] = value; } }
    }

    public class FC : compositeField
    {
        public FC(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[2];
            data[0] = new IS("FinancialClass");
            data[1] = new TS("EffectiveDate");
        }
        public IS FinancialClass { get { return data[0] as IS; } set { data[0] = value; } }
        public TS EffectiveDate { get { return data[1] as TS; } set { data[1] = value; } }
    }

    public class CP : compositeField
    {
        public CP(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[6];
            data[0] = new MO("price");
            data[1] = new ID("pricetype");
            data[2] = new NM("fromvalue");
            data[3] = new NM("tovalue");
            data[4] = new CE(this,"rangeunits");
            data[5] = new ID("rangetype");
        }
        public MO price { get { return data[0] as MO; } set { data[0] = value; } }
        public ID pricetype { get { return data[1] as ID; } set { data[1] = value; } }
        public NM fromvalue { get { return data[2] as NM; } set { data[2] = value; } }
        public NM tovalue { get { return data[3] as NM; } set { data[3] = value; } }
        public CE rangeunits { get { return data[4] as CE; } set { data[4] = value; } }
        public ID rangetype { get { return data[5] as ID; } set { data[5] = value; } }
    }

    public class JCC : compositeField
    {
        public JCC(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[2];
            data[0] = new IS("jobcode");
            data[1] = new IS("jobclass");
        }
        public IS jobcode { get { return data[0] as IS; } set { data[0] = value; } }
        public IS jobclass { get { return data[1] as IS; } set { data[1] = value; } }
    }

    public class TQ : compositeField
    {
        public TQ(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[12];
            data[0] = new CQ(this, "quantity");
            data[1] = new CM(this,"interval");
            data[2] = new ST("duration");
            data[3] = new TS("startdateOrtime");
            data[4] = new TS("enddateOrtime");
            data[5] = new ST("priority");
            data[6] = new ST("condition");
            data[7] = new ST("text");
            data[8] = new ST("conjunction");
            data[9] = new CM(this,"ordersequencing");
            data[10] = new CE(this, "occurrenceduration");
            data[11] = new NM("totaloccurences");
        }
        public CQ quantity { get { return data[0] as CQ; } set { data[0] = value; } }
        public CM interval { get { return data[1] as CM; } set { data[1] = value; } }
        public ST duration { get { return data[2] as ST; } set { data[2] = value; } }
        public TS startdateOrtime { get { return data[3] as TS; } set { data[3] = value; } }
        public TS enddateOrtime { get { return data[4] as TS; } set { data[4] = value; } }
        public ST priority { get { return data[5] as ST; } set { data[5] = value; } }
        public ST condition { get { return data[6] as ST; } set { data[6] = value; } }
        public ST text { get { return data[7] as ST; } set { data[7] = value; } }
        public ST conjunction { get { return data[8] as ST; } set { data[8] = value; } }
        public CM ordersequencing { get { return data[9] as CM; } set { data[9] = value; } }
        public CE occurrenceduration { get { return data[10] as CE; } set { data[10] = value; } }
        public NM totaloccurences { get { return data[11] as NM; } set { data[11] = value; } }
    }

    public class CQ : compositeField
    {
        public CQ(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[2];
            data[0] = new NM("quantity");
            data[1] = new CE(this,"units");
        }
        public NM quantity { get { return data[0] as NM; } set { data[0] = value; } }
        public CE units { get { return data[1] as CE; } set { data[1] = value; } }
    }

    public class DLD : compositeField
    {
        public DLD(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[2];
            data[0] = new IS("dischargelocation");
            data[1] = new TS("effectivedate");
        }
        public IS dischargelocation { get { return data[0] as IS; } set { data[0] = value; } }
        public TS effectivedate { get { return data[1] as TS; } set { data[1] = value; } }
    }
}
