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
    [ASN1Sequence(Name = "FileRename_Request", IsSet = false)]
    public class FileRename_Request : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(FileRename_Request));
        private FileName currentFileName_;


        private FileName newFileName_;

        [ASN1Element(Name = "currentFileName", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public FileName CurrentFileName
        {
            get
            {
                return currentFileName_;
            }
            set
            {
                currentFileName_ = value;
            }
        }

        [ASN1Element(Name = "newFileName", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public FileName NewFileName
        {
            get
            {
                return newFileName_;
            }
            set
            {
                newFileName_ = value;
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
    }
}