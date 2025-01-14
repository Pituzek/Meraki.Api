namespace Meraki.Api.Data;

/// <summary>
/// Network2
/// </summary>
[DataContract]
public class SamlRoleNetwork
{
	/// <summary>
	/// The network ID
	/// </summary>
	/// <value>The network ID</value>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
	/// <summary>
	/// The privilege of the SAML administrator on the network
	/// </summary>
	/// <value>The privilege of the SAML administrator on the network</value>
	[DataMember(Name = "access")]
	public string Access { get; set; } = string.Empty;
}
