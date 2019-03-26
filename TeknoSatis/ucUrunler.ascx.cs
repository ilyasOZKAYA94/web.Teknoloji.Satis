using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknoBLL.Repositories;

namespace TeknoSatis
{
    public partial class ucUrunler : System.Web.UI.UserControl
    {
        UrunRepository repoUrun = new UrunRepository();
        cSepet spt = new cSepet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string MarkaID = Request.QueryString["markaId"];
                string ModelID = Request.QueryString["modelId"];
                if(string.IsNullOrEmpty(MarkaID) && string.IsNullOrEmpty(ModelID))
                {
                    dlstUrunler.DataSource = repoUrun.UrunListele();
                    dlstUrunler.DataBind();
                }
                else if(ModelID == "0")
                {
                    dlstUrunler.DataSource = repoUrun.UrunListeleByMarka(Convert.ToInt32(MarkaID));
                    dlstUrunler.DataBind();
                }
                else
                {
                    dlstUrunler.DataSource = repoUrun.UrunListeleByMarkaAndModel(Convert.ToInt32(MarkaID), Convert.ToInt32(ModelID));
                    dlstUrunler.DataBind();
                }
            }
        }
        protected void dlstUrunler_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName == "sepet")
            {
                if(Session["sepet"] == null)
                {
                    Session["sepet"] = spt.BosSepet();
                }
                List<cSepet> sepet = (List<cSepet>)Session["sepet"];
                //Seçilen yeni siparişin bilgilerini elde ediyoruz.
                cSepet yeni = new cSepet();
                yeni.UrunId = Convert.ToInt32(e.CommandArgument);
                Label UrunAdi = (Label)e.Item.FindControl("lblUrunAdi");
                Label Fiyat = (Label)e.Item.FindControl("lblFiyat");
                TextBox Adet = (TextBox)e.Item.FindControl("txtAdet");
                yeni.UrunAd = UrunAdi.Text;
                yeni.Adet = Convert.ToInt32(Adet.Text);
                string[] Degerler = Fiyat.Text.Split(' ');
                //Fiyat.Text = Degerler[0]; Ekrandaki fiyatı formatsız hale döndürür.
                yeni.BirimFiyat = Convert.ToDecimal(Degerler[0]);
                yeni.Tutar = yeni.Adet * yeni.BirimFiyat;
                //Daha önceden aynı üründen sepete eklenmiş mi?
                bool Varmi = false;
                foreach (cSepet mevcut in sepet)
                {
                    if(mevcut.UrunId == yeni.UrunId)
                    {
                        Varmi = true;
                        mevcut.Adet += yeni.Adet;
                        mevcut.Tutar += yeni.Tutar;
                        break;
                    }
                }
                if (Varmi == false)
                {
                    sepet.Add(yeni);
                }
                Session["sepet"] = sepet;
                Session["toplamadet"] = spt.ToplamAdet(sepet);
                Session["toplamtutar"] = spt.ToplamTutar(sepet);
            }
        }
    }
}