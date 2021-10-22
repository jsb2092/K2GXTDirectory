using System.Collections.Generic;
using System.Linq;

namespace RepeaterQTH.Components
{
    public class PageHistoryState
    {
        private List<string> previousPages;

        public PageHistoryState()
        {
            previousPages = new List<string>();
        }
        public void AddPageToHistory(string pageName)
        {
            previousPages.Add(pageName);
            if (previousPages.Count > 50)
            {
                previousPages.RemoveAt(0);
            }
        }

        public string GetGoBackPage()
        {
            if (previousPages.Count > 1)
            {
                // remove the current page we are coming from
                previousPages.RemoveAt(previousPages.Count-1);
                var toReturn = previousPages.ElementAt(previousPages.Count - 1);
                // now remove the page we are going to, because it's about to be added again.
                previousPages.RemoveAt(previousPages.Count-1);
                return toReturn;
            }

            // Can't go back because you didn't navigate enough
            return previousPages.FirstOrDefault();
        }

        public bool CanGoBack()
        {
            return previousPages.Count > 1;
        }
    }
}