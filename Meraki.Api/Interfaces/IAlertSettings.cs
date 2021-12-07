using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IAlertSettings
	{
		/// <summary>
		/// Return the alert configuration for this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/alerts/settings")]
		Task<NetworkAlertSettings> GetNetworkAlertsSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the alert configuration for this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkAlertSettings">Body for updating network alert settings</param>
		[Put("/networks/{networkId}/alerts/settings")]
		Task<NetworkAlertSettings> UpdateNetworkAlertSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkAlertSettings updateNetworkAlertSettings = null!,
			CancellationToken cancellationToken = default);
	}
}