﻿namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceSection
{
	public IApplianceConnectivityMonitoringDestinations ConnectivityMonitoringDestinations { get; internal set; } = null!
	public IAppliancePerformance Performance { get; internal set; } = null!;
	public ApplianceSecuritySection Security { get; internal set; } = new();
	public ApplianceVpnSection Vpn { get; internal set; } = new();
	public ApplianceDhcpSection Dhpc { get; internal set; } = new();
}
