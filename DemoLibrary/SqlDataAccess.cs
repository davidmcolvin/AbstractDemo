using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class SqlDataAccess : DataAccess
  {

    public override void LoadData(string v)
    {
      Console.WriteLine("Loading Microsoft SQL Data");
    }

    public override void SaveData(string v)
    {
      Console.WriteLine("Saving data to Microsoft SQL Server");
    }
  }
}
