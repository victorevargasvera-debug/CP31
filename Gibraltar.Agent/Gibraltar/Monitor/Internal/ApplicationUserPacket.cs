using System;
using System.Collections.Generic;
using System.Reflection;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001F5 RID: 501
	internal class ApplicationUserPacket : global::Gibraltar.Monitor.Internal.GibraltarCachedPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.ApplicationUserPacket>, global::Loupe.Extensibility.Data.IApplicationUser
	{
		// Token: 0x060018BE RID: 6334 RVA: 0x000574A4 File Offset: 0x000556A4
		public ApplicationUserPacket() : base(false)
		{
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x000574B8 File Offset: 0x000556B8
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x000574C0 File Offset: 0x000556C0
		public string Key
		{
			get
			{
				return this.m_Key;
			}
			set
			{
				this.m_Key = value;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x000574CC File Offset: 0x000556CC
		// (set) Token: 0x060018C2 RID: 6338 RVA: 0x000574D4 File Offset: 0x000556D4
		public string FullyQualifiedUserName
		{
			get
			{
				return this.m_FullyQualifiedUserName;
			}
			set
			{
				this.m_FullyQualifiedUserName = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x000574E0 File Offset: 0x000556E0
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x000574E8 File Offset: 0x000556E8
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x000574F4 File Offset: 0x000556F4
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x000574FC File Offset: 0x000556FC
		public string EmailAddress
		{
			get
			{
				return this.m_EmailAddress;
			}
			set
			{
				this.m_EmailAddress = value;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x00057508 File Offset: 0x00055708
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x00057510 File Offset: 0x00055710
		public string Phone
		{
			get
			{
				return this.m_Phone;
			}
			set
			{
				this.m_Phone = value;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0005751C File Offset: 0x0005571C
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x00057524 File Offset: 0x00055724
		public string Organization
		{
			get
			{
				return this.m_Organization;
			}
			set
			{
				this.m_Organization = value;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x00057530 File Offset: 0x00055730
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x00057538 File Offset: 0x00055738
		public string TimeZoneCode
		{
			get
			{
				return this.m_TimeZoneCode;
			}
			set
			{
				this.m_TimeZoneCode = value;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x00057544 File Offset: 0x00055744
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x0005754C File Offset: 0x0005574C
		public string Title
		{
			get
			{
				return this.m_Title;
			}
			set
			{
				this.m_Title = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x00057558 File Offset: 0x00055758
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x00057560 File Offset: 0x00055760
		public string Role
		{
			get
			{
				return this.m_Role;
			}
			set
			{
				this.m_Role = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0005756C File Offset: 0x0005576C
		// (set) Token: 0x060018D2 RID: 6354 RVA: 0x00057574 File Offset: 0x00055774
		public string Tenant
		{
			get
			{
				return this.m_Tenant;
			}
			set
			{
				this.m_Tenant = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x00057580 File Offset: 0x00055780
		public global::System.Collections.Generic.Dictionary<string, string> Properties
		{
			get
			{
				return this.m_Properties;
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00057588 File Offset: 0x00055788
		public override bool Equals(object other)
		{
			return base.Equals(other as global::Gibraltar.Monitor.Internal.ThreadInfoPacket);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00057598 File Offset: 0x00055798
		public bool Equals(global::Gibraltar.Monitor.Internal.ApplicationUserPacket other)
		{
			return other != null && ((!string.IsNullOrEmpty(this.Key) && this.Key.Equals(other.Key, global::System.StringComparison.OrdinalIgnoreCase)) || string.Equals(this.FullyQualifiedUserName, other.FullyQualifiedUserName, global::System.StringComparison.OrdinalIgnoreCase));
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x000575F4 File Offset: 0x000557F4
		public override int GetHashCode()
		{
			if (!string.IsNullOrEmpty(this.Key))
			{
				return this.Key.GetHashCode();
			}
			if (!string.IsNullOrEmpty(this.FullyQualifiedUserName))
			{
				return this.FullyQualifiedUserName.GetHashCode();
			}
			return base.GetHashCode();
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00057644 File Offset: 0x00055844
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00057648 File Offset: 0x00055848
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"Key",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"UserName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Caption",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Title",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Organization",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Role",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Tenant",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"TimeZoneCode",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"EmailAddress",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Phone",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"PropertyNames",
						global::Gibraltar.Serialization.FieldType.StringArray
					},
					{
						"PropertyValues",
						global::Gibraltar.Serialization.FieldType.StringArray
					}
				}
			};
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0005773C File Offset: 0x0005593C
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("Key", this.Key);
			packet.SetField("UserName", this.FullyQualifiedUserName);
			packet.SetField("Caption", this.Caption);
			packet.SetField("Title", this.Title);
			packet.SetField("Organization", this.Organization);
			packet.SetField("Role", this.Role);
			packet.SetField("Tenant", this.Tenant);
			packet.SetField("TimeZoneCode", this.TimeZoneCode);
			packet.SetField("EmailAddress", this.EmailAddress);
			packet.SetField("Phone", this.Phone);
			string[] array = new string[this.m_Properties.Count];
			string[] array2 = new string[this.m_Properties.Count];
			this.m_Properties.Keys.CopyTo(array, 0);
			packet.SetField("PropertyNames", array);
			this.m_Properties.Values.CopyTo(array2, 0);
			packet.SetField("PropertyValues", array2);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00057858 File Offset: 0x00055A58
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("Key", out this.m_Key);
				packet.GetField("UserName", out this.m_FullyQualifiedUserName);
				packet.GetField("Caption", out this.m_Caption);
				packet.GetField("Title", out this.m_Title);
				packet.GetField("Organization", out this.m_Organization);
				packet.GetField("Role", out this.m_Role);
				packet.GetField("Tenant", out this.m_Tenant);
				packet.GetField("TimeZoneCode", out this.m_TimeZoneCode);
				packet.GetField("EmailAddress", out this.m_EmailAddress);
				packet.GetField("Phone", out this.m_Phone);
				string[] array;
				packet.GetField("PropertyNames", out array);
				string[] array2;
				packet.GetField("PropertyValues", out array2);
				for (int i = 0; i < array.Length; i++)
				{
					string key = array[i];
					string value = array2[i];
					this.m_Properties.Add(key, value);
				}
			}
		}

		// Token: 0x040008EE RID: 2286
		private string m_Key;

		// Token: 0x040008EF RID: 2287
		private string m_FullyQualifiedUserName;

		// Token: 0x040008F0 RID: 2288
		private string m_Caption;

		// Token: 0x040008F1 RID: 2289
		private string m_Title;

		// Token: 0x040008F2 RID: 2290
		private string m_Organization;

		// Token: 0x040008F3 RID: 2291
		private string m_Role;

		// Token: 0x040008F4 RID: 2292
		private string m_Tenant;

		// Token: 0x040008F5 RID: 2293
		private string m_TimeZoneCode;

		// Token: 0x040008F6 RID: 2294
		private string m_EmailAddress;

		// Token: 0x040008F7 RID: 2295
		private string m_Phone;

		// Token: 0x040008F8 RID: 2296
		private readonly global::System.Collections.Generic.Dictionary<string, string> m_Properties = new global::System.Collections.Generic.Dictionary<string, string>();

		// Token: 0x040008F9 RID: 2297
		private const int SerializationVersion = 1;
	}
}
