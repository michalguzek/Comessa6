//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comessa6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cuser
    {
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string ip { get; set; }
        public bool isMasterServer { get; set; }
        public bool isServer { get; set; }
    }
}