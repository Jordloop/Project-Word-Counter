
using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/result"] = _ => {
        string userWord = Request.Form["userWord"];
        string userSentence = Request.Form["userSentence"];
        RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
        int result = newCounter.CountRepeats(userWord, userSentence);
        newCounter.SetWordCount(result);
        return View["return.cshtml", newCounter];
      };
    }
  }
}
