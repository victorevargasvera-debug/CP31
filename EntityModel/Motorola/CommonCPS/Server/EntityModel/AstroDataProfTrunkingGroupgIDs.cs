using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200018E RID: 398
	[global::System.Serializable]
	public class AstroDataProfTrunkingGroupgIDs
	{
		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x000E321C File Offset: 0x000E141C
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x000E32C8 File Offset: 0x000E14C8
		public int Version
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1240072192;
				short num2 = num;
				num = (short)1337262081;
				if (num != 0)
				{
				}
				num = (short)634071912;
				short num3 = num;
				num = (short)220343144;
				switch (num3 == num)
				{
				}
				num = (short)1307639808;
				if (num != 0)
				{
				}
				return this.<Version>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)460193792;
				short num2 = num;
				num = (short)1593768684;
				short num3 = num;
				num = (short)1825569516;
				switch (num3 == num)
				{
				}
				num = (short)1417936897;
				if (num != 0)
				{
				}
				num = (short)139329536;
				if (num != 0)
				{
				}
				this.<Version>k__BackingField = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000E3378 File Offset: 0x000E1578
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x000E3424 File Offset: 0x000E1624
		public global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.Server.EntityModel.Astro25DataGroupID> Recset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1858535424;
				short num2 = num;
				num = (short)1142802579;
				short num3 = num;
				num = (short)607897747;
				switch (num3 == num)
				{
				}
				num = (short)558628864;
				if (num != 0)
				{
				}
				num = (short)1249509377;
				if (num != 0)
				{
				}
				return this.<Recset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1647247360;
				short num2 = num;
				num = (short)982108544;
				short num3 = num;
				num = (short)1159317888;
				switch (num3 == num)
				{
				}
				num = (short)528089089;
				if (num != 0)
				{
				}
				num = (short)375259136;
				if (num != 0)
				{
				}
				this.<Recset>k__BackingField = value;
			}
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000E34D8 File Offset: 0x000E16D8
		public AstroDataProfTrunkingGroupgIDs()
		{
			this.a = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.Server.EntityModel.AstroDataProfTrunkingGroupgIDs));
			base..ctor();
			this.Version = 1;
			this.Recset = new global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.Server.EntityModel.Astro25DataGroupID>();
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000E3514 File Offset: 0x000E1714
		public AstroDataProfTrunkingGroupgIDs(string xmlData)
		{
			int a_ = 17;
			this.a = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.Server.EntityModel.AstroDataProfTrunkingGroupgIDs));
			base..ctor();
			if (!string.IsNullOrWhiteSpace(xmlData))
			{
				try
				{
					using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Text.Encoding.UTF8.GetBytes(xmlData)))
					{
						memoryStream.Flush();
						memoryStream.Position = 0L;
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(memoryStream);
						using (global::System.Xml.XmlNodeReader xmlNodeReader = new global::System.Xml.XmlNodeReader(xmlDocument.DocumentElement))
						{
							global::Motorola.CommonCPS.Server.EntityModel.AstroDataProfTrunkingGroupgIDs astroDataProfTrunkingGroupgIDs = (global::Motorola.CommonCPS.Server.EntityModel.AstroDataProfTrunkingGroupgIDs)this.a.Deserialize(xmlNodeReader);
							this.Version = astroDataProfTrunkingGroupgIDs.Version;
							this.Recset = astroDataProfTrunkingGroupgIDs.Recset;
						}
					}
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("与成朒朔砖崘稚検縞焠儢䨤䄦紨太堬䄮娰娲嬴倶縸䤺刼䨾ㅀ⑂ౄ͆㩈歊⹌⁎⑐㽒ㅔ睖㝘㑚⥜罞͠٢䕤ͦ౨ᡪ࡬ᵮᡰቲᥴṶ͸Ṻ᥼彾ꦈ펊삌쎎놐ꆚ붜", a_) + ex.Message);
				}
			}
			else
			{
				this.Version = 1;
				this.Recset = new global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.Server.EntityModel.Astro25DataGroupID>();
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000E3638 File Offset: 0x000E1838
		public string ToXML()
		{
			int a_ = 8;
			short num = (short)1364199821;
			short num2 = num;
			num = (short)1328548237;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9C;
			case 1:
				break;
			default:
			{
				num = (short)1540816896;
				short num3 = num;
				break;
			}
			}
			num = (short)1778647040;
			if (num != 0)
			{
			}
			num = (short)1588985856;
			switch (num)
			{
			default:
			{
				IL_9C:
				string result = null;
				try
				{
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					try
					{
						global::System.Xml.Serialization.XmlSerializerNamespaces xmlSerializerNamespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
						xmlSerializerNamespaces.Add("", "");
						this.a.Serialize(memoryStream, this, xmlSerializerNamespaces);
						result = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
						memoryStream.Close();
					}
					finally
					{
						num = (short)631701504;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_117;
								}
								continue;
							case 1:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)28901378;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_14D;
							}
							IL_117:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)818872321;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_14D:;
					}
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䜅笇縉縋愍吏猑怓眕䠗栙猛砝琟倡儣䠥䌧䌩䈫䤭眯䀱嬳䌵䠷崹画稽㌿扁❃⥅㵇♉⡋湍㹏㵑⁓癕㩗㽙籛ⵝ՟ၡൣݥѧͩᙫ୭ᑯ䡱味", a_) + ex.Message);
				}
				num = (short)1978466305;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x04000A02 RID: 2562
		[global::System.NonSerialized]
		private global::System.Xml.Serialization.XmlSerializer a;
	}
}
