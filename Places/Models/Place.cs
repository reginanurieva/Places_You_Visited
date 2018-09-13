using System.Collections.Generic;


namespace Places.Models
{
  public class Place
  {
    private static List<Place> _instances= new List<Place>();
    // private List<Item> _items;
    private string _country;
    private string _city;
    private string _activities;
    private int _id;



    public Place(string country, string city, string activities)
    {
      _country = country;
      _city = city;
      _activities = activities;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetActivity()
    {
      return _activities;
    }

    public string GetCountry()
    {
      return _country;
    }

    public string GetCity()
    {
      return _city;
    }

    public int GetId()
    {
      return _id;
    }

    public static Place Find(int searchId)
        {
            return _instances[searchId - 1];
        }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    public static List<Place> GetAll()
    {
      return _instances;
    }

  }


}
