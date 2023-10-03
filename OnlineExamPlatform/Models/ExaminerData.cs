//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace OnlineExamPlatform.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExaminerData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExaminerData()
        {
            this.CourseTransactions = new HashSet<CourseTransaction>();
            this.ExamHeaders = new HashSet<ExamHeader>();
            this.ExaminationProcesses = new HashSet<ExaminationProcess>();
            this.ExaminerPermissions = new HashSet<ExaminerPermission>();
            this.ProctorPermissions = new HashSet<ProctorPermission>();
            this.QuestionDatas = new HashSet<QuestionData>();
            this.ReportHeaders = new HashSet<ReportHeader>();
            this.StudentPermissions = new HashSet<StudentPermission>();
            this.UserAuthentications = new HashSet<UserAuthentication>();
            this.StudentGroups = new HashSet<StudentGroup>();
        }
    
        public long ExaminerID { get; set; }
        public Nullable<System.Guid> ExaminerGUID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string ExaminerImage { get; set; }


        [Required]
        [Display(Name = "Scientific Degree")]
        public string ScientificDegree { get; set; }



        [Required]
        [Display(Name = "Teaching Start Date")]
        public System.DateTime TeachingStartDate { get; set; }



        [Required]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }



        [Required]
        [Display(Name = "Birth Date")]
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string IpAddress { get; set; }


        [Required]
        [Display(Name = "Gender")]
        public Nullable<int> GenderId { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseTransaction> CourseTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamHeader> ExamHeaders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExaminationProcess> ExaminationProcesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExaminerPermission> ExaminerPermissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProctorPermission> ProctorPermissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionData> QuestionDatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportHeader> ReportHeaders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentPermission> StudentPermissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAuthentication> UserAuthentications { get; set; }
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentGroup> StudentGroups { get; set; }
    }
}