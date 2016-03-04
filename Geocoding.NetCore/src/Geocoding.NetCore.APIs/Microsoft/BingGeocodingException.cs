using System;

namespace Geocoding.NetCore.Microsoft
{
	public class BingGeocodingException : Exception
	{
		const string defaultMessage = "There was an error processing the geocoding request. See InnerException for more information.";

		public BingGeocodingException(Exception innerException)
			: base(defaultMessage, innerException) { }
	}
}