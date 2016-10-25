//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System.Runtime.CompilerServices;
using System.Collections.Generic;
using GSF.ASN1;
using GSF.ASN1.Attributes;
using GSF.ASN1.Coders;

namespace GSF.MMS.Model
{
    
    [ASN1PreparedElement]
    [ASN1Sequence(Name = "GetDataExchangeAttributes_Response", IsSet = false)]
    public class GetDataExchangeAttributes_Response : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(GetDataExchangeAttributes_Response));
        private Identifier accessControlList_;

        private bool accessControlList_present;
        private bool inUse_;


        private ICollection<TypeDescription> listOfRequestTypeDescriptions_;


        private ICollection<TypeDescription> listOfResponseTypeDescriptions_;


        private Identifier programInvocation_;

        private bool programInvocation_present;

        [ASN1Boolean(Name = "")]
        [ASN1Element(Name = "inUse", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public bool InUse
        {
            get
            {
                return inUse_;
            }
            set
            {
                inUse_ = value;
            }
        }

        [ASN1SequenceOf(Name = "listOfRequestTypeDescriptions", IsSetOf = false)]
        [ASN1Element(Name = "listOfRequestTypeDescriptions", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public ICollection<TypeDescription> ListOfRequestTypeDescriptions
        {
            get
            {
                return listOfRequestTypeDescriptions_;
            }
            set
            {
                listOfRequestTypeDescriptions_ = value;
            }
        }

        [ASN1SequenceOf(Name = "listOfResponseTypeDescriptions", IsSetOf = false)]
        [ASN1Element(Name = "listOfResponseTypeDescriptions", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public ICollection<TypeDescription> ListOfResponseTypeDescriptions
        {
            get
            {
                return listOfResponseTypeDescriptions_;
            }
            set
            {
                listOfResponseTypeDescriptions_ = value;
            }
        }

        [ASN1Element(Name = "programInvocation", IsOptional = true, HasTag = true, Tag = 3, HasDefaultValue = false)]
        public Identifier ProgramInvocation
        {
            get
            {
                return programInvocation_;
            }
            set
            {
                programInvocation_ = value;
                programInvocation_present = true;
            }
        }


        [ASN1Element(Name = "accessControlList", IsOptional = true, HasTag = true, Tag = 4, HasDefaultValue = false)]
        public Identifier AccessControlList
        {
            get
            {
                return accessControlList_;
            }
            set
            {
                accessControlList_ = value;
                accessControlList_present = true;
            }
        }


        public void initWithDefaults()
        {
        }


        public IASN1PreparedElementData PreparedData
        {
            get
            {
                return preparedData;
            }
        }

        public bool isProgramInvocationPresent()
        {
            return programInvocation_present;
        }

        public bool isAccessControlListPresent()
        {
            return accessControlList_present;
        }
    }
}