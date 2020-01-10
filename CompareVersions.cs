using System;
using System.Collections.Generic;
using System.Text;

namespace CompareVersion
{
    class CompareVersions
    {
        public string ResultOfComparison(string s, string s2)
        {

            string[] versionA = s.Split(".");
            string[] versionB = s2.Split(".");
            int j; int i;
            String HigherVersion = "";
            string[] longerVersion;

            int size = (versionA.Length < versionB.Length) ? versionA.Length : versionB.Length;
            longerVersion = (versionA.Length > versionB.Length) ? versionA : versionB;
            string longerVersionText = (versionA.Length > versionB.Length) ? "VersionA" : "VersionB";

            for (i = 0, j = 0; i < size; i++, j++)
            {
                int isEqual = versionA[i].CompareTo(versionB[i]);
                switch (isEqual)
                {
                    case -1:
                        HigherVersion = "versionB is higher";
                        break;
                    case 1:
                            HigherVersion = "versionA is higher";
                            break;                     
                    case 0:
                        {
                            HigherVersion = "Versions are equal";
                            if (versionA.Length != versionB.Length)
                            {
                                if ((longerVersion[size].Equals("0")))
                                {
                                    HigherVersion = "Versions are equal";
                                }
                                else
                                {
                                    HigherVersion = longerVersionText + " is higher";
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong format of strings");
                        break;


                }
            }

            return HigherVersion;
        }
    }
}
