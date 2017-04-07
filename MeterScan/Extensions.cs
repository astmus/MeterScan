using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Symbol.Fusion.WLAN;

namespace MeterScan
{
    public static class Extensions
    {
        public static Profile GetProfileByName(this WLAN lan, string profileName)
        {
            Symbol.Fusion.WLAN.Profiles myProfiles = lan.Profiles;            
            for (int profileIndex = 0; profileIndex < myProfiles.Length; profileIndex++)
            {
                Profile myProfile = myProfiles[profileIndex];
                if (profileName == myProfile.Name)
                    return myProfile;
            }
            return null;
        }
    }
}
