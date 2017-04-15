using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for DBConnection
/// </summary>
public class DBConnection
{
    private static string connectionString = ConfigurationManager.ConnectionStrings["Banking"].ConnectionString;

    public static string ConnectionString
    {
        get
        {
            return connectionString;
        }
        set
        {
            connectionString = value;
        }
    }
}