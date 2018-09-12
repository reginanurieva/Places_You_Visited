using System.Collections.Generic;
using System;

namespace Places.Models
{
  public class Place
  {
    private string _country;
    private string _city;
    private string _activities;
    private static List<Place> _instances= new List<Place>();


    public Place(string country, string city, string activities)
    {
      _country = country;
      _city = city;
      _activities = activities;
      _instances.Add(this);
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

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

  }


}
