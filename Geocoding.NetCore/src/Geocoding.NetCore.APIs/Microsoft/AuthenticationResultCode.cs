using System;

namespace Geocoding.NetCore.Microsoft
{
	public enum AuthenticationResultCode
	{
		None,
		NoCredentials,
		ValidCredentials,
		InvalidCredentials,
		CredentialsExpired,
		NotAuthorized,
	}
}