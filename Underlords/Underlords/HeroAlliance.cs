//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Underlords
{
    using System;
    using System.Collections.Generic;
    
    public partial class HeroAlliance
    {
        public int Id { get; set; }
        public int HeroId { get; set; }
        public int AllianceId { get; set; }
    
        public virtual Alliance Alliance { get; set; }
        public virtual Hero Hero { get; set; }
    }
}
