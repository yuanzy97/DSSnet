//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System.Runtime.CompilerServices;
using GSF.ASN1;
using GSF.ASN1.Attributes;
using GSF.ASN1.Coders;

namespace GSF.MMS.Model
{
    
    [ASN1PreparedElement]
    [ASN1Choice(Name = "MMSpdu")]
    public class MMSpdu : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(MMSpdu));
        private Cancel_ErrorPDU cancel_ErrorPDU_;
        private bool cancel_ErrorPDU_selected;
        private Cancel_RequestPDU cancel_RequestPDU_;
        private bool cancel_RequestPDU_selected;
        private Cancel_ResponsePDU cancel_ResponsePDU_;
        private bool cancel_ResponsePDU_selected;
        private Conclude_ErrorPDU conclude_ErrorPDU_;
        private bool conclude_ErrorPDU_selected;
        private Conclude_RequestPDU conclude_RequestPDU_;
        private bool conclude_RequestPDU_selected;
        private Conclude_ResponsePDU conclude_ResponsePDU_;
        private bool conclude_ResponsePDU_selected;
        private Confirmed_ErrorPDU confirmed_ErrorPDU_;
        private bool confirmed_ErrorPDU_selected;
        private Confirmed_RequestPDU confirmed_RequestPDU_;
        private bool confirmed_RequestPDU_selected;


        private Confirmed_ResponsePDU confirmed_ResponsePDU_;
        private bool confirmed_ResponsePDU_selected;
        private Initiate_ErrorPDU initiate_ErrorPDU_;
        private bool initiate_ErrorPDU_selected;
        private Initiate_RequestPDU initiate_RequestPDU_;
        private bool initiate_RequestPDU_selected;
        private Initiate_ResponsePDU initiate_ResponsePDU_;
        private bool initiate_ResponsePDU_selected;
        private RejectPDU rejectPDU_;
        private bool rejectPDU_selected;


        private Unconfirmed_PDU unconfirmed_PDU_;
        private bool unconfirmed_PDU_selected;

        [ASN1Element(Name = "confirmed-RequestPDU", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public Confirmed_RequestPDU Confirmed_RequestPDU
        {
            get
            {
                return confirmed_RequestPDU_;
            }
            set
            {
                selectConfirmed_RequestPDU(value);
            }
        }

        [ASN1Element(Name = "confirmed-ResponsePDU", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public Confirmed_ResponsePDU Confirmed_ResponsePDU
        {
            get
            {
                return confirmed_ResponsePDU_;
            }
            set
            {
                selectConfirmed_ResponsePDU(value);
            }
        }

        [ASN1Element(Name = "confirmed-ErrorPDU", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public Confirmed_ErrorPDU Confirmed_ErrorPDU
        {
            get
            {
                return confirmed_ErrorPDU_;
            }
            set
            {
                selectConfirmed_ErrorPDU(value);
            }
        }


        [ASN1Element(Name = "unconfirmed-PDU", IsOptional = false, HasTag = true, Tag = 3, HasDefaultValue = false)]
        public Unconfirmed_PDU Unconfirmed_PDU
        {
            get
            {
                return unconfirmed_PDU_;
            }
            set
            {
                selectUnconfirmed_PDU(value);
            }
        }


        [ASN1Element(Name = "rejectPDU", IsOptional = false, HasTag = true, Tag = 4, HasDefaultValue = false)]
        public RejectPDU RejectPDU
        {
            get
            {
                return rejectPDU_;
            }
            set
            {
                selectRejectPDU(value);
            }
        }


        [ASN1Element(Name = "cancel-RequestPDU", IsOptional = false, HasTag = true, Tag = 5, HasDefaultValue = false)]
        public Cancel_RequestPDU Cancel_RequestPDU
        {
            get
            {
                return cancel_RequestPDU_;
            }
            set
            {
                selectCancel_RequestPDU(value);
            }
        }


        [ASN1Element(Name = "cancel-ResponsePDU", IsOptional = false, HasTag = true, Tag = 6, HasDefaultValue = false)]
        public Cancel_ResponsePDU Cancel_ResponsePDU
        {
            get
            {
                return cancel_ResponsePDU_;
            }
            set
            {
                selectCancel_ResponsePDU(value);
            }
        }


        [ASN1Element(Name = "cancel-ErrorPDU", IsOptional = false, HasTag = true, Tag = 7, HasDefaultValue = false)]
        public Cancel_ErrorPDU Cancel_ErrorPDU
        {
            get
            {
                return cancel_ErrorPDU_;
            }
            set
            {
                selectCancel_ErrorPDU(value);
            }
        }


        [ASN1Element(Name = "initiate-RequestPDU", IsOptional = false, HasTag = true, Tag = 8, HasDefaultValue = false)]
        public Initiate_RequestPDU Initiate_RequestPDU
        {
            get
            {
                return initiate_RequestPDU_;
            }
            set
            {
                selectInitiate_RequestPDU(value);
            }
        }


        [ASN1Element(Name = "initiate-ResponsePDU", IsOptional = false, HasTag = true, Tag = 9, HasDefaultValue = false)]
        public Initiate_ResponsePDU Initiate_ResponsePDU
        {
            get
            {
                return initiate_ResponsePDU_;
            }
            set
            {
                selectInitiate_ResponsePDU(value);
            }
        }


        [ASN1Element(Name = "initiate-ErrorPDU", IsOptional = false, HasTag = true, Tag = 10, HasDefaultValue = false)]
        public Initiate_ErrorPDU Initiate_ErrorPDU
        {
            get
            {
                return initiate_ErrorPDU_;
            }
            set
            {
                selectInitiate_ErrorPDU(value);
            }
        }


        [ASN1Element(Name = "conclude-RequestPDU", IsOptional = false, HasTag = true, Tag = 11, HasDefaultValue = false)]
        public Conclude_RequestPDU Conclude_RequestPDU
        {
            get
            {
                return conclude_RequestPDU_;
            }
            set
            {
                selectConclude_RequestPDU(value);
            }
        }


        [ASN1Element(Name = "conclude-ResponsePDU", IsOptional = false, HasTag = true, Tag = 12, HasDefaultValue = false)]
        public Conclude_ResponsePDU Conclude_ResponsePDU
        {
            get
            {
                return conclude_ResponsePDU_;
            }
            set
            {
                selectConclude_ResponsePDU(value);
            }
        }


        [ASN1Element(Name = "conclude-ErrorPDU", IsOptional = false, HasTag = true, Tag = 13, HasDefaultValue = false)]
        public Conclude_ErrorPDU Conclude_ErrorPDU
        {
            get
            {
                return conclude_ErrorPDU_;
            }
            set
            {
                selectConclude_ErrorPDU(value);
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


        public bool isConfirmed_RequestPDUSelected()
        {
            return confirmed_RequestPDU_selected;
        }


        public void selectConfirmed_RequestPDU(Confirmed_RequestPDU val)
        {
            confirmed_RequestPDU_ = val;
            confirmed_RequestPDU_selected = true;


            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isConfirmed_ResponsePDUSelected()
        {
            return confirmed_ResponsePDU_selected;
        }


        public void selectConfirmed_ResponsePDU(Confirmed_ResponsePDU val)
        {
            confirmed_ResponsePDU_ = val;
            confirmed_ResponsePDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isConfirmed_ErrorPDUSelected()
        {
            return confirmed_ErrorPDU_selected;
        }


        public void selectConfirmed_ErrorPDU(Confirmed_ErrorPDU val)
        {
            confirmed_ErrorPDU_ = val;
            confirmed_ErrorPDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isUnconfirmed_PDUSelected()
        {
            return unconfirmed_PDU_selected;
        }


        public void selectUnconfirmed_PDU(Unconfirmed_PDU val)
        {
            unconfirmed_PDU_ = val;
            unconfirmed_PDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isRejectPDUSelected()
        {
            return rejectPDU_selected;
        }


        public void selectRejectPDU(RejectPDU val)
        {
            rejectPDU_ = val;
            rejectPDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isCancel_RequestPDUSelected()
        {
            return cancel_RequestPDU_selected;
        }


        public void selectCancel_RequestPDU(Cancel_RequestPDU val)
        {
            cancel_RequestPDU_ = val;
            cancel_RequestPDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isCancel_ResponsePDUSelected()
        {
            return cancel_ResponsePDU_selected;
        }


        public void selectCancel_ResponsePDU(Cancel_ResponsePDU val)
        {
            cancel_ResponsePDU_ = val;
            cancel_ResponsePDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isCancel_ErrorPDUSelected()
        {
            return cancel_ErrorPDU_selected;
        }


        public void selectCancel_ErrorPDU(Cancel_ErrorPDU val)
        {
            cancel_ErrorPDU_ = val;
            cancel_ErrorPDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isInitiate_RequestPDUSelected()
        {
            return initiate_RequestPDU_selected;
        }


        public void selectInitiate_RequestPDU(Initiate_RequestPDU val)
        {
            initiate_RequestPDU_ = val;
            initiate_RequestPDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isInitiate_ResponsePDUSelected()
        {
            return initiate_ResponsePDU_selected;
        }


        public void selectInitiate_ResponsePDU(Initiate_ResponsePDU val)
        {
            initiate_ResponsePDU_ = val;
            initiate_ResponsePDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isInitiate_ErrorPDUSelected()
        {
            return initiate_ErrorPDU_selected;
        }


        public void selectInitiate_ErrorPDU(Initiate_ErrorPDU val)
        {
            initiate_ErrorPDU_ = val;
            initiate_ErrorPDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isConclude_RequestPDUSelected()
        {
            return conclude_RequestPDU_selected;
        }


        public void selectConclude_RequestPDU(Conclude_RequestPDU val)
        {
            conclude_RequestPDU_ = val;
            conclude_RequestPDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_ResponsePDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isConclude_ResponsePDUSelected()
        {
            return conclude_ResponsePDU_selected;
        }


        public void selectConclude_ResponsePDU(Conclude_ResponsePDU val)
        {
            conclude_ResponsePDU_ = val;
            conclude_ResponsePDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ErrorPDU_selected = false;
        }


        public bool isConclude_ErrorPDUSelected()
        {
            return conclude_ErrorPDU_selected;
        }


        public void selectConclude_ErrorPDU(Conclude_ErrorPDU val)
        {
            conclude_ErrorPDU_ = val;
            conclude_ErrorPDU_selected = true;


            confirmed_RequestPDU_selected = false;

            confirmed_ResponsePDU_selected = false;

            confirmed_ErrorPDU_selected = false;

            unconfirmed_PDU_selected = false;

            rejectPDU_selected = false;

            cancel_RequestPDU_selected = false;

            cancel_ResponsePDU_selected = false;

            cancel_ErrorPDU_selected = false;

            initiate_RequestPDU_selected = false;

            initiate_ResponsePDU_selected = false;

            initiate_ErrorPDU_selected = false;

            conclude_RequestPDU_selected = false;

            conclude_ResponsePDU_selected = false;
        }
    }
}