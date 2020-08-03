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
        [Required]
        public int ObjectId { get; set; }
        [Required]
        public string ObjectDescription { get; set; }
        public byte IsFixedList { get; set; }

        ///1 Customer
        ///2 Category
        ///3 Category Level
        ///4 Item master long name
        ///5 Item master short name
        ///6 Unit of measure
        ///7 Location
        ///8 Location level
        ///9 Return type
        ///10 Payment method
        ///10 Sales type
        ///11 Terminal
        ///12 Price header
        ///13 Chart
        ///14 Chart level
        ///15 Currency
        ///16 Module
        ///17 Nationality
        ///18 Package name
        ///19 Package description
        ///20 Right
        ///21 Screen
        ///22 document
        ///23 workflow master
        ///24 step
        ///25 Actor
        #endregion
    }
}
