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
    [ASN1Choice(Name = "Modifier")]
    public class Modifier : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Modifier));
        private AttachToEventCondition eventModifier_;
        private bool eventModifier_selected;


        private AttachToSemaphore semaphoreModifier_;
        private bool semaphoreModifier_selected;

        [ASN1Element(Name = "eventModifier", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public AttachToEventCondition EventModifier
        {
            get
            {
                return eventModifier_;
            }
            set
            {
                selectEventModifier(value);
            }
        }


        [ASN1Element(Name = "semaphoreModifier", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public AttachToSemaphore SemaphoreModifier
        {
            get
            {
                return semaphoreModifier_;
            }
            set
            {
                selectSemaphoreModifier(value);
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


        public bool isEventModifierSelected()
        {
            return eventModifier_selected;
        }


        public void selectEventModifier(AttachToEventCondition val)
        {
            eventModifier_ = val;
            eventModifier_selected = true;


            semaphoreModifier_selected = false;
        }


        public bool isSemaphoreModifierSelected()
        {
            return semaphoreModifier_selected;
        }


        public void selectSemaphoreModifier(AttachToSemaphore val)
        {
            semaphoreModifier_ = val;
            semaphoreModifier_selected = true;


            eventModifier_selected = false;
        }
    }
}