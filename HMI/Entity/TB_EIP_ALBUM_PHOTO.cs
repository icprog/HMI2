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
    
    public partial class TB_EIP_ALBUM_PHOTO
    {
        public string PHOTO_GUID { get; set; }
        public string ALBUM_GUID { get; set; }
        public string FILE_ID { get; set; }
        public string THUMBNAIL_FILE_ID { get; set; }
        public string PHOTO_TOPIC { get; set; }
        public string PHOTO_DESC { get; set; }
        public Nullable<bool> FRONT_COVER { get; set; }
        public Nullable<int> REVIEW_COUNT { get; set; }
        public Nullable<int> COMMEND_COUNT { get; set; }
        public string CREATE_FROM { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public string MODIFY_FROM { get; set; }
        public Nullable<System.DateTime> MODIFY_DATE { get; set; }
        public string MODIFY_USER { get; set; }
        public string RESIZE_FILE_ID { get; set; }
    }
}
