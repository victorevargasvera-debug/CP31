using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using Motorola.Common.CommonLib;
using PreEmptive.SoS.Runtime;
using SpecialFeatures.Comms;

namespace MackinawCPS
{
	// Token: 0x02000028 RID: 40
	public class CpsVersionResolver
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000FA30 File Offset: 0x0000DC30
		public static global::MackinawCPS.CpsVersionResolver Instance
		{
			get
			{
				short num = (short)791478272;
				short num2 = num;
				num = (short)1854752285;
				short num3 = num;
				num = (short)510084637;
				switch (num3 == num)
				{
				}
				num = (short)1465647105;
				if (num != 0)
				{
				}
				num = (short)485359616;
				if (num != 0)
				{
				}
				return global::MackinawCPS.CpsVersionResolver._instance;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000FB8C File Offset: 0x0000DD8C
		public bool IsItCpsWithoutAnRm
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)3080192;
				short num2 = num;
				num = (short)1054081025;
				if (num != 0)
				{
				}
				num = (short)144022779;
				short num3 = num;
				num = (short)207985915;
				switch (num3 == num)
				{
				}
				num = (short)198180864;
				if (num != 0)
				{
				}
				return this.<IsItCpsWithoutAnRm>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1147666432;
				short num2 = num;
				num = (short)755514692;
				short num3 = num;
				num = (short)256654660;
				switch (num3 == num)
				{
				}
				num = (short)801832960;
				if (num != 0)
				{
				}
				num = (short)545849345;
				if (num != 0)
				{
				}
				this.<IsItCpsWithoutAnRm>k__BackingField = value;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		private CpsVersionResolver()
		{
			this.GetValueFromXml();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000FC58 File Offset: 0x0000DE58
		private void GetValueFromXml()
		{
			int a_ = 19;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_3D;
				}
				int num;
				global::System.Xml.XmlTextReader xmlTextReader;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)1335754755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_190;
					case 2:
						xmlTextReader.Read();
						this.IsItCpsWithoutAnRm = global::System.Convert.ToBoolean(xmlTextReader.Value);
						num2 = (short)1479606280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_1E4;
					case 4:
						if (xmlTextReader.ReadToDescendant(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뫲蛴뻶跸룺跼賾嘀樂焄漆昈縊礌与缐䄒研", a_)))
						{
							num2 = (short)1731657730;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_190;
					case 5:
						num2 = (short)2103574532;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (!xmlTextReader.Read())
						{
							num2 = (short)1035534336;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1558052871;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
					{
						num2 = (short)507492420;
						short num3 = num2;
						num2 = (short)1403893828;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)2014576640;
							if (num2 != 0)
							{
							}
							if (xmlTextReader.NodeType == global::System.Xml.XmlNodeType.Element)
							{
								num2 = (short)300548101;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_190;
						}
						break;
					}
					case 8:
						goto IL_190;
					}
					goto IL_3D;
					IL_190:
					num2 = (short)948109318;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1E4:
				goto IL_1F9;
				IL_3D:
				xmlTextReader = new global::System.Xml.XmlTextReader(global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.Instance.DecryptFileToStream(global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location), global::PreEmptive.SoS.Runtime.FixedLengthStream.b("郲藴蓶뫸铺鏼駾栀搂⬄缆搈朊⌌紎簐", a_)), false));
				num2 = (short)2093219841;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::System.Exception ex)
			{
				this.IsItCpsWithoutAnRm = true;
				global::SpecialFeatures.Comms.Logger.Log(ex.Message);
			}
			IL_1F9:
			num2 = (short)1501888513;
			if (num2 != 0)
			{
			}
			num2 = (short)1033699328;
			short num4 = num2;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000FECC File Offset: 0x0000E0CC
		// Note: this type is marked as 'beforefieldinit'.
		static CpsVersionResolver()
		{
			short num = (short)1546846208;
			short num2 = num;
			num = (short)1376661509;
			short num3 = num;
			num = (short)33501189;
			switch (num3 == num)
			{
			}
			num = (short)263454720;
			if (num != 0)
			{
			}
			num = (short)2145452033;
			if (num != 0)
			{
			}
			global::MackinawCPS.CpsVersionResolver._instance = new global::MackinawCPS.CpsVersionResolver();
		}

		// Token: 0x04000040 RID: 64
		private const string RmConfigFileName = "cpsConfig.xml.rm";

		// Token: 0x04000041 RID: 65
		private static readonly global::MackinawCPS.CpsVersionResolver _instance;

		// Token: 0x04000042 RID: 66
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
