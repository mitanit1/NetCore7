using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetCore7.Models.SSO
{
    [Table("VIE_SSO_ACCT_PUBLIC")]
    public class Vie_Sso_Acct_Public
    {
        [Key]
        [Column("PCCUID")]
        public decimal pccuid { get; set; }

        [Column("SSO_ACCT")]
        public string sso_acct { get; set; }

        //[Column("FACT_NO")]
        [NotMapped]
        public string fact_no
        {
            get { return local_fact_no; }
            set { local_fact_no = value; }
        }

        [Column("LOCAL_FACT_NO")]
        public string local_fact_no { get; set; }

        [Column("LOCAL_PNL_NM")]
        public string local_pnl_name { get; set; }

        [Column("CHINESE_NM")]
        public string chinese_nm { get; set; }

        [Column("ENGLISH_NM")]
        public string english_nm { get; set; }

        [Column("CONTACT_MAIL")]
        public string contact_mail { get; set; }

        [Column("SEX")]
        public string sex { get; set; }

        [Column("TEL")]
        public string tel { get; set; }

        [Column("DISABLED")]
        public string disabled { get; set; }

        [NotMapped]
        public virtual Vie_Factory vie_factory { get; set; }
        //[Column("DISABLED_DATE")]
        //public DateTime? disabled_date { get; set; }

        //[Column("UPDATE_DATE")]
        //public DateTime? update_date { get; set; }

        public bool IsDisabled()
        {
            return disabled == "Y" ? true : false;
        }
    }
}
