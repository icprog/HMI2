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
    
    public partial class TB_EIP_PRIV_MESS
    {
        public string MESSAGE_GUID { get; set; }
        public string TOPIC { get; set; }
        public string MESSAGE_CONTENT { get; set; }
        public string MESSAGE_TO { get; set; }
        public string MESSAGE_FROM { get; set; }
        public string REPLY_MESSAGE_GUID { get; set; }
        public System.DateTime CREATE_TIME { get; set; }
        public Nullable<System.DateTime> READED_TIME { get; set; }
        public Nullable<System.DateTime> REPLY_TIME { get; set; }
        public bool FROM_DELETED { get; set; }
        public bool TO_DELETED { get; set; }
        public string FILE_GROUP_ID { get; set; }
    }
}
