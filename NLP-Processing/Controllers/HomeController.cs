using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using edu.stanford.nlp.parser;
using edu.stanford.nlp.tagger.maxent;

namespace NLP_Processing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var tagger = new MaxentTagger(@"C:\Projects\NLP-Processing\stanford-postagger-full-2014-06-16\models\wsj-0-18-bidirectional-nodistsim.tagger");
            var sentences = MaxentTagger.tokenizeText(new java.io.StringReader(@"A cat is an animal")).toArray();
            //sentences = new java.util.ArrayList(sentences);
            foreach(var s in sentences)
            {
                var taggedSentence = tagger.tagSentence((java.util.ArrayList)s).toArray();
                var results = "";
                foreach (var tag in taggedSentence)
                {
                    results += tag.ToString() + "\n";
                }
                ViewBag.results += results;
            };
            ViewBag.Title = "Home Page";
            

            return View();
        }
    }
}
