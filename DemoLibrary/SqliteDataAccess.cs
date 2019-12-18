using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoLibrary
{
  public class SqliteDataAccess : DataAccess
  {
    public override string LoadConnectionString(string v)
    {
      string output = base.LoadConnectionString(v);
      output += " (from Sqlite)";
      return output;

    }

    public override void LoadData(string v)
    {
      Console.WriteLine("Loading SQLite Data");
    }

    public override void SaveData(string v)
    {
      Console.WriteLine("Saving data to SQLite");
    }
  }
}
