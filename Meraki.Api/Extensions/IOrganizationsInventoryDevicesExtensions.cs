﻿namespace Meraki.Api.Extensions;

public static class IOrganizationsInventoryDevicesExtensions
{
	/// <summary>
	/// Get all networks that the user has privileges on in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="usedState">Filter results by used or unused inventory. Accepted values are "used" or "unused".</param>
	/// <param name="search">Search for devices in inventory based on serial number, mac address, or model.</param>
	public static Task<List<InventoryDevice>> GetOrganizationInventoryDevicesAllAsync(
		this IOrganizationsInventoryDevices organizationInventoryDevices,
		string organizationId,
		string? usedState = null,
		string? search = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> organizationInventoryDevices.GetInventoryDevicesApiResponseAsync(
						organizationId,
						startingAfter,
						usedState,
						search,
						cancellationToken
					),
					cancellationToken
			);
}
