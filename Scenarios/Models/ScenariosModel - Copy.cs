using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Scenarios.Models
{
    public class ScenariosModelXYZ
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Data
        {

            private DataScenario[] scenarioField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Scenario")]
            public DataScenario[] Scenario
            {
                get
                {
                    return this.scenarioField;
                }
                set
                {
                    this.scenarioField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DataScenario
        {

            private int scenarioIDField;

            private string nameField;

            private string surnameField;

            private string forenameField;

            private string userIDField;

            private System.DateTime sampleDateField;

            private System.DateTime creationDateField;

            private int numMonthsField;

            private int marketIDField;

            private bool marketIDFieldSpecified;

            private int networkLayerIDField;

            private bool networkLayerIDFieldSpecified;

            /// <remarks/>
            public int ScenarioID
            {
                get
                {
                    return this.scenarioIDField;
                }
                set
                {
                    this.scenarioIDField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string Surname
            {
                get
                {
                    return this.surnameField;
                }
                set
                {
                    this.surnameField = value;
                }
            }

            /// <remarks/>
            public string Forename
            {
                get
                {
                    return this.forenameField;
                }
                set
                {
                    this.forenameField = value;
                }
            }

            /// <remarks/>
            public string UserID
            {
                get
                {
                    return this.userIDField;
                }
                set
                {
                    this.userIDField = value;
                }
            }

            /// <remarks/>
            public System.DateTime SampleDate
            {
                get
                {
                    return this.sampleDateField;
                }
                set
                {
                    this.sampleDateField = value;
                }
            }

            /// <remarks/>
            public System.DateTime CreationDate
            {
                get
                {
                    return this.creationDateField;
                }
                set
                {
                    this.creationDateField = value;
                }
            }

            /// <remarks/>
            public int NumMonths
            {
                get
                {
                    return this.numMonthsField;
                }
                set
                {
                    this.numMonthsField = value;
                }
            }

            /// <remarks/>
            public int MarketID
            {
                get
                {
                    return this.marketIDField;
                }
                set
                {
                    this.marketIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool MarketIDSpecified
            {
                get
                {
                    return this.marketIDFieldSpecified;
                }
                set
                {
                    this.marketIDFieldSpecified = value;
                }
            }

            /// <remarks/>
            /// 


            public int NetworkLayerID
            {
                get
                {
                    return this.networkLayerIDField;
                }
                set
                {
                    this.networkLayerIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NetworkLayerIDSpecified
            {
                get
                {
                    return this.networkLayerIDFieldSpecified;
                }
                set
                {
                    this.networkLayerIDFieldSpecified = value;
                }
            }
        }




        //        <ScenarioID>1</ScenarioID>
        //<Name>Scenario1</Name>
        //<Surname>BALDWIN</Surname>
        //<Forename>EDWARD</Forename>
        //<UserID>6F55DFD1-A235-4BAE-B958-C1A0AB4D5236</UserID>
        //<SampleDate>2013-02-01T06:02:00</SampleDate>
        //<CreationDate>2013-02-01T13:00:00</CreationDate>
        //<NumMonths>12</NumMonths>
        //<MarketID>2</MarketID>
        //<NetworkLayerID>1</NetworkLayerID>
    }
}