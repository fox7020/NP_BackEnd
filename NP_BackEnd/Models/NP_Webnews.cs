//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NP_BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NP_Webnews
    {
        public System.Guid Guid { get; set; }
        public string title { get; set; }
        public string artitle { get; set; }
        public string file_name { get; set; }
        public System.DateTime start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public string del_yn { get; set; }
        public string remark { get; set; }
    }
}
