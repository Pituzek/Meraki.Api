namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchStacks
{
	/// <summary>
	/// List the switch stacks in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchStacks")]
	[Get("/networks/{networkId}/switch/stacks")]
	Task<List<SwitchStack>> GetNetworkSwitchStacksAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkSwitchStack"></param>
	[ApiOperationId("createNetworkSwitchStack")]
	[Post("/networks/{networkId}/switch/stacks")]
	Task<SwitchStack> CreateNetworkSwitchStackAsync(
		[AliasAs("networkId")] string networkId,
		[Body] SwitchStackCreationRequest createNetworkSwitchStack,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Show a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	[ApiOperationId("getNetworkSwitchStack")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}")]
	Task<SwitchStack> GetNetworkSwitchStackAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	[ApiOperationId("deleteNetworkSwitchStack")]
	[Delete("/networks/{networkId}/switch/stacks/{switchStackId}")]
	Task DeleteNetworkSwitchStackAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add a switch to a stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="addNetworkSwitchStack"></param>
	[ApiOperationId("addNetworkSwitchStack")]
	[Post("/networks/{networkId}/switch/stacks/{switchStackId}/add")]
	Task<SwitchStack> AddNetworkSwitchStackAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[Body] NetworkSwitchStackCreationRequest addNetworkSwitchStack,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Remove a switch from a stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="removeNetworkSwitchStack"></param>
	[ApiOperationId("removeNetworkSwitchStack")]
	[Post("/networks/{networkId}/switch/stacks/{switchStackId}/remove")]
	Task<SwitchStack> RemoveNetworkSwitchStackAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[Body] RemoveNetworkSwitchStack removeNetworkSwitchStack,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List layer 3 interfaces for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchStackRoutingInterfaces")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces")]
	Task<List<RoutingInterface>> GetNetworkSwitchStackRoutingInterfacesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a layer 3 interface for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="routingInterface"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createNetworkSwitchStackRoutingInterface")]
	[Post("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces")]
	Task<RoutingInterface> CreateNetworkSwitchStackRoutingInterfaceAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[Body] RoutingInterfaceCreateRequest routingInterface,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a layer 3 interface from a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="interfaceId"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchStackRoutingInterface")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}")]
	Task<RoutingInterface> GetNetworkSwitchStackRoutingInterfaceAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[AliasAs("interfaceId")] string interfaceId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a layer 3 interface for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="interfaceId"></param>
	/// <param name="routingInterface"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkSwitchStackRoutingInterface")]
	[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}")]
	Task<RoutingInterface> UpdateNetworkSwitchStackRoutingInterfaceAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[AliasAs("interfaceId")] string interfaceId,
		[Body] RoutingInterfaceUpdateRequest routingInterface,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a layer 3 interface from a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="interfaceId"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteNetworkSwitchStackRoutingInterface")]
	[Delete("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}")]
	Task DeleteNetworkSwitchStackRoutingInterfaceAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[AliasAs("interfaceId")] string interfaceId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a layer 3 interface DHCP configuration for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="interfaceId">The interface id</param>
	[ApiOperationId("getNetworkSwitchStackRoutingInterfaceDhcp")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}/dhcp")]
	Task<RoutingInterfaceDhcp> GetNetworkSwitchStackRoutingInterfaceDhcpAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[AliasAs("interfaceId")] string interfaceId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a layer 3 interface DHCP configuration for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="interfaceId">The interface id</param>
	/// <param name="routingInterfaceDhcp"></param>
	[ApiOperationId("updateNetworkSwitchStackRoutingInterfaceDhcp")]
	[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}/dhcp")]
	Task<RoutingInterfaceDhcp> UpdateNetworkSwitchStackRoutingInterfaceDhcpAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[AliasAs("interfaceId")] string interfaceId,
		[Body] RoutingInterfaceDhcp routingInterfaceDhcp,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List layer 3 static routes for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	[ApiOperationId("getNetworkSwitchStackRoutingStaticRoutes")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes")]
	Task<List<SwitchStaticRoute>> GetNetworkSwitchStackRoutingStaticRoutesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a layer 3 static route for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="createNetworkSwitchStackRoutingStaticRoute"></param>
	[ApiOperationId("createNetworkSwitchStackRoutingStaticRoute")]
	[Post("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes")]
	Task<SwitchStaticRoute> CreateNetworkSwitchStackRoutingStaticRouteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[Body] SwitchStaticRouteCreationRequest createNetworkSwitchStackRoutingStaticRoute,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a layer 3 static route for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="staticRouteId">The static route id</param>
	[ApiOperationId("getNetworkSwitchStackRoutingStaticRoute")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
	Task<SwitchStaticRoute> GetNetworkSwitchStackRoutingStaticRouteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[AliasAs("staticRouteId")] string staticRouteId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a layer 3 static route for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="staticRouteId">The static route id</param>
	/// <param name="updateNetworkSwitchStackRoutingStaticRoute"></param>
	[ApiOperationId("updateNetworkSwitchStackRoutingStaticRoute")]
	[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
	Task<SwitchStaticRoute> UpdateNetworkSwitchStackRoutingStaticRouteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[AliasAs("staticRouteId")] string staticRouteId,
		[Body] SwitchStaticRouteCreationRequest updateNetworkSwitchStackRoutingStaticRoute,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a layer 3 static route for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="staticRouteId">The static route id</param>
	[ApiOperationId("deleteNetworkSwitchStackRoutingStaticRoute")]
	[Delete("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
	Task DeleteNetworkSwitchStackRoutingStaticRouteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("switchStackId")] string switchStackId,
		[AliasAs("staticRouteId")] string staticRouteId,
		CancellationToken cancellationToken = default
		);
}
