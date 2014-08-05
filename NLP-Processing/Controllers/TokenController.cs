using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using edu.stanford.nlp.parser;
using edu.stanford.nlp.tagger.maxent;

namespace NLP_Processing.Controllers
{
    public class TokenController : ApiController
    {

        // GET api/Token
        public string Get(string word)
        {
            var tagger = new MaxentTagger(@"C:\Projects\NLP-Processing\stanford-postagger-full-2014-06-16\models\wsj-0-18-bidirectional-nodistsim.tagger");
            var sentences = MaxentTagger.tokenizeText(new java.io.StringReader(word)).toArray();
            var results = "";
            foreach (var s in sentences)
            {
                var taggedSentence = tagger.tagSentence((java.util.ArrayList)s).toArray();
                foreach (var tag in taggedSentence)
                {
                    results += tag.ToString() + " - ";
                }
            };

            return results;
        }
    }
}
