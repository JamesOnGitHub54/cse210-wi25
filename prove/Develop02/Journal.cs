public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        ///Put new entry in _entries
    }

    public void DisplayAll()
    {
        ///Display all entries in _entries
    }

    public void SaveToFile(string fileName)
    {
        /// Lopp each item in entries and save in file
    }

    public void LoadFromFile(string fileName)
    {
        /// loop each line of file and create Entry objects to put in list
    }

}