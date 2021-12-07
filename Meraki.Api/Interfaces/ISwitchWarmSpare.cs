using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISwitchWarmSpare
	{
		/// <summary>
		/// Return warm spare configuration for a switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/switch/warmSpare")]
		Task<SwitchWarmSpare> GetDeviceSwitchWarmSpareAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update warm spare configuration for a switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="UpdateDeviceSwitchWarmSpare"></param>
		[Put("/devices/{serial}/switch/warmSpare")]
		Task<SwitchWarmSpare> UpdateAsync(
			[AliasAs("serial")] string serial,
			[Body] SwitchWarmSpareUpdateRequest UpdateDeviceSwitchWarmSpare,
			CancellationToken cancellationToken = default);
	}
}