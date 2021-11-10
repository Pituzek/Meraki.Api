using Meraki.Api.Attributes;
using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISwitchSettings
	{
		/// <summary>
		/// Returns the switch network settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchSettings")]
		[Get("/networks/{networkId}/switch/settings")]
		Task<SwitchSettings> GetNetworkSwitchSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update switch network settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSwitchSettings"></param>
		[ApiOperationId("updateNetworkSwitchSettings")]
		[Put("/networks/{networkId}/switch/settings")]
		Task<SwitchSettings> UpdateNetworkSwitchSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettings updateNetworkSwitchSettings,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the DHCP server policy
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchDhcpServerPolicy")]
		[Get("/networks/{networkId}/switch/dhcpServerPolicy")]
		Task<DhcpServerPolicy> GetDhcpServerPolicyAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the DHCP server policy
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSwitchSettingsDhcpServerPolicy"></param>
		[ApiOperationId("updateNetworkSwitchDhcpServerPolicy")]
		[Put("/networks/{networkId}/switch/dhcpServerPolicy")]
		Task<DhcpServerPolicy> UpdateDhcpServerPolicyAsync(
			[AliasAs("networkId")] string networkId,
			[Body] DhcpServerPolicy updateNetworkSwitchSettingsDhcpServerPolicy,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the DSCP to CoS mappings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchDscpToCosMappings")]
		[Get("/networks/{networkId}/switch/dscpToCosMappings")]
		Task<DscpToCosMappings> GetDscpToCosMappingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the DSCP to CoS mappings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="settingsDscpToCosMappings"></param>
		[ApiOperationId("updateNetworkSwitchDscpToCosMappings")]
		[Put("/networks/{networkId}/switch/dscpToCosMappings")]
		Task<DscpToCosMappings> UpdateDscpToCosMappingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] DscpToCosMappings settingsDscpToCosMappings,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the MTU configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchMtu")]
		[Get("/networks/{networkId}/switch/mtu")]
		Task<SwitchMtu> GetNetworkSwitchMtuAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the MTU configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateSwitchMtu"></param>
		[ApiOperationId("updateNetworkSwitchMtu")]
		[Put("/networks/{networkId}/switch/mtu")]
		Task<SwitchMtu> UpdateNetworkSwitchMtuAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchMtu updateSwitchMtu,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List quality of service rules
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchQosRules")]
		[Get("/networks/{networkId}/switch/qosRules")]
		Task<List<QosRule>> GetNetworkSwitchQosRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a quality of service rule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qosRuleId">The quality of service rule id</param>
		[ApiOperationId("getNetworkSwitchQosRule")]
		[Get("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
		Task<QosRule> GetNetworkSwitchQosRuleAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("qosRuleId")] string qosRuleId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Add a quality of service rule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkSwitchSettingsQosRule"></param>
		[ApiOperationId("createNetworkSwitchQosRule")]
		[Post("/networks/{networkId}/switch/qosRules")]
		Task<QosRule> CreateNetworkSwitchQosRuleAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsQosRuleCreationRequest createNetworkSwitchSettingsQosRule,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a quality of service rule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qosRuleId"></param>
		/// <param name="updateNetworkSwitchSettingsQosRule"></param>
		[ApiOperationId("updateNetworkSwitchQosRule")]
		[Put("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
		Task<SwitchSettingsQosRuleUpdateRequest> UpdateNetworkSwitchQosRuleAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("qosRuleId")] string qosRuleId,
			[Body] SwitchSettingsQosRuleUpdateRequest updateNetworkSwitchSettingsQosRule,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a quality of service rule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qosRuleId">The quality of service rule id</param>
		[ApiOperationId("deleteNetworkSwitchQosRule")]
		[Delete("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
		Task DeleteNetworkSwitchQosRuleAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("qosRuleId")] string qosRuleId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the quality of service rule IDs by order in which they will be processed by the switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchQosRulesOrder")]
		[Get("/networks/{networkId}/switch/qosRules/order")]
		Task<QosRulesOrder> GetNetworkSwitchQosRulesOrderAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the order in which the rules should be processed by the switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qosRulesOrder"></param>
		[ApiOperationId("updateNetworkSwitchQosRulesOrder")]
		[Put("/networks/{networkId}/switch/qosRules/order")]
		Task<QosRulesOrder> UpdateNetworkSwitchQosRulesOrderAsync(
			[AliasAs("networkId")] string networkId,
			[Body] QosRulesOrder qosRulesOrder,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return multicast settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchRoutingMulticast")]
		[Get("/networks/{networkId}/switch/routing/multicast")]
		Task<Multicast> GetNetworkSwitchRoutingMulticastAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update multicast settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="multicast"></param>
		[ApiOperationId("updateNetworkSwitchRoutingMulticast")]
		[Put("/networks/{networkId}/switch/routing/multicast")]
		Task<Multicast> UpdateNetworkSwitchRoutingMulticastAsync(
			[AliasAs("networkId")] string networkId,
			[Body] Multicast multicast,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List multicast rendezvous points
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchRoutingMulticastRendezvousPoints")]
		[Get("/networks/{networkId}/switch/routing/multicast/rendezvousPoints")]
		Task<List<RendezvousPoint>> GetNetworkSwitchRoutingMulticastRendezvousPointsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Create a multicast rendezvous points
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="rendezvousPoint">The rendezvous point to create</param>
		/// <param name="cancellationToken"></param>
		[ApiOperationId("createNetworkSwitchRoutingMulticastRendezvousPoint")]
		[Post("/networks/{networkId}/switch/routing/multicast/rendezvousPoints")]
		Task<RendezvousPoint> CreateNetworkSwitchRoutingMulticastRendezvousPointAsync(
			[AliasAs("networkId")] string networkId,
			[Body] RendezvousPointCreateUpdateRequest rendezvousPoint,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Get a multicast rendezvous points
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchRoutingMulticastRendezvousPoint")]
		[Get("/networks/{networkId}/switch/routing/multicast/rendezvousPoints/{rendezvousPointId}")]
		Task<RendezvousPoint> GetNetworkSwitchRoutingMulticastRendezvousPointAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("rendezvousPointId")] string rendezvousPointId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a multicast rendezvous points
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="rendezvousPoint">The rendezvous point to update</param>
		/// <param name="cancellationToken"></param>
		[ApiOperationId("updateNetworkSwitchRoutingMulticastRendezvousPoint")]
		[Put("/networks/{networkId}/switch/routing/multicast/rendezvousPoints/{rendezvousPointId}")]
		Task<RendezvousPoint> UpdateNetworkSwitchRoutingMulticastRendezvousPointAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("rendezvousPointId")] string rendezvousPointId,
			[Body] RendezvousPointCreateUpdateRequest rendezvousPoint,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a multicast rendezvous points
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("deleteNetworkSwitchRoutingMulticastRendezvousPoint")]
		[Delete("/networks/{networkId}/switch/routing/multicast/rendezvousPoints/{rendezvousPointId}")]
		Task<RendezvousPoint> DeleteNetworkSwitchRoutingMulticastRendezvousPointAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("rendezvousPointId")] string rendezvousPointId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Get layer 3 OSPF routing configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="cancellationToken"></param>
		[ApiOperationId("getNetworkSwitchRoutingOspf")]
		[Get("/networks/{networkId}/switch/routing/ospf")]
		Task<RoutingOspf> GetNetworkSwitchRoutingOspfAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update layer 3 OSPF routing configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="routingOspf">The OSPF routing configuration to update</param>
		/// <param name="cancellationToken"></param>
		[ApiOperationId("updateNetworkSwitchRoutingOspf")]
		[Put("/networks/{networkId}/switch/routing/ospf")]
		Task<RoutingOspf> UpdateNetworkSwitchRoutingOspfAsync(
			[AliasAs("networkId")] string networkId,
			[Body] RoutingOspf routingOspf,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return warm spare configuration for a switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[ApiOperationId("getDeviceSwitchWarmSpare")]
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
		/// <param name="updateDeviceSwitchWarmSpare"></param>
		[ApiOperationId("updateDeviceSwitchWarmSpare")]
		[Put("/devices/{serial}/switch/warmSpare")]
		Task<SwitchWarmSpare> UpdateAsync(
			[AliasAs("serial")] string serial,
			[Body] SwitchWarmSpareUpdateRequest updateDeviceSwitchWarmSpare,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the switch alternate management interface for the network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchAlternateManagementInterface")]
		[Get("/networks/{networkId}/switch/alternateManagementInterface")]
		Task<AlternateManagementInterface> GetAlternateManagementInterfaceAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the switch alternate management interface for the network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="alternateManagementInterface">Body for updating network switch alternate management interface</param>
		[ApiOperationId("updateNetworkSwitchAlternateManagementInterface")]
		[Put("/networks/{networkId}/switch/alternateManagementInterface")]
		Task<AlternateManagementInterface> UpdateAlternateManagementInterfaceAsync(
			[AliasAs("networkId")] string networkId,
			[Body] AlternateManagementInterface alternateManagementInterface,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the storm control configuration for a switch network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/stormControl")]
		Task<SwitchSettingsStormControlUpdateRequest> GetNetworkSwitchStormControlAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns STP settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/stp")]
		Task<SwitchSettingsStpUpdateRequest> GetNetworkSwitchStpAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the storm control configuration for a switch network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSwitchSettingsStormControl"></param>
		[Put("/networks/{networkId}/switch/stormControl")]
		Task<SwitchSettingsStormControlUpdateRequest> UpdateNetworkSwitchStormControl(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsStormControlUpdateRequest updateNetworkSwitchSettingsStormControl,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates STP settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSwitchSettingsStp"></param>
		[Put("/networks/{networkId}/switch/stp")]
		Task<SwitchSettingsStpUpdateRequest> UpdateNetworkSwitchStpAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsStpUpdateRequest updateNetworkSwitchSettingsStp,
			CancellationToken cancellationToken = default
			);
	}
}
