namespace MusicOrganizer.Models
{
  public class Artist
  {

    private static List<Artist> _artistList = new List<Artist> { };
    public string ArtistName { get; set; }
    public int Id { get; }

    public List<Record> Records { get; set; }
    

    public Artist(string artistName)
    {
      ArtistName = artistName;
      _artistList.Add(this);
      Id = _artistList.Count;
      Records = new List<Record>{};
    }

    public static List<Artist> GetAll()
    {
      return _artistList;
    }

    public static Artist Find(int searchId)
    {
      return _artistList[searchId - 1];
    }

    public void Additem(Record record)
    {
      Records.Add(record);
    }
  }
}