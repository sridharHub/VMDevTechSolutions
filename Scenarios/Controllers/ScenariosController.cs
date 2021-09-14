using Scenarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Scenarios.Controllers
{
    public class ScenariosController : Controller
    {
        // GET: Scenarios
        public ActionResult Index()
        {
            return View(this.GetScenarios(1));
  
        }


        [HttpPost]
        public ActionResult Index(int currentPageIndex)
        {
            return View(this.GetScenarios(currentPageIndex));
        }

        private ScenarioSummary GetScenarios(int currentPage)
        {

            try
            {
                //set maxrows in a page
                int maxRows = 10;
                //Create an instance of ScenarioSummary
                ScenarioSummary scenarioSummary = new ScenarioSummary();

                //Scenarios List
                List<Scenario> Scenarios = new List<Scenario>();

                // Load the XML file using XmlDocument Object
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Server.MapPath("~/App_Data/ExerciseDataXML.xml"));
                //Loop through the selected Nodes.
                foreach (XmlNode node in xmlDoc.SelectNodes("/Data/Scenario"))
                {

                    //var ScenrioRec = new ScenariosModel.DataScenario();
                    var ScenrioRec = new Scenario();

                    if (node["ScenarioID"] != null)
                        ScenrioRec.ScenarioID = int.Parse(node["ScenarioID"].InnerText);

                    if (node["Name"] != null)
                        ScenrioRec.Name = node["Name"].InnerText;

                    if (node["Surname"] != null)
                        ScenrioRec.Surname = node["Surname"].InnerText;

                    if (node["Forename"] != null)
                        ScenrioRec.Forename = node["Forename"].InnerText;

                    if (node["UserID"] != null)
                        ScenrioRec.UserID = node["UserID"].InnerText;

                    if (node["SampleDate"] != null)
                        ScenrioRec.SampleDate = DateTime.Parse(node["SampleDate"].InnerText);

                    if (node["CreationDate"] != null)
                        ScenrioRec.CreationDate = DateTime.Parse(node["CreationDate"].InnerText);

                    if (node["NumMonths"] != null)
                        ScenrioRec.NumMonths = int.Parse(node["NumMonths"].InnerText);

                    if (node["MarketID"] != null)
                        ScenrioRec.MarketID = int.Parse(node["MarketID"].InnerText);

                    if (node["NetworkLayerID"] != null)
                        ScenrioRec.NetworkLayerID = int.Parse(node["NetworkLayerID"].InnerText);


                    //Fetch the Node values and assign it to Model.
                    //Scenarios.Add(new ScenariosModel.DataScenario()
                    //{
                    //    ScenarioID = int.Parse(node["ScenarioID"].InnerText),
                    //    Name = node["Name"].InnerText,
                    //    Surname = node["Surname"].InnerText,
                    //    UserID = node["UserID"].InnerText,
                    //    SampleDate = DateTime.Parse(node["SampleDate"].InnerText),
                    //    CreationDate = DateTime.Parse(node["CreationDate"].InnerText),
                    //    NumMonths = int.Parse(node["NumMonths"].InnerText),
                    //    MarketID = int.Parse(node["MarketID"].InnerText),
                    //    NetworkLayerID = int.Parse(node["NetworkLayerID"].InnerText) 
                    //});

                    // Add item to Scenarios list
                    Scenarios.Add(ScenrioRec);


                }


                scenarioSummary.ScenarioDetails = Scenarios.ToList();

                //Session["ScenarioDetails"] = scenarioModel.ScenarioDetails;


                double pageCount = (double)((decimal)scenarioSummary.ScenarioDetails.Count() / Convert.ToDecimal(maxRows));
                scenarioSummary.PageCount = (int)Math.Ceiling(pageCount);

                //Build Linq query based on the condtions
                scenarioSummary.ScenarioDetails = (from scenario in scenarioSummary.ScenarioDetails
                                                 select scenario)
                            .OrderBy(scenario => scenario.ScenarioID)
                            .Skip((currentPage - 1) * maxRows)
                            .Take(maxRows).ToList();



                scenarioSummary.CurrentPageIndex = currentPage;
                return scenarioSummary;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

