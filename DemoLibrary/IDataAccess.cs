using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public interface IDataAccess
  {
    string LoadConnectionString(string v);
    void LoadData(string v);
    void SaveData(string v);
  }
}
