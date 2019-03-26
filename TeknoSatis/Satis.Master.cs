using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknoBLL.Repositories;
using TeknoDAL.Context;

namespace TeknoSatis
{
    public partial class Satis : System.Web.UI.MasterPage
    {
        MarkaRepository repoMarka = new MarkaRepository();
        //ModelRepository repoModel = new ModelRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                foreach (Marka m in repoMarka.MarkaListele())
                {
                    MenuItem mitm = new MenuItem();
                    mitm.Text = m.Markasi;
                    mitm.Value = m.Id.ToString();
                    mnuMarkalar.Items.Add(mitm);
                    foreach (Model mdl in m.Modeller)
                    {
                        MenuItem citm = new MenuItem();
                        citm.Text = mdl.Modeli;
                        citm.Value = mdl.Id.ToString();
                        mitm.ChildItems.Add(citm);
                    }
                }
            }
        }

        protected void mnuMarkalar_MenuItemClick(object sender, MenuEventArgs e)
        {
            //Response.Write(e.Item.Text); //Seçilen elemanın text'ini verir.
            //Response.Write(e.Item.Value); //Seçilen elemanın value'sunu verir.
            string[] Idler = e.Item.ValuePath.Split('/');
            string MarkaID = Idler[0];
            string ModelID = "0";
            if (Idler.Length > 1)
                ModelID = Idler[1];
            Response.Redirect("Default.aspx?markaId=" + MarkaID + "&modelId=" + ModelID);
        }
    }
}