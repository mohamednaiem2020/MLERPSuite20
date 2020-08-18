using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminObject
    {
        #region Constructor
        public AdminObject()
        {
        }
        #endregion
        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectId { get; set; }
        public virtual ICollection<AdminObjectLanguage> ObjectLanguages { get; set; }
        [Required]
        public string ObjectDescription { get; set; }
        
        [Required]
        public byte IsFixedList { get; set; }


        ///10000001 Package name
        ///10000002 Package description
        ///10000003 Module
        ///10000004 Right
        ///10000005 Screen level
        ///10000006 Screen
        ///10000007 workflow master
        ///10000008 Step Status
        ///10000009 Trans Status
        ///10100001 Return type
        ///10100002 Sales type




        ///10000100 Chart
        ///10000101 Chart level
        ///10000102 Currency
        ///10000103 Nationality
        ///10000104 document
        ///10000105 step
        ///10000106 Actor


        ///10100100 Customer
        ///10100101 Category
        ///10100102 Category Level
        ///10100103 Item master long name
        ///10100104 Item master short name
        ///10100105 Unit of measure
        ///10100106 Location
        ///10100107 Location level
        ///10100108 Payment method
        ///10100109 Terminal
        ///10100110 Price header




        #endregion
    }
}
