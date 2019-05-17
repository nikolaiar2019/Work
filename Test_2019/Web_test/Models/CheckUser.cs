using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Threading.Tasks;
using Web_test.Models;
namespace Web_test.Models
{
  // public class CheckUser
  // {
  //     private string path;
  //     private string password;
  //     private string user;
  //
  //
  //     public CheckUser()
  //     {
  //         this.CheckUserCred("n.markov@armf.bg","Nikolaimar2019");
  //     }
  //    
  //     public string Path
  //     {
  //         get { return path; }
  //         set { path = value; }
  //     }
  //     public string User
  //     {
  //    
  //         get
  //         {
  //             return user;
  //         }
  //         set
  //         {
  //             if (value.Length <= 3)
  //             {
  //                 throw new ArgumentException("Username must be more than 3 symbols!");
  //             }
  //             user = value;
  //         }
  //     }
  //    
  //     public string Password
  //     {
  //         get { return password; }
  //         set { password = value; }
  //     }
  //    
  //     public bool CheckUserCred(string user, string pass)
  //     {
  //         DirectoryEntry entry = new DirectoryEntry("LDAP://armf.bg/CN=Users,DC=armf,DC=bg", user, password);
  //         DirectorySearcher ds = new DirectorySearcher(entry);
  //         ds.Filter = "(&(objectClass=user)(cn=" + user + "))";
  //         SearchResult results = ds.FindOne();
  //         try
  //         {
  //             var directorySearcher = new DirectorySearcher(user);
  //             directorySearcher.FindOne();
  //             return true;
  //         }
  //         catch
  //         {
  //             return false;
  //         }
  //     }
  //    
  //
  //
  // }
}
