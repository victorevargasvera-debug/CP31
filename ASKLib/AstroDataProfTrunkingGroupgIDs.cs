using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Motorola.CommonCPS.ResourceRepository;

namespace ASKLib
{
	// Token: 0x02000006 RID: 6
	[global::System.Serializable]
	public class AstroDataProfTrunkingGroupgIDs
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002EA8 File Offset: 0x000010A8
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002F54 File Offset: 0x00001154
		public int Version
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)494443657;
				short num2 = num;
				num = (short)675781769;
				switch (num2 == num)
				{
				}
				num = (short)1652883456;
				short num3 = num;
				num = (short)2023096321;
				if (num != 0)
				{
				}
				num = (short)1334444032;
				if (num != 0)
				{
				}
				return this.<Version>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1599079070;
				short num2 = num;
				num = (short)2020147870;
				switch (num2 == num)
				{
				}
				num = (short)689766400;
				short num3 = num;
				num = (short)1816788992;
				if (num != 0)
				{
				}
				num = (short)1796603905;
				if (num != 0)
				{
				}
				this.<Version>k__BackingField = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00003004 File Offset: 0x00001204
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000030B4 File Offset: 0x000012B4
		public global::System.Collections.ObjectModel.Collection<global::ASKLib.Astro25DataGroupID> Recset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1874632503;
				short num2 = num;
				num = (short)501587767;
				switch (num2 == num)
				{
				}
				num = (short)1775960064;
				short num3 = num;
				num = (short)1203765249;
				if (num != 0)
				{
				}
				num = (short)87687168;
				if (num != 0)
				{
				}
				return this.<Recset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1774321665;
				if (num != 0)
				{
				}
				num = (short)279910193;
				short num2 = num;
				num = (short)65673009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750059520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)213188608;
				if (num != 0)
				{
				}
				this.<Recset>k__BackingField = value;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003164 File Offset: 0x00001364
		internal AstroDataProfTrunkingGroupgIDs()
		{
			this.Version = 1;
			this.Recset = new global::System.Collections.ObjectModel.Collection<global::ASKLib.Astro25DataGroupID>();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000031A0 File Offset: 0x000013A0
		public AstroDataProfTrunkingGroupgIDs(string xmlData)
		{
			if (!string.IsNullOrWhiteSpace(xmlData))
			{
				try
				{
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Text.Encoding.UTF8.GetBytes(xmlData));
					memoryStream.Flush();
					memoryStream.Position = 0L;
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(memoryStream);
					global::System.Xml.XmlNodeReader xmlReader = new global::System.Xml.XmlNodeReader(xmlDocument.DocumentElement);
					global::ASKLib.AstroDataProfTrunkingGroupgIDs astroDataProfTrunkingGroupgIDs = (global::ASKLib.AstroDataProfTrunkingGroupgIDs)this.x.Deserialize(xmlReader);
					this.Version = astroDataProfTrunkingGroupgIDs.Version;
					this.Recset = astroDataProfTrunkingGroupgIDs.Recset;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::Motorola.CommonCPS.ResourceRepository.Resources.RMSU_Error_Deserialize_TrkGroupIDs + ex.Message);
				}
			}
			else
			{
				this.Version = 1;
				this.Recset = new global::System.Collections.ObjectModel.Collection<global::ASKLib.Astro25DataGroupID>();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003270 File Offset: 0x00001470
		internal string a()
		{
			short num = (short)577420731;
			short num2 = num;
			num = (short)39697851;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_D2;
			case 1:
				break;
			default:
			{
				num = (short)1108934656;
				short num3 = num;
				break;
			}
			}
			num = (short)1062993920;
			if (num != 0)
			{
			}
			string result = null;
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::System.Xml.Serialization.XmlSerializerNamespaces xmlSerializerNamespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
				xmlSerializerNamespaces.Add("", "");
				this.x.Serialize(memoryStream, this, xmlSerializerNamespaces);
				result = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
				memoryStream.Close();
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::Motorola.CommonCPS.ResourceRepository.Resources.RMSU_Error_Serialize_TrkGroupIDs + ex.Message);
			}
			IL_D2:
			num = (short)1594294273;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0400000A RID: 10
		private global::System.Xml.Serialization.XmlSerializer x = new global::System.Xml.Serialization.XmlSerializer(typeof(global::ASKLib.AstroDataProfTrunkingGroupgIDs));
	}
}
