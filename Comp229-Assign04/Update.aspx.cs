using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Comp229_Assign04
{
    public partial class Update : System.Web.UI.Page
    {
        private models.BaseStats basestats;
        
        protected string vName;
        protected string vFaction;
        Global update = new Global();
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

        protected void updatechanges_Click(object sender, EventArgs e)
        {
            
            basestats.name =Convert.ToString(name.Text);
            basestats.faction = Convert.ToString(faction.Text);          
            basestats.rank = Convert.ToInt32(rank.Text);
            basestats._base = Convert.ToInt32(_base.Text);
            basestats.size = Convert.ToInt32(size.Text);
            basestats.deploymentZone = Convert.ToString(deployment.Text);
            basestats.mobility = Convert.ToInt32(mobility.Text);
            basestats.willpower = Convert.ToInt32(willpower.Text);
            basestats.resiliance = Convert.ToInt32(resiliance.Text);
            basestats.wounds = Convert.ToInt32(wounds.Text);



            using (StreamWriter writer = File.CreateText(HostingEnvironment.MapPath("~/Assign04.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, basestats);
            }
         
            Response.Redirect("~/Default.aspx");
        }
    }
}