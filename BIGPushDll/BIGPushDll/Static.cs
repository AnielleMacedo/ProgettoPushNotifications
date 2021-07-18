
using BIGPushDll.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIGPushDll
{
    public static class Static
    {
        /// <summary>
        /// Convert enum type 
        /// </summary>
        /// <param name="inputSegmentType"></param>
        /// <returns></returns>
        public static string EnumIncludeSegmentToString(IncludedSegment inputSegmentType)
        {
            string returnString = "";

            switch(inputSegmentType)
            {
                case IncludedSegment.SUBSCRIBED_USERS:
                    returnString = "Subscribed Users";
                    break;

                case IncludedSegment.TEST_DEVICE:
                    returnString = "Test Device";
                    break;

                case IncludedSegment.ALL_USERS:
                    returnString = "All Users";
                    break;

                case IncludedSegment.ACTIVE_USERS:
                    returnString = "Active Users";
                    break;

                case IncludedSegment.INACTIVE_USERS:
                    returnString = "Inactive Users";
                    break;


            }

            //IncludedSegment returnStringFormatted = (IncludedSegment)Enum.Parse(typeof(IncludedSegment), returnString);

            //return returnStringFormatted;


            return returnString;
        }
    }

    public static class Const
    {
        public const string APP_ID = "9b1d6a06-3c05-45df-aa3d-1ff1d3fb9ae9"; // "2e40e5b1-2795-4c6e-965f-e750deef35ab";
        public const string REST_API_KEY = "ZTY0NTg2NmEtYWU5OS00Yjg3LWJlYmMtZDFlZTNhZTk3NDIy"; //"MDRlYWM4ZTQtNmY5My00OTAzLThiNGItZWNjMTRjOTY1MWI1"; 
        public const string URL_ONESIGNAL = "https://onesignal.com/api/v1/notifications";
    }


    namespace Enum
    {
        public enum IncludedSegment 
        {
            SUBSCRIBED_USERS = 1,
            TEST_DEVICE = 2,
            ALL_USERS = 3,
            ACTIVE_USERS = 4,
            INACTIVE_USERS = 5     
               
        }
    }
}
