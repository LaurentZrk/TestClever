using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestForClever
{
    public partial class Default : System.Web.UI.Page
    {
        public class Account
{
    public string Email { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedDate { get; set; }
    public IList<string> Roles { get; set; }
}
    protected void Page_Load(object sender, EventArgs e)
        {
            string json = @"{
   'Email': 'laurent.rak@dojo.fr',
   'Active': true,
   'CreatedDate': '2023-01-20T00:00:00Z',
   'Roles': [
     'User',
     'Admin'
   ]
 }";
            JToken token = JObject.Parse(json);

            Account account =JsonConvert.DeserializeObject<Account>(json);

            label.Text = account.Email;
        }
    }
}