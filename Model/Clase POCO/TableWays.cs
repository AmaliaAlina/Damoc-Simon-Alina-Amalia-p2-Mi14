//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PictureManagerLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableWays
    {
        public int Id { get; set; }
        public bool Is_Deleted { get; set; }
    
        public virtual Media Medium { get; set; }
        public virtual Tags Tag { get; set; }
        public virtual TagType TagType { get; set; }
    }
}