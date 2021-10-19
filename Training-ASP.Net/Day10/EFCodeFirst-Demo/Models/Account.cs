using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirst_Demo.Models
{
    public class Account
    {
        #region Properties
        [Key]
        public int AccNo { get; set; }
        public string AccName { get; set; }
        public string AccType { get; set; }
        public double AccBalance { get; set; }
        public bool AccIsActive { get; set; }
        #endregion
    }
}