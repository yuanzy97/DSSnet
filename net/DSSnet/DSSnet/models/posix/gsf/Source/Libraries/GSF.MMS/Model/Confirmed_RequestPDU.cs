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
    [ASN1Sequence(Name = "Confirmed_RequestPDU", IsSet = false)]
    public class Confirmed_RequestPDU : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Confirmed_RequestPDU));
        private Unsigned32 invokeID_;


        private ICollection<Modifier> listOfModifiers_;

        private bool listOfModifiers_present;


        private ConfirmedServiceRequest service_;


        private Request_Detail service_ext_;

        private bool service_ext_present;

        [ASN1Element(Name = "invokeID", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public Unsigned32 InvokeID
        {
            get
            {
                return invokeID_;
            }
            set
            {
                invokeID_ = value;
            }
        }

        [ASN1SequenceOf(Name = "listOfModifiers", IsSetOf = false)]
        [ASN1Element(Name = "listOfModifiers", IsOptional = true, HasTag = false, HasDefaultValue = false)]
        public ICollection<Modifier> ListOfModifiers
        {
            get
            {
                return listOfModifiers_;
            }
            set
            {
                listOfModifiers_ = value;
                listOfModifiers_present = true;
            }
        }

        [ASN1Element(Name = "service", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public ConfirmedServiceRequest Service
        {
            get
            {
                return service_;
            }
            set
            {
                service_ = value;
            }
        }

        [ASN1Element(Name = "service-ext", IsOptional = true, HasTag = true, Tag = 79, HasDefaultValue = false)]
        public Request_Detail Service_ext
        {
            get
            {
                return service_ext_;
            }
            set
            {
                service_ext_ = value;
                service_ext_present = true;
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

        public bool isListOfModifiersPresent()
        {
            return listOfModifiers_present;
        }

        public bool isService_extPresent()
        {
            return service_ext_present;
        }
    }
}