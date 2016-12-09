using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class Model : System.Web.UI.Page
    {
        private models.BaseStats basestats;
        protected void Page_Load(object sender, EventArgs e)
        {
         string name = Request.QueryString["name"];
         string faction = Request.QueryString["faction"];

            if (name != null && faction != null)
            {
                basestats = Global.models.FirstOrDefault(tModel => tModel.name == name && tModel.faction == faction);
                 selectedmodel();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        private void selectedmodel()
        {
            modelimg.ImageUrl = basestats.imageUrl;
            name.Text = basestats.name;
            faction.Text = basestats.faction;
            rank.Text = basestats.rank.ToString();
            _base.Text = basestats._base.ToString();
            size.Text = basestats.size.ToString();
            deployment.Text = basestats.deploymentZone;
            traitsrep.DataSource = basestats.traits;
            traitsrep.DataBind();
            typerep.DataSource = basestats.defenseChart;
            typerep.DataBind();
            mobility.Text = basestats.mobility.ToString();
            willpower.Text = basestats.willpower.ToString();
            resiliance.Text = basestats.resiliance.ToString();
            wounds.Text = basestats.wounds.ToString();


        }
    }
}