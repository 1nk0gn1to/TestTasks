using System.Collections.Generic;

namespace EnglishTeacher.common
{
    public class Words
    {
        List<string> WordsList = new List<string>();

        //public Words(List<string> nword)
        //{
        //    WordsList = nword;
        //}
        public void AddWord(string word)
        {
            WordsList.Add(word);
        }
    }
}
