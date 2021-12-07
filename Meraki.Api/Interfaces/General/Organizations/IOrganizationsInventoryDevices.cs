﻿namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsInventoryDevices
{
	/// <summary>
	/// Return the device inventory for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="usedState">Filter results by used or unused inventory. Accepted values are "used" or "unused".</param>
	/// <param name="search">Search for devices in inventory based on serial number, mac address, or model.</param>
	[Get("/organizations/{organizationId}/inventoryDevices")]
	Task<List<InventoryDevice>> GetOrganizationInventoryDevicesAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("perPage")] int? perPage = 1000,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		[AliasAs("usedState")] string? usedState = null,
		[AliasAs("search")] string? search = null,
		CancellationToken cancellationToken = default);

	// Used by IOrganizationsNetworksExtensions.GetOrganizationNetworksAllAsync
	[Get("/organizations/{organizationId}/inventoryDevices")]
	internal Task<ApiResponse<List<InventoryDevice>>> GetInventoryDevicesApiResponseAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("usedState")] string? usedState = null,
		[AliasAs("search")] string? search = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return the device inventory for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="serial">The serial number</param>
	[Get("/organizations/{organizationId}/inventoryDevices/{serial}")]
	Task<InventoryDevice> GetOrganizationInventoryDeviceAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default);
}
