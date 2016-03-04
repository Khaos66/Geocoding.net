using System;

namespace Geocoding.NetCore.MapQuest
{
    public enum ResponseStatus
    {
        Ok = 0,
        OkBatch = 100,
        ErrorInput = 400,
        ErrorAccountKey = 403,
        ErrorUnknown = 500,
    }
}