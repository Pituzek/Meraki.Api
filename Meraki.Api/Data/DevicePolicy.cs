namespace Meraki.Api.Data;

/// <summary>
/// The policy to apply to the specified client. Can be 'Group policy', 'Whitelisted', 'Blocked', 'Per connection' or 'Normal'. Required.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DevicePolicy
{
	/// <summary>
	/// Enum Grouppolicy for "Group policy"
	/// </summary>
	[EnumMember(Value = "Group policy")]
	Grouppolicy,

	/// <summary>
	/// Enum Whitelisted for "Whitelisted"
	/// </summary>
	[EnumMember(Value = "Whitelisted")]
	Whitelisted,

	/// <summary>
	/// Enum Blocked for "Blocked"
	/// </summary>
	[EnumMember(Value = "Blocked")]
	Blocked,

	/// <summary>
	/// Enum Perconnection for "Per connection"
	/// </summary>
	[EnumMember(Value = "Per connection")]
	Perconnection,

	/// <summary>
	/// Enum Normal for "Normal"
	/// </summary>
	[EnumMember(Value = "Normal")]
	Normal
}
