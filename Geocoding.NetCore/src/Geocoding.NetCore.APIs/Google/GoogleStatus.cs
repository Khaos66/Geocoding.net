using System;

namespace Geocoding.NetCore.Google
{
	public enum GoogleStatus
	{
		Error,
		Ok,
		ZeroResults,
		OverQueryLimit,
		RequestDenied,
		InvalidRequest
	}
}