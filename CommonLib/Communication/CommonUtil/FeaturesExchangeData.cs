using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000034 RID: 52
	[global::System.Xml.Serialization.XmlType("F")]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class FeaturesExchangeData
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0001A038 File Offset: 0x00018238
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0001A0E8 File Offset: 0x000182E8
		[global::System.Xml.Serialization.XmlElement("X")]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> XmlBufferInput
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1136657474;
				short num2 = num;
				num = (short)487064642;
				switch (num2 == num)
				{
				}
				num = (short)918290432;
				short num3 = num;
				num = (short)493486081;
				if (num != 0)
				{
				}
				num = (short)626065408;
				if (num != 0)
				{
				}
				return this.<XmlBufferInput>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1483738166;
				short num2 = num;
				num = (short)49679414;
				switch (num2 == num)
				{
				}
				num = (short)1775435776;
				short num3 = num;
				num = (short)1132527617;
				if (num != 0)
				{
				}
				num = (short)332464128;
				if (num != 0)
				{
				}
				this.<XmlBufferInput>k__BackingField = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0001A198 File Offset: 0x00018398
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0001A248 File Offset: 0x00018448
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlElement("I")]
		public global::System.Collections.Generic.List<byte[]> FeatureCodeIDs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1299562863;
				short num2 = num;
				num = (short)761250159;
				switch (num2 == num)
				{
				}
				num = (short)271384576;
				short num3 = num;
				num = (short)421134337;
				if (num != 0)
				{
				}
				num = (short)1775566848;
				if (num != 0)
				{
				}
				return this.<FeatureCodeIDs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1584950697;
				short num2 = num;
				num = (short)1999203753;
				switch (num2 == num)
				{
				}
				num = (short)834535424;
				short num3 = num;
				num = (short)1015611392;
				if (num != 0)
				{
				}
				num = (short)928710657;
				if (num != 0)
				{
				}
				this.<FeatureCodeIDs>k__BackingField = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0001A2FC File Offset: 0x000184FC
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0001A3AC File Offset: 0x000185AC
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlElement("N")]
		public global::System.Collections.Generic.List<int> FeatureNames
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)557492883;
				short num2 = num;
				num = (short)1162914451;
				switch (num2 == num)
				{
				}
				num = (short)204996608;
				short num3 = num;
				num = (short)1573781505;
				if (num != 0)
				{
				}
				num = (short)2088697856;
				if (num != 0)
				{
				}
				return this.<FeatureNames>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)111173323;
				short num2 = num;
				num = (short)1180982987;
				switch (num2 == num)
				{
				}
				num = (short)1429209088;
				short num3 = num;
				num = (short)195362816;
				if (num != 0)
				{
				}
				num = (short)435290113;
				if (num != 0)
				{
				}
				this.<FeatureNames>k__BackingField = value;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001A460 File Offset: 0x00018660
		public FeaturesExchangeData()
		{
			this.XmlBufferInput = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem>();
			this.FeatureCodeIDs = new global::System.Collections.Generic.List<byte[]>();
			this.FeatureNames = new global::System.Collections.Generic.List<int>();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0001A494 File Offset: 0x00018694
		public string SerializeToXml()
		{
			short num = (short)1992520522;
			short num2 = num;
			num = (short)2045866826;
			string result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1438121984;
				short num3 = num;
				break;
			}
			}
			num = (short)798949377;
			if (num != 0)
			{
			}
			num = (short)110100480;
			if (num != 0)
			{
			}
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(base.GetType());
			global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture);
			try
			{
				xmlSerializer.Serialize(stringWriter, this);
				result = stringWriter.ToString();
			}
			finally
			{
				num = (short)1705050113;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						((global::System.IDisposable)stringWriter).Dispose();
						num = (short)1635057666;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_F2;
						}
						continue;
					case 2:
						goto IL_125;
					}
					IL_F2:
					if (stringWriter == null)
					{
						break;
					}
					num = (short)1012400128;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_125:;
			}
			return result;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0001A5DC File Offset: 0x000187DC
		public static global::Motorola.Common.Communication.CommonUtil.FeaturesExchangeData DeserializeFromXml(string xmlInput)
		{
			short num = (short)1072016572;
			short num2 = num;
			num = (short)1039445180;
			global::Motorola.Common.Communication.CommonUtil.FeaturesExchangeData result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)23986176;
				short num3 = num;
				break;
			}
			}
			num = (short)868745217;
			if (num != 0)
			{
			}
			num = (short)1275133952;
			if (num != 0)
			{
			}
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.CommonUtil.FeaturesExchangeData));
			global::System.IO.StringReader stringReader = new global::System.IO.StringReader(xmlInput);
			try
			{
				result = (global::Motorola.Common.Communication.CommonUtil.FeaturesExchangeData)xmlSerializer.Deserialize(stringReader);
			}
			finally
			{
				num = (short)1531052033;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						((global::System.IDisposable)stringReader).Dispose();
						num = (short)689635330;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_F3;
						}
						continue;
					case 2:
						goto IL_128;
					}
					IL_F3:
					if (stringReader == null)
					{
						break;
					}
					num = (short)882311168;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_128:;
			}
			return result;
		}
	}
}
