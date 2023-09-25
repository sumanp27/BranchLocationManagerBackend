using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAPI.Data
{
    
    public class Branch
    {

        public int Id { get; set; }
        public string BU_CODE5 { get; set; }
        public string STATUS { get; set; }
        public DateOnly OPENED_DT { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string STATE_NAME { get; set;}
        public string COUNTRY_NAME { get;set;}
        public string CURRENCY { get; set; }
        public string PHONE { get; set; }
         public string BUSINESS_HOURS { get; set; }
        public decimal LATITUDE { get; set; }
        public decimal LONGITUDE { get; set;}   
    }
}
