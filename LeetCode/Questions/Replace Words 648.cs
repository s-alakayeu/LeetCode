using System.Text;

namespace LeetCode.Questions;

public static class Replace_Words_648
{
    public static string ReplaceWords(IList<string> dictionary, string sentence)
    {
        dictionary = dictionary.OrderBy(x => x.Length).ToList();
        
        var sentenceBuilder = new StringBuilder(sentence);

        var prevIsEmptySpace = true;
        for (var i = 0; i < sentenceBuilder.Length; i++)
        {
            if (sentenceBuilder[i] == ' ')
            {
                prevIsEmptySpace = true;
                continue;
            }

            if (!prevIsEmptySpace)
            {
                continue;
            }

            prevIsEmptySpace = false;
            
            foreach (var root in dictionary)
            {
                var match = true;
                
                for (var j = 0; j < root.Length; j++)
                {
                    if (j + i == sentenceBuilder.Length || root[j] != sentenceBuilder[j + i])
                    {
                        match = false;
                        break;
                    }
                }
                
                if (match)
                {
                    var endIndex = i + root.Length;
                    
                    while (endIndex < sentenceBuilder.Length)
                    {
                        if (sentenceBuilder[endIndex] == ' ')
                        {
                            break;
                        }

                        endIndex++;
                    }

                    sentenceBuilder.Remove(i, endIndex - i);
                    sentenceBuilder.Insert(i, root);
                    
                    break;
                }
            }
        }

        return sentenceBuilder.ToString();
    }
}