using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Configuration;
using IDAL;

namespace DALFactory
{
    public class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();

        //public static IAdder CreateAdder()
        //{
        //    string className = AssemblyName + "." + db + "Adder";
        //    return (IAdder)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IC_Comment CreateC_Comment()
        //{
        //    string className = AssemblyName + "." + db + "C_Comment";
        //    return (IC_Comment)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IComment CreateComment()
        //{
        //    string className = AssemblyName + "." + db + "Comment";
        //    return (IComment)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        public static ICommodity CreateCommdity()
        {
            string className = AssemblyName + "." + db + "Commodity";
            return (ICommodity)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //public static IFeedback CreateFeedback()
        //{
        //    string className = AssemblyName + "." + db + "Feedback";
        //    return (IFeedback)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IFriend CreateFriend()
        //{
        //    string className = AssemblyName + "." + db + "Friend";
        //    return (IFriend)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IJudge CreateJudge()
        //{
        //    string className = AssemblyName + "." + db + "Judge";
        //    return (IJudge)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IManager CreateManager()
        //{
        //    string className = AssemblyName + "." + db + "Manager";
        //    return (IManager)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IOrder CreateOrder()
        //{
        //    string className = AssemblyName + "." + db + "Order";
        //    return (IOrder)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IPhotos CreatePhotos()
        //{
        //    string className = AssemblyName + "." + db + "Photos";
        //    return (IPhotos)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IRecord CreateRecord()
        //{
        //    string className = AssemblyName + "." + db + "Record";
        //    return (IRecord)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        public static ISaishi CreateSaishi()
        {
            string className = AssemblyName + "." + db + "Saishi";
            return (ISaishi)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //public static ISaled CreateSaled()
        //{
        //    string className = AssemblyName + "." + db + "Saled";
        //    return (ISaled)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IT_Comment CreateT_Comment()
        //{
        //    string className = AssemblyName + "." + db + "T_Comment";
        //    return (IT_Comment)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static ITiezi CreateTiezi()
        //{
        //    string className = AssemblyName + "." + db + "Tiezi";
        //    return (ITiezi)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IUserGrade CreateUserGrade()
        //{
        //    string className = AssemblyName + "." + db + "UserGrade";
        //    return (IUserGrade)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //public static IZ_Comment CreateZ_Comment()
        //{
        //    string className = AssemblyName + "." + db + "Z_Comment";
        //    return (IZ_Comment)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        public static IUsers CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUsers)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVideo CreateVideo()
        {
            string className = AssemblyName + "." + db + "Video";
            return (IVideo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IZhanbao CreateZhanbao()
        {
            string className = AssemblyName + "." + db + "Zhanbao";
            return (IZhanbao)Assembly.Load(AssemblyName).CreateInstance(className);
        }

    }
}
