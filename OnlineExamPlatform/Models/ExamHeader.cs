//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineExamPlatform.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamHeader()
        {
            this.ExamDetails = new HashSet<ExamDetail>();
            this.ExaminationProcesses = new HashSet<ExaminationProcess>();
            this.ReportHeaders = new HashSet<ReportHeader>();
            this.StudentAnswersQuestionInExams = new HashSet<StudentAnswersQuestionInExam>();
        }
    
        public long ExamId { get; set; }
        public Nullable<System.Guid> ExamGUID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public decimal Duration { get; set; }
        public string AcademicYear { get; set; }
        public Nullable<long> ExaminerId { get; set; }
        public Nullable<long> CourseDataID { get; set; }
        public string ExamName { get; set; }
        public string ExamDescription { get; set; }
        public int MarksPerQuestion { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual CourseData CourseData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamDetail> ExamDetails { get; set; }
        public virtual ExaminerData ExaminerData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExaminationProcess> ExaminationProcesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportHeader> ReportHeaders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentAnswersQuestionInExam> StudentAnswersQuestionInExams { get; set; }
    }
}