﻿using Divergic.Logging.Xunit;
using Meraki.Api.Exceptions;
using Meraki.Api.Test.Config;
using Newtonsoft.Json;

namespace Meraki.Api.Test;

public class MerakiClientTest
{
	protected DateTimeOffset UtcNow { get; } = DateTimeOffset.UtcNow;

	protected DateTimeOffset Utc10DaysAgo => UtcNow - TimeSpan.FromDays(10);

	private MerakiClient? _merakiClient;

	private Configuration? _configuration;

	protected ICacheLogger Logger { get; }

	public MerakiClientTest(ITestOutputHelper iTestOutputHelper)
	{
		Logger = iTestOutputHelper.BuildLogger();
	}

	public Configuration Configuration
	{
		get
		{
			// Have we already created this?
			if (_configuration != null)
			{
				// Yes - return that one
				return _configuration;
			}
			// No - we need to create one

			// Load config from file
			var fileInfo = new FileInfo("../../../appsettings.json");

			// Does the config file exist?
			if (!fileInfo.Exists)
			{
				// No - hint to the user what to do
				throw new ConfigurationException("Missing appsettings.json.  Please copy the appsettings.example.json in the project root folder and set the various values appropriately.");
			}
			// Yes

			// Load in the config
			_configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(fileInfo.FullName));
			if (_configuration is null)
			{
				throw new ConfigurationException("Configuration did not deserialize");
			}
			_configuration.Validate();
			return _configuration;
		}
	}

	protected MerakiClient TestMerakiClient
		=> _merakiClient ??= new MerakiClient(Configuration.MerakiClientOptions, Logger);

	protected async Task<Network> GetFirstNetworkAsync()
	{
		var networks = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		networks.Should().NotBeNull();
		networks.Should().NotBeEmpty();
		return networks[0];
	}

	protected async Task<Network> CreateTestNetworkAsync()
	{
		var network = await TestMerakiClient
			.Organizations
			.Networks
			.CreateOrganizationNetworkAsync(
				Configuration.TestOrganizationId,
				new NetworkCreationRequest
				{
					Name = $"XUnit {Guid.NewGuid()}",
					ProductTypes = new()
					{
						ProductType.Appliance,
						ProductType.Switch,
						ProductType.Camera
					},
					Notes = $"Created as part of unit testing on {DateTime.UtcNow}, should be removed automatically"
				}
			)
			.ConfigureAwait(false);
		network.Should().NotBeNull();
		return network;
	}

	protected Task RemoveNetworkAsync(string networkId)
		=> TestMerakiClient
			.Networks
			.DeleteNetworkAsync(networkId)
;
}
