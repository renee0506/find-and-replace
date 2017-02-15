using Nancy;
using FindNReplace;
using System;
using System.Collections.Generic;

namespace FindNReplace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/newSentence"] = _ =>{
        string sentence = Request.Query["sentence"];
        string word = Request.Query["word"];
        string newWord = Request.Query["new-word"];
        FindNReplaceProgram finder = new FindNReplaceProgram();
        string result = finder.FindAndReplace(sentence, word, newWord);
        return View["result.cshtml", result];
      };
    }
  }
}
