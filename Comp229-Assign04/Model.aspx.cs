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
        protected string vName;
        protected string vFaction;
        protected void Page_Load(object sender, EventArgs e)
        {
         vName = Request.QueryString["name"];
         vFaction = Request.QueryString["faction"];

            if (name != null && faction != null)
            {
                basestats = Global.models.FirstOrDefault(tModel => tModel.name == vName && tModel.faction == vFaction);
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

        protected void Update_Click(object sender, EventArgs e)
        {
            string url = string.Format("~/Update.aspx?name={0}&faction={1}", vName, vFaction);
            Response.Redirect(url);
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            //remove based on vname and vfaction          
            Global.models.RemoveAll(tModel => tModel.name == vName && tModel.faction == vFaction);
            Response.Redirect("~/Default.aspx");
        }
    }
}