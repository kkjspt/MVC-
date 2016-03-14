using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Customer
    {
        [Key]
        public int cs_id { get; set; }
        [DisplayName("账号")]
        public string cs_account { get; set; }
        [DisplayName("密码")]
        public string cs_password { get; set; }
        [DisplayName("记住密码")]
        public bool cs_remenber { get; set; }
        [DisplayName("姓名")]
        public string cs_name { get; set; }
        [DisplayName("职务")]
        public string cs_post { get; set; }
        [DisplayName("微信号")]
        public string cs_wx { get; set; }
        [DisplayName("手机号码")]
        public string cs_phone { get; set; }
        [DisplayName("QQ号码")]
        public string cs_qq { get; set; }
        [DisplayName("电子邮件：")]
        public string cs_email { get; set; }
        [DisplayName("电子邮件密码：")]
        public string cs_emailpassword { get; set; }
        [DisplayName("电子邮箱服务器")]
        public string cs_emailsmtp { get; set; }
        [DisplayName("组别")]
        public string cs_group { get; set; }
        [DisplayName("权限")]
        public string cs_competence { get; set; }
        [DisplayName("归属那个经理")]
        public string cs_subordinate { get; set; }
        [DisplayName("超时")]
        public string cs_overtime { get; set; }
        [DisplayName("是否开启")]
        public bool cs_open { get; set; }
        [DisplayName("是否接受数据")]
        public bool cs_dataworking { get; set; }
        [DisplayName("注册时间")]
        public DateTime cs_regdatetime { get; set; }
        [DisplayName("隶属公司")]
        public int cp_id { get; set; }
    }
    public class CustomerDBContext:DbContext
    {
        public DbSet<Customer> Customer{ get; set; }
    }
}