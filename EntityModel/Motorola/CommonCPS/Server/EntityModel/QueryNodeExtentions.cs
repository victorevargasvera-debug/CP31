using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001B8 RID: 440
	public static class QueryNodeExtentions
	{
		// Token: 0x060016B7 RID: 5815 RVA: 0x000F4334 File Offset: 0x000F2534
		public static void AddChildNode(this global::Motorola.CommonCPS.Server.EntityModel.QueryNode node, global::Motorola.CommonCPS.Server.EntityModel.QueryNode childNode)
		{
			short num = (short)231473154;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_114;
				case 1:
				{
					num = (short)403518833;
					short num3 = num;
					num = (short)1340683633;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_116;
					default:
					{
						num = (short)668270592;
						if (num != 0)
						{
						}
						num = (short)1896022016;
						short num4 = num;
						node.ChildNodeList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.QueryNode>();
						num = (short)1294008320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (node.ChildNodeList != null)
				{
					break;
				}
				num = (short)2050818049;
				if (num != 0)
				{
				}
				num = (short)1883963393;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_114:
			IL_116:
			node.ChildNodeList.Add(childNode);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000F4464 File Offset: 0x000F2664
		public static void AddChildNode(this global::Motorola.CommonCPS.Server.EntityModel.QueryNode node, params global::Motorola.CommonCPS.Server.EntityModel.QueryNode[] childNodes)
		{
			short num = (short)1805058048;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num5;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 1:
					goto IL_14A;
				case 2:
				{
					node.ChildNodeList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.QueryNode>();
					num = (short)1313992181;
					short num3 = num;
					num = (short)163966453;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					case 1:
						break;
					default:
					{
						num = (short)1885667328;
						short num4 = num;
						break;
					}
					}
					num = (short)1283194880;
					if (num != 0)
					{
					}
					num = (short)875560965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)984678401;
					if (num != 0)
					{
					}
					if (num5 >= childNodes.Length)
					{
						num = (short)948043780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.Server.EntityModel.QueryNode item = childNodes[num5];
					node.ChildNodeList.Add(item);
					num5++;
					num = (short)1913323526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				case 5:
					goto IL_8B;
				case 6:
					goto IL_14A;
				}
				IL_40:
				if (node.ChildNodeList == null)
				{
					num = (short)103415810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8B:
				num5 = 0;
				num = (short)1666580481;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				num = (short)796327939;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x000F4620 File Offset: 0x000F2820
		public static string ToXML(this global::Motorola.CommonCPS.Server.EntityModel.QueryNode node)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(node.GetType());
			global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture);
			string result;
			short num;
			try
			{
				xmlSerializer.Serialize(stringWriter, node);
				result = stringWriter.ToString();
			}
			finally
			{
				num = (short)1385365506;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_108;
					case 1:
					{
						num = (short)487591031;
						short num3 = num;
						num = (short)1908804727;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10A;
						default:
							num = (short)211091456;
							if (num != 0)
							{
							}
							num = (short)884146177;
							if (num != 0)
							{
							}
							((global::System.IDisposable)stringWriter).Dispose();
							num = (short)2056716288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					}
					IL_5E:
					if (stringWriter == null)
					{
						break;
					}
					num = (short)750780417;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_108:
				IL_10A:;
			}
			num = (short)1272446976;
			short num4 = num;
			return result;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x000F4774 File Offset: 0x000F2974
		public static global::Motorola.CommonCPS.Server.EntityModel.QueryNode ToObject(this string xml)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.Server.EntityModel.QueryNode));
			global::System.IO.StringReader stringReader = new global::System.IO.StringReader(xml);
			global::Motorola.CommonCPS.Server.EntityModel.QueryNode result;
			short num;
			try
			{
				result = (xmlSerializer.Deserialize(stringReader) as global::Motorola.CommonCPS.Server.EntityModel.QueryNode);
			}
			finally
			{
				num = (short)1604190210;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_108;
					case 1:
					{
						num = (short)1906809300;
						short num3 = num;
						num = (short)821664212;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10A;
						default:
							num = (short)322109440;
							if (num != 0)
							{
							}
							((global::System.IDisposable)stringReader).Dispose();
							num = (short)1222049792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1806106625;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					}
					IL_84:
					if (stringReader == null)
					{
						break;
					}
					num = (short)1355939841;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_108:
				IL_10A:;
			}
			num = (short)1738276864;
			short num4 = num;
			return result;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x000F48C8 File Offset: 0x000F2AC8
		public static byte[] Serialize(this global::Motorola.CommonCPS.Server.EntityModel.QueryNode node)
		{
			short num = (short)1373306880;
			short num2 = num;
			num = (short)30927747;
			short num3 = num;
			num = (short)1487924099;
			switch (num3 == num)
			{
			}
			num = (short)360382464;
			if (num != 0)
			{
			}
			num = (short)1698430977;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.SerializeAndZip(node);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000F4978 File Offset: 0x000F2B78
		public static global::Motorola.CommonCPS.Server.EntityModel.QueryNode Deserialize(byte[] DataSource)
		{
			short num = (short)647036928;
			short num2 = num;
			num = (short)717677615;
			short num3 = num;
			num = (short)799794223;
			switch (num3 == num)
			{
			}
			num = (short)1421082625;
			if (num != 0)
			{
			}
			num = (short)1584463872;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.DeserializeAndUnzip<global::Motorola.CommonCPS.Server.EntityModel.QueryNode>(DataSource);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000F4A28 File Offset: 0x000F2C28
		public static void UnionOp(this global::Motorola.CommonCPS.Server.EntityModel.QueryNode node, global::System.Collections.Generic.List<global::System.Guid> targetSet)
		{
			short num = (short)1068367873;
			if (num != 0)
			{
			}
			num = (short)974651394;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_110;
				case 1:
				{
					num = (short)769418460;
					short num3 = num;
					num = (short)1821664476;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_112;
					default:
					{
						num = (short)186515456;
						if (num != 0)
						{
						}
						num = (short)2123825152;
						short num4 = num;
						node.ResultSet = new global::System.Collections.Generic.List<global::System.Guid>();
						num = (short)253493248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				}
				IL_57:
				if (node.ResultSet != null)
				{
					break;
				}
				num = (short)597557249;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			IL_112:
			node.ResultSet = node.ResultSet.Union(targetSet).ToList<global::System.Guid>();
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000F4B60 File Offset: 0x000F2D60
		public static void IntersectOp(this global::Motorola.CommonCPS.Server.EntityModel.QueryNode node, global::System.Collections.Generic.List<global::System.Guid> targetSet)
		{
			short num = (short)1779105793;
			if (num != 0)
			{
			}
			num = (short)1299054592;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
					goto IL_9B;
				case 2:
					node.ResultSet = new global::System.Collections.Generic.List<global::System.Guid>();
					num = (short)396623873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5A:
				if (node.ResultSet == null)
				{
					num = (short)1846804482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9B:
				num = (short)1520893952;
				short num3 = num;
				num = (short)1719738172;
				short num4 = num;
				num = (short)1913265980;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_FA;
				}
			}
			IL_FA:
			num = (short)980680704;
			if (num != 0)
			{
			}
			node.ResultSet = node.ResultSet.Intersect(targetSet).ToList<global::System.Guid>();
		}
	}
}
