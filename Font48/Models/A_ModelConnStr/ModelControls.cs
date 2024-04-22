using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Font48.Models.A_ModelConnStr
{
  public partial class ModelControls : DbContext
  {
    //public ModelControls(string connStr)
    //  : base(GetEfConnectionString("Models.AllClients.ModelAllClients", connStr))
    //{
    //  // 2023-09-22 02:24 P - Peter Grigg - See Below
    //  // Add code to reference types from the provider assembly.
    //  // You can add a line of code that references a type in the provider assembly.
    //  // This line of code won't actually do anything and can be
    //  // placed anywhere in your application: 
    //  // NOTE: only needs to show up once
    //  //var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
    //}
    //public static string GetEfConnectionString(string modelName, string primary)
    //{
    //  string connStr = "metadata=res://*/" + modelName
    //    + ".csdl|res://*/"
    //    + modelName
    //    + ".ssdl|res://*/"
    //    + modelName
    //    + ".msl;provider=System.Data.SqlClient;"
    //    + "provider connection string='"
    //    + primary
    //    + ";MultipleActiveResultSets=True;App=EntityFramework'"; // providerName = \"\"System.Data.EntityClient";
    //  return connStr;
    //}
  }

}