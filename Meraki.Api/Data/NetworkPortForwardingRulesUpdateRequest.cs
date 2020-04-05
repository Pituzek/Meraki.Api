using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkPortForwardingRules
	/// </summary>
	[DataContract]
	public partial class NetworkPortForwardingRulesUpdateRequest
	{
		/// <summary>
		/// An array of port forwarding params
		/// </summary>
		/// <value>An array of port forwarding params</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<NetworkPortForwardingRules> Rules { get; set; }
	}
}
