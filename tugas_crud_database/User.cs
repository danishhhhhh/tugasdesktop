using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class User
{
    private static String username = "";

    public static bool CheckUserAccountsUsername(String user)
    {
        if (username == user) return false;
        return true;
    }

    public static bool AddUsername(String user)
    {
        username = user;
        return true;
    }

    public static bool DeleteUsername()
    {
        username = "";
        return false;
    }
}
