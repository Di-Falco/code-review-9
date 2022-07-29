using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    private static List<Stylist> _instances = new List<Stylist> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Client> Clients { get; set; }

    public Stylist(string stylistName)
    {
      Name = stylistName;
      _instances.Add(this);
      Id = _instances.Count;
      Clients = new List<Client>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Stylist> GetAll()
    {
      return _instances;
    }
    public static Stylist Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddClient(Client client)
    {
      Clients.Add(client);
    }
  }
}