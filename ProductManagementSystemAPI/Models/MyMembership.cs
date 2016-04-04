using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace ProductManagementSystemAPI.Models
{
    public static class MyMembership
    {
        //private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static int retry = 3;
        static int threadSleep = 2000;

        public static bool ValidateUser(string username, string password)
        {
            bool isValid = false;
            for (int iCounter = 1; iCounter <= retry; iCounter++)
            {
                try
                {
                    isValid = Membership.ValidateUser(username, password);
                    break;
                }
                catch (Exception ex)
                {
                   // logger.Error("Exception:ValidateUser:" + ex.Message);
                    if (iCounter >= retry)
                    {
                        throw ex;
                    }
                    try
                    {
                        System.Threading.Thread.Sleep(threadSleep);
                    }
                    catch (Exception eT)
                    {
                        //logger.Error("Exception:ThreadSleep:" + eT.Message);
                    }
                }
            }
            return isValid;
        }

        public static MembershipUser GetUser(string username)
        {
            MembershipUser membershipUser = null;
            for (int iCounter = 1; iCounter <= retry; iCounter++)
            {
                try
                {
                    membershipUser = Membership.GetUser(username);
                    break;
                }
                catch (Exception ex)
                {
                   // logger.Error("Exception:GetUser:" + ex.Message);
                    if (iCounter >= retry)
                    {
                        throw ex;
                    }
                    try
                    {
                        System.Threading.Thread.Sleep(threadSleep);
                    }
                    catch (Exception eT)
                    {
                        //logger.Error("Exception:ThreadSleep:" + eT.Message);
                    }
                }
            }
            return membershipUser;
        }

        public static string GetUserNameByEmail(string emailToMatch)
        {
            string userName = string.Empty;
            for (int iCounter = 1; iCounter <= retry; iCounter++)
            {
                try
                {
                    userName = Membership.GetUserNameByEmail(emailToMatch);
                    break;
                }
                catch (Exception ex)
                {
                   // logger.Error("Exception:GetUserNameByEmail:" + ex.Message);
                    if (iCounter >= retry)
                    {
                        throw ex;
                    }
                    try
                    {
                        System.Threading.Thread.Sleep(threadSleep);
                    }
                    catch (Exception eT)
                    {
                        //logger.Error("Exception:ThreadSleep:" + eT.Message);
                    }
                }
            }
            return userName;
        }

        public static string GeneratePassword(int length, int numberOfNonAlphanumericCharacters)
        {
            string password = string.Empty;
            for (int iCounter = 1; iCounter <= retry; iCounter++)
            {
                try
                {
                    password = Membership.GeneratePassword(length, numberOfNonAlphanumericCharacters);
                    break;
                }
                catch (Exception ex)
                {
                    //logger.Error("Exception:GeneratePassword:" + ex.Message);
                    if (iCounter >= retry)
                    {
                        throw ex;
                    }
                    try
                    {
                        System.Threading.Thread.Sleep(threadSleep);
                    }
                    catch (Exception eT)
                    {
                       // logger.Error("Exception:ThreadSleep:" + eT.Message);
                    }
                }
            }
            return password;
        }

        public static void CreateUser(string username, string password, string email)
        {
            for (int iCounter = 1; iCounter <= retry; iCounter++)
            {
                try
                {
                    MembershipCreateStatus createStatus;
                    MembershipUser mu;
                    mu=Membership.CreateUser(username, password, email, null, null, false, out createStatus);
                   
                    break;
                }
                catch (Exception ex)
                {
                    //logger.Error("Exception:CreateUser:" + ex.Message);
                    if (iCounter >= retry)
                    {
                        throw ex;
                    }
                    try
                    {
                        System.Threading.Thread.Sleep(threadSleep);
                    }
                    catch (Exception eT)
                    {
                        //logger.Error("Exception:ThreadSleep:" + eT.Message);
                    }
                }
            }
        }

        public static bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            bool isDeleted = false;
            for (int iCounter = 1; iCounter <= retry; iCounter++)
            {
                try
                {
                    isDeleted = Membership.DeleteUser(username, true);
                    break;
                }
                catch (Exception ex)
                {
                    //logger.Error("Exception:DeleteUser:" + ex.Message);
                    if (iCounter >= retry)
                    {
                        throw ex;
                    }
                    try
                    {
                        System.Threading.Thread.Sleep(threadSleep);
                    }
                    catch (Exception eT)
                    {
                       // logger.Error("Exception:ThreadSleep:" + eT.Message);
                    }
                }
            }
            return isDeleted;
        }
        public static int Getuser_id(string user_email)
        {
            int user_id = 0;
            for (int iCounter = 1; iCounter <= retry; iCounter++)
            {
                try
                {
                    if (string.IsNullOrEmpty(user_email) || Membership.GetUser(user_email, true) == null)
                    {
                        return user_id;
                    }
                    user_id = Convert.ToInt32(Membership.GetUser(user_email, true).ProviderUserKey);
                    break;
                }
                catch (Exception ex)
                {
                   // logger.Error("Exception:Getuser_id:" + ex.Message);
                    if (iCounter >= retry)
                    {
                        throw ex;
                    }
                    try
                    {
                        System.Threading.Thread.Sleep(threadSleep);
                    }
                    catch (Exception eT)
                    {
                       // logger.Error("Exception:ThreadSleep:" + eT.Message);
                    }
                }
            }
            return user_id;
        }
    }
}