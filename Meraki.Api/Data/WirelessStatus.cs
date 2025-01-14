﻿namespace Meraki.Api.Data;

/// <summary>
/// Status
/// </summary>
[DataContract]
public class WirelessStatus
{
	/// <summary>
	/// Basic service sets
	/// </summary>
	[DataMember(Name = "basicServiceSets")]
	public BasicServiceSets BasicServiceSets { get; set; } = new();
}
