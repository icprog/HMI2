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
    
    public partial class TB_EIP_SMS_MSG_DETAIL
    {
        public string MSG_ID { get; set; }
        public string DETAIL_ID { get; set; }
        public int SEND_SEQ { get; set; }
        public int USED_MSG_COUNT { get; set; }
        public int REMAIN_COUNT { get; set; }
        public string RECEIVER_NAME { get; set; }
        public string RECEIVER_PHONE { get; set; }
        public int SEND_RESULT { get; set; }
        public System.DateTime SEND_TIME { get; set; }
        public string ERROR_MSG { get; set; }
        public System.DateTime CREATE_TIME { get; set; }
        public string CREATE_USER_GUID { get; set; }
        public string CREATE_FROM { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }
        public string UPDATE_USER_GUID { get; set; }
        public string UPDATE_FROM { get; set; }
    }
}
