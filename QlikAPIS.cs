using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qlik.Engine;
using Qlik.Sense.Client;

namespace SenseMeasureImporter
{
    public class QlikAPIS
    {
        private ILocation location = Qlik.Engine.Location.FromUri(new Uri("ws://127.0.0.1:4848"));

        public QlikAPIS()
        {
            location.AsDirectConnectionToPersonalEdition();
        }

        public List<SenseApplication> GetAppList()
        {
            return location.GetAppIdentifiers().Select(a => new SenseApplication { AppName = a.AppName, AppId = a.AppId }).ToList();
        }

        public void SaveMeasure(string AppId, string title, string description, List<string> tags, string definition)
        {
            var appIdentifier = location.AppWithIdOrDefault(AppId);

            var measure = new NxLibraryMeasureDef() { Def = definition, Label = title };

            var properties = new Qlik.Sense.Client.MeasureProperties()
            {
                Title = title,
                Description = description,
                Tags = tags,
                Info = new NxInfo() { Type = "GenericMeasure" },
                Measure = measure
            };

            using (IApp app = location.App(appIdentifier))
            {
                app.CreateMeasure(null, properties);
            }
        }

        public void CheckMeasures(string AppId, List<measure> measures)
        {
            string errorMsg, badFields, dangerousFields;
            var appIdentifier = location.AppWithIdOrDefault(AppId);

            foreach (var m in measures)
            {
                if (m.definition != null)
                {
                    using (var app = location.App(appIdentifier))
                    {
                        errorMsg = app.CheckExpression(m.definition).ErrorMsg;
                        badFields = NxRangeFieldsToString(m.definition, app.CheckExpression(m.definition).BadFieldNames);
                        dangerousFields = NxRangeFieldsToString(m.definition, app.CheckExpression(m.definition).DangerousFieldNames);
                    }


                    m.validationMessage = errorMsg + " " + badFields + "  " + dangerousFields;

                    if (m.validationMessage.Trim().Length > 0)
                    {
                        m.useMeasure = false;
                    }
                    else
                    {
                        m.useMeasure = true;
                    }
                }
                else
                {
                    m.useMeasure = false;
                }
            }
        }

        public string NxRangeFieldsToString(string expressionText, IEnumerable<NxRange> fieldNames)
        {
            string fields = "";

            foreach (var field in fieldNames)
            {
                if (fields.Length > 0)
                {
                    fields += ", ";
                }
                else
                {
                    fields = "Invalid field: ";
                }
                fields = fields + expressionText.Substring(field.From, field.Count);
            }

            return fields;
        }
    }
}
