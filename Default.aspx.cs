using System;
using NLog;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    private static Logger logger = LogManager.GetCurrentClassLogger();
    protected void Page_Load(object sender, EventArgs e)
    {      
        try
        {
            int a = 0;
            int b = 0;
            int c = 0;
            c = a / b;
        }
        catch (Exception ex)
        {
            //Considering all types of exception
           logger.Error("Error message: " + ex.Message + " Stack Trace: " + ex.StackTrace);
        }
       
    }
}