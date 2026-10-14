using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200018C RID: 396
	[global::System.Serializable]
	public class AstroASKProgrammingHistory
	{
		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x000E26C0 File Offset: 0x000E08C0
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x000E2770 File Offset: 0x000E0970
		public int Version
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1309933568;
				short num2 = num;
				num = (short)719634542;
				short num3 = num;
				num = (short)436584558;
				switch (num3 == num)
				{
				}
				num = (short)1446903809;
				if (num != 0)
				{
				}
				num = (short)1641021440;
				if (num != 0)
				{
				}
				return this.<Version>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)152043520;
				short num2 = num;
				num = (short)743426381;
				short num3 = num;
				num = (short)167299405;
				switch (num3 == num)
				{
				}
				num = (short)1195048961;
				if (num != 0)
				{
				}
				num = (short)1848967168;
				if (num != 0)
				{
				}
				this.<Version>k__BackingField = value;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x000E2820 File Offset: 0x000E0A20
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x000E28D0 File Offset: 0x000E0AD0
		public global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.Server.EntityModel.ASKProgrammingHistoryItem> Recset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)913440768;
				short num2 = num;
				num = (short)1241841665;
				if (num != 0)
				{
				}
				num = (short)1747035435;
				short num3 = num;
				num = (short)307340587;
				switch (num3 == num)
				{
				}
				num = (short)215154688;
				if (num != 0)
				{
				}
				return this.<Recset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)422051840;
				short num2 = num;
				num = (short)1476201940;
				short num3 = num;
				num = (short)560795092;
				switch (num3 == num)
				{
				}
				num = (short)17367040;
				if (num != 0)
				{
				}
				num = (short)2028666881;
				if (num != 0)
				{
				}
				this.<Recset>k__BackingField = value;
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000E2980 File Offset: 0x000E0B80
		public AstroASKProgrammingHistory()
		{
			this.a = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.Server.EntityModel.AstroASKProgrammingHistory));
			base..ctor();
			this.Version = 1;
			this.Recset = new global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.Server.EntityModel.ASKProgrammingHistoryItem>();
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000E29BC File Offset: 0x000E0BBC
		public AstroASKProgrammingHistory(string xmlData)
		{
			int a_ = 13;
			this.a = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.Server.EntityModel.AstroASKProgrammingHistory));
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
							global::Motorola.CommonCPS.Server.EntityModel.AstroASKProgrammingHistory astroASKProgrammingHistory = (global::Motorola.CommonCPS.Server.EntityModel.AstroASKProgrammingHistory)this.a.Deserialize(xmlNodeReader);
							this.Version = astroASKProgrammingHistory.Version;
							this.Recset = astroASKProgrammingHistory.Recset;
						}
					}
					this.a();
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䨊希䐎䄐愒稔瀖欘稚瀜爞䠠䴢䈤漦䀨堪夬䀮䌰䨲ᔴ吶嘸为儼嬾慀ⵂ⩄㍆楈⥊⡌潎㕐㙒♔㉖⭘㉚㱜㍞ࡠᥢdͦ䥨൪Ὤnᱰ卲⵴㩶㕸孺᥼Ṿ뾄Ꞇ", a_) + ex.Message);
				}
			}
			else
			{
				this.Version = 1;
				this.Recset = new global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.Server.EntityModel.ASKProgrammingHistoryItem>();
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000E2AE8 File Offset: 0x000E0CE8
		public string ToXML()
		{
			int a_ = 2;
			short num = (short)1811677185;
			if (num != 0)
			{
			}
			num = (short)116916224;
			short num2 = num;
			num = (short)1529775054;
			short num3 = num;
			num = (short)246514638;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1271398400;
				if (num != 0)
				{
				}
				num = (short)1665990656;
				switch (num)
				{
				}
				break;
			}
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
					num = (short)1463091200;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_13C;
							}
							continue;
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)328794114;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_173;
						}
						IL_13C:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1770127361;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_173:;
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䇿儁伃嘅稇攉欋簍焏缑礓缕瘗紙君眝匟嘡䬣吥儧਩伫䄭䔯帱倳ᘵ嘷唹䠻ḽ∿❁摃㕅ⵇ㡉╋⽍㱏㭑⹓㍕㱗恙籛", a_) + ex.Message);
			}
			return result;
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x000E2CAC File Offset: 0x000E0EAC
		private void a()
		{
			int a_ = 12;
			short num = (short)83722079;
			short num2 = num;
			num = (short)176127839;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C3;
			case 1:
				break;
			default:
			{
				num = (short)1409613824;
				short num3 = num;
				break;
			}
			}
			num = (short)1761935360;
			if (num != 0)
			{
			}
			num = (short)1696727041;
			if (num != 0)
			{
			}
			num = (short)731250688;
			switch (num)
			{
			default:
			{
				IL_C3:
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASKProgrammingHistoryItem> enumerator = this.Recset.GetEnumerator();
				try
				{
					num = (short)291700738;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASKProgrammingHistoryItem askprogrammingHistoryItem;
							global::System.DateTime dateTime;
							if (global::System.DateTime.TryParse(askprogrammingHistoryItem.LastProgramDateTime, out dateTime))
							{
								num = (short)28901377;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							global::System.DateTime dateTime;
							string lastProgramDateTime = dateTime.ToUniversalTime().ToString(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔉", a_), global::System.Globalization.CultureInfo.CurrentCulture);
							global::Motorola.CommonCPS.Server.EntityModel.ASKProgrammingHistoryItem askprogrammingHistoryItem;
							askprogrammingHistoryItem.LastProgramDateTime = lastProgramDateTime;
							num = (short)1239744515;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_114;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)125632518;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.ASKProgrammingHistoryItem askprogrammingHistoryItem = enumerator.Current;
							global::System.DateTime dateTime = new global::System.DateTime(0L);
							num = (short)1520107520;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_203;
						case 6:
							num = (short)969080837;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_164:
						num = (short)1657077764;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_114:
						goto IL_164;
					}
					IL_203:;
				}
				finally
				{
					num = (short)1138098176;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_238;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1925906434;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_26E;
						}
						IL_238:
						if (enumerator == null)
						{
							break;
						}
						num = (short)237699073;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_26E:;
				}
				return;
			}
			}
		}

		// Token: 0x040009FD RID: 2557
		[global::System.NonSerialized]
		private global::System.Xml.Serialization.XmlSerializer a;
	}
}
