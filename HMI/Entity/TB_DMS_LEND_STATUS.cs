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
    
    public partial class TB_DMS_LEND_STATUS
    {
        public string DOC_ID { get; set; }
        public string LEND_USER { get; set; }
        public string DOC_VERSION { get; set; }
        public string LEND_FLOW { get; set; }
        public string APPROVE_USER { get; set; }
        public string LEND_REASON { get; set; }
        public Nullable<System.DateTime> LEND_START { get; set; }
        public Nullable<System.DateTime> LEND_END { get; set; }
        public string APPROVE_STATUS { get; set; }
        public string APPROVE_COMMENT { get; set; }
        public string FLOW_XML { get; set; }
        public Nullable<System.DateTime> ADD_TIME { get; set; }
        public string WKF_TASK_ID { get; set; }
        public Nullable<System.DateTime> FINISH_TIME { get; set; }
    }
}
