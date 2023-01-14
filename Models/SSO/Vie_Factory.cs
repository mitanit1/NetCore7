using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetCore7.Models.SSO
{
    [Table("VIE_FACTORY")]
    public class Vie_Factory
    {
        [Key]
        [Column("FACT_ID")]
        public decimal fact_id { get; set; }

        [Column("FACT_NO")]
        public string fact_no { get; set; }

        [Column("FACT_NAME")]
        public string fact_name { get; set; }

        [NotMapped]
        public string fact_full_name
        {
            get { return fact_no + "-" + fact_name; }
        }


        [Column("AREA_NO")]
        public string area_no { get; set; }

        [Column("AREA_NM")]
        public string area_nm { get; set; }

        //private string _comp_no;
        [NotMapped]
        public string comp_no
        {
            get
            {
                return !string.IsNullOrEmpty(local_comp_no) ? local_comp_no : COMP_NO;
            }
            set { local_comp_no = value; }
        }

        [Column("COMP_NO")]
        public string COMP_NO { get; private set; }

        [Column("FGRP_NO")]
        public string fgrp_no { get; set; }

        [Column("FGRP_NM")]
        public string fgrp_nm { get; set; }

        [Column("OUT_DATE")]
        public string out_date { get; set; }

        [Column("UPD_DATE")]
        public string upd_date { get; set; }

        [Column("LOCAL_COMP_NO")]
        public string local_comp_no { get; set; }
    }
}
