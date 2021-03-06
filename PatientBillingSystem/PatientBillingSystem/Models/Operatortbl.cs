//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatientBillingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Operatortbl
    {
        public int Operator_ID { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string Operator_Name { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "This field is required.")]
        public string Gender { get; set; }

        [DisplayName("Phone No")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "This field is required.")]
        public long PhoneNo { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "This field is required.")]
        public string O_email { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "This field is required.")]
        public string O_address { get; set; }

        [DisplayName("User Type")]
        [Required(ErrorMessage = "This field is required.")]
        public int userType { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string O_userName { get; set; }

        [DisplayName("Password")]
        [DataType("Password")]
        [Required(ErrorMessage = "This field is required.")]
        public string O_Password { get; set; }
    }
}