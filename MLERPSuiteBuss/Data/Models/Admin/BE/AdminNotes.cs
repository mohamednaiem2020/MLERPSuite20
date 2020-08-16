using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminNotes
    {
        #region Constructor
        public AdminNotes()
        {
        }
        #endregion

        #region Properties
   
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
      
        public int NoteId { get; set; }
        [Required]
        public string NoteDescription { get; set; }
        #endregion
    }
}
