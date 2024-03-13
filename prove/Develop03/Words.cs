using System;

class Words
{
    private readonly List<string> _wordsList; // Encapsulate list of individual words in scripture as _wordsList
    private int _wordsCount; // Encapsulate Total number of words

    public Words(Scripture scripture)
    {
        _wordsList = scripture.ToString().Split(" ").ToList(); // Split the scripture text into words and store them in the list
        _wordsCount = _wordsList.Count; // Count how many words are in the list
    }

    public void HideWords()
    {
        int numWordsToRemove = 3; // Hide 3 words
        Random random = new Random();

        // Hide random words until 3 words or all words words are hidden
        while (_wordsCount > 0 && numWordsToRemove > 0)
        {
            int rndIndex = random.Next(0, _wordsList.Count); // Generate a random index to select a word from the list
            if (!_wordsList[rndIndex].Contains('_')) // Check if the random word selcected has already been hidden
            {
                _wordsList[rndIndex] = new string('_', _wordsList[rndIndex].Length); // Replace the selected word with a _s equal to it's length
                numWordsToRemove -= 1; // Decrease number of words left to remove by 1
                _wordsCount -= 1; // Decrease word count by 1
            }
        }
    }

    public override string ToString()
    {
        return string.Join(" ", _wordsList); // Our updated list words and hidden words
    }

    public bool RemainingWords()
    {
        return _wordsCount > 0;
    }
}
