//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RussianRouletteServiceLibrary.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UMessage
    {
        public string Id { get; set; }
        public Nullable<int> SenderId { get; set; }
        public System.DateTime TimeSent { get; set; }
        public string MessageContent { get; set; }
    
        public virtual User User { get; set; }
    }
}
