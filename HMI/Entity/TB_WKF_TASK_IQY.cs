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
    
    public partial class TB_WKF_TASK_IQY
    {
        public string IQY_ID { get; set; }
        public string TASK_ID { get; set; }
        public string SITE_ID { get; set; }
        public Nullable<int> NODE_SEQ { get; set; }
        public string PARENT_IQY_ID { get; set; }
        public Nullable<int> IQY_STATUS { get; set; }
        public Nullable<int> IQY_RESULT { get; set; }
        public Nullable<int> IQY_LEVEL { get; set; }
        public string IQY_USER_ID { get; set; }
        public Nullable<int> IQY_SEQ { get; set; }
        public string FORM_USER_ID { get; set; }
        public string CONTENT { get; set; }
        public Nullable<System.DateTime> BEGIN_TIME { get; set; }
        public Nullable<System.DateTime> RESPONSE_TIME { get; set; }
        public Nullable<bool> IS_SCRIPT_IQY { get; set; }
        public string FILE_GROUP_ID { get; set; }
        public string IQY_COMMENT { get; set; }
        public Nullable<bool> IS_APPLICANT { get; set; }
        public string AGENT_USER_GUID { get; set; }
        public Nullable<bool> IS_READ { get; set; }
    }
}
