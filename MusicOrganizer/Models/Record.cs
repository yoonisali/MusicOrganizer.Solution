namespace MusicOrganizer.Models
{
  public class Record
  {
    public string RecordName { get; set; }

    public int Id { get; }

    private static List<Record> _recordList = new List<Record> { };

    public Record(string recordName)
    {
      RecordName = recordName;
      _recordList.Add(this);
      Id = _recordList.Count;
    }

    public static List<Record> GetAll()
    {
      return _recordList;
    }

    public static Record Find(int searchId)
    {
      return _recordList[searchId - 1];
    }
  }

}