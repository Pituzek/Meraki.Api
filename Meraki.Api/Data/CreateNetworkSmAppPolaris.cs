using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkSmAppPolaris
	/// </summary>
	[DataContract]
	public partial class CreateNetworkSmAppPolaris
	{
		/// <summary>
		/// The scope (one of all, none, automatic, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be assigned
		/// </summary>
		/// <value>The scope (one of all, none, automatic, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be assigned</value>
		[DataMember(Name = "scope", EmitDefaultValue = false)]
		public string Scope { get; set; }
		/// <summary>
		/// The manifest URL of the Polaris app (one of manifestUrl and bundleId must be provided)
		/// </summary>
		/// <value>The manifest URL of the Polaris app (one of manifestUrl and bundleId must be provided)</value>
		[DataMember(Name = "manifestUrl", EmitDefaultValue = false)]
		public string ManifestUrl { get; set; }
		/// <summary>
		/// The bundleId of the Polaris app (one of manifestUrl and bundleId must be provided)
		/// </summary>
		/// <value>The bundleId of the Polaris app (one of manifestUrl and bundleId must be provided)</value>
		[DataMember(Name = "bundleId", EmitDefaultValue = false)]
		public string BundleId { get; set; }
		/// <summary>
		/// (optional) Whether or not SM should auto-install this app (one of true or false). False by default.
		/// </summary>
		/// <value>(optional) Whether or not SM should auto-install this app (one of true or false). False by default.</value>
		[DataMember(Name = "preventAutoInstall", EmitDefaultValue = false)]
		public bool? PreventAutoInstall { get; set; }
		/// <summary>
		/// (optional) Whether or not the app should use VPP by device assignment (one of true or false). False by default.
		/// </summary>
		/// <value>(optional) Whether or not the app should use VPP by device assignment (one of true or false). False by default.</value>
		[DataMember(Name = "usesVPP", EmitDefaultValue = false)]
		public bool? UsesVPP { get; set; }
	}
}
