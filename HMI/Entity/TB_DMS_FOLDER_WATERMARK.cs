//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMI.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_DMS_FOLDER_WATERMARK
    {
        public string FOLDER_ID { get; set; }
        public string USE_TYPE { get; set; }
        public Nullable<bool> ADD_PDF_SUMMARY { get; set; }
        public Nullable<bool> USE_TXT_MARK { get; set; }
        public Nullable<bool> SYS_TXT_USE { get; set; }
        public Nullable<int> SYS_TXT_ROTATION { get; set; }
        public string SYS_TXT_COLOR { get; set; }
        public Nullable<int> SYS_TXT_SIZE { get; set; }
        public string SYS_TXT_POSITION { get; set; }
        public Nullable<bool> DEF_TXT_USE { get; set; }
        public string DEF_TXT_VALUE { get; set; }
        public Nullable<int> DEF_TXT_ROTATION { get; set; }
        public string DEF_TXT_COLOR { get; set; }
        public Nullable<int> DEF_TXT_SIZE { get; set; }
        public string DEF_TXT_POSITION { get; set; }
        public Nullable<bool> USE_IMG_MARK { get; set; }
        public string IMG_FILE_ID { get; set; }
        public Nullable<int> IMG_ROTATION { get; set; }
        public string IMG_POSITION { get; set; }
        public int SYS_TXT_TRANSPARENCY { get; set; }
        public int DEF_TXT_TRANSPARENCY { get; set; }
        public bool ADD_PDF_SYSDATE { get; set; }
        public bool ADD_PDF_SYSPATH { get; set; }
    }
}
