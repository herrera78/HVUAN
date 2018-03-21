using Assets.HAVIR.Scripts.Game.Speech;
using Assets.HAVIR.Scripts.Game.Speech.Graph;
using Havir.Api.Speech;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Havir.DataAccess
{
    public class QuestionDataAccess : IDisposable
    {
        Dictionary<string, string> _pedefinedAnswers;
        public QuestionDataAccess()
        {
            XElement xElem2 = XElement.Load("Graph/PredefinedAnswers.xml");
            _pedefinedAnswers = xElem2.Descendants("item")
                                .ToDictionary(x => (string)x.Attribute("id"), x => (string)x.Attribute("value"));
        }

        public void Dispose()
        {
        }

        public List<Question> GetAll()
        {
            var graph = GraphMapper.GetGraphNodes("Graph/dialogo ejemplo.graphml");
            return graph;
        }

        public Dictionary<string, string> GetPredefinedAnswers()
        {
            return _pedefinedAnswers;
        }
    }
}
