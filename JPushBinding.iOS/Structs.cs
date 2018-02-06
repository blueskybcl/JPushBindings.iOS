using System;
using ObjCRuntime;

namespace JPushBinding.iOS
{
    [Native]
    public enum JPAuthorizationOptions : uint
    {
        None = 0,
        Badge = (1 << 0),
        Sound = (1 << 1),
        Alert = (1 << 2)
    }

}

