//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr23106_tiagnirenko_4.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vedomosti
    {
        public int IdVedomosti { get; set; }
        public int IdAttestation { get; set; }
        public int IdStudent { get; set; }
        public string TheNumberOfPointsForTheExam { get; set; }
        public string FinalGrade { get; set; }
        public Nullable<System.DateTime> RecordingDate { get; set; }
    
        public virtual Attestation Attestation { get; set; }
        public virtual Student Student { get; set; }
    }
}
