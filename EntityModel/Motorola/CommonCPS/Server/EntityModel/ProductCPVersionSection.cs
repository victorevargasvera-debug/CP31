using System;
using System.Linq;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001AF RID: 431
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ProductCPVersionSection
	{
		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x000F0248 File Offset: 0x000EE448
		public bool IsCPVersionSensitive
		{
			get
			{
				short num;
				if (this._startVersion != null)
				{
					num = (short)1570225005;
					short num2 = num;
					num = (short)846969709;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)908656640;
						if (num != 0)
						{
						}
						return true;
					}
				}
				num = (short)1876099072;
				short num3 = num;
				num = (short)180617217;
				if (num != 0)
				{
				}
				return this._endVersion != null;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x000F0310 File Offset: 0x000EE510
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x000F03C0 File Offset: 0x000EE5C0
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily Product
		{
			get
			{
				short num = (short)687577641;
				short num2 = num;
				num = (short)2030213673;
				switch (num2 == num)
				{
				}
				num = (short)403636225;
				if (num != 0)
				{
				}
				num = (short)406388736;
				if (num != 0)
				{
				}
				num = (short)1938882560;
				short num3 = num;
				return this._productLineFlag;
			}
			set
			{
				short num = (short)1083934564;
				short num2 = num;
				num = (short)1390643044;
				switch (num2 == num)
				{
				}
				num = (short)1259077633;
				if (num != 0)
				{
				}
				num = (short)2000879616;
				if (num != 0)
				{
				}
				num = (short)1999962112;
				short num3 = num;
				this._productLineFlag = value;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x000F0470 File Offset: 0x000EE670
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x000F068C File Offset: 0x000EE88C
		public string CPVersionString
		{
			get
			{
				int a_ = 16;
				switch (0)
				{
				case 0:
					goto IL_39;
				}
				int num;
				string str;
				short num2;
				string text;
				for (;;)
				{
					IL_13:
					string str2;
					switch (num)
					{
					case 0:
					{
						str = this._startVersion.ToString();
						num2 = (short)368445961;
						short num3 = num2;
						num2 = (short)1204488713;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_54;
						default:
							num2 = (short)608108544;
							if (num2 != 0)
							{
							}
							num2 = (short)855638022;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						str2 = this._endVersion.ToString();
						num2 = (short)1356660740;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_D0;
					case 3:
						if (text.Length != 1)
						{
							num2 = (short)712638466;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_20A;
					case 4:
						goto IL_7E;
					case 5:
						if (this._endVersion != null)
						{
							num2 = (short)290979841;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_7E;
					case 6:
						goto IL_1BF;
					case 7:
						goto IL_54;
					}
					goto IL_39;
					IL_54:
					if (this._startVersion != null)
					{
						num2 = (short)1592066048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BF;
					IL_7E:
					text = str + global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("⌍", a_) + str2;
					num2 = (short)680394755;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1BF:
					str2 = string.Empty;
					num2 = (short)657588229;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_D0:
				num2 = (short)562233345;
				if (num2 != 0)
				{
				}
				num2 = (short)812580864;
				short num4 = num2;
				return text;
				IL_20A:
				return string.Empty;
				IL_39:
				str = string.Empty;
				num2 = (short)1398472711;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			set
			{
				int a_ = 6;
				short num = (short)1578696709;
				int num2 = (int)((global::System.IntPtr)num);
				string[] array;
				for (;;)
				{
					num = (short)1418985472;
					short num3 = num;
					switch (num2)
					{
					case 0:
						array = value.Split(new char[]
						{
							'-'
						});
						num = (short)1444610060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_13C;
					case 2:
						if (array.Length == 2)
						{
							num = (short)816840712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					case 3:
						num = (short)737017857;
						if (num != 0)
						{
						}
						goto IL_1C0;
					case 4:
						goto IL_1C0;
					case 5:
						goto IL_1E;
					case 6:
						if (string.IsNullOrWhiteSpace(value))
						{
							num = (short)907477001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1034813450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!string.IsNullOrEmpty(array[1]))
						{
							num = (short)1706491905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					case 8:
						num = (short)697499655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1BE;
					case 10:
						if (value.Contains('-'))
						{
							num = (short)738197504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E3;
					case 11:
						this._startVersion = new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(array[0]);
						num = (short)136708099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!string.IsNullOrEmpty(array[0]))
						{
							num = (short)351338507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this._startVersion = null;
						num = (short)1955659780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)717881350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F;
					IL_1E:
					switch (0)
					{
					case 0:
					{
						IL_8F:
						if (string.IsNullOrEmpty(value))
						{
							goto IL_160;
						}
						num = (short)1647240688;
						short num4 = num;
						num = (short)1409476080;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
							num = (short)795279360;
							if (num != 0)
							{
							}
							num = (short)1846214669;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
					continue;
					IL_1C0:
					num = (short)1197867010;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13C:
				this._endVersion = new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(array[1]);
				return;
				IL_160:
				throw new global::System.Runtime.Serialization.InvalidDataContractException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("怃椅⠇搉挋稍』簑焓猕簗㨙樛笝刟儡䴣䤥䘧਩䔫䠭ု圱夳䘵䰷䌹᰻䴽㐿ぁⵃ⡅⽇", a_));
				IL_1BE:
				goto IL_160;
				IL_1FA:
				this._endVersion = null;
				return;
				IL_2E3:
				this._startVersion = new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(value);
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x000F0988 File Offset: 0x000EEB88
		public global::Motorola.CommonCPS.Server.EntityModel.BLVersion StartVersion
		{
			get
			{
				short num = (short)2033687264;
				short num2 = num;
				num = (short)1493605088;
				switch (num2 == num)
				{
				}
				num = (short)625541120;
				if (num != 0)
				{
				}
				num = (short)657457153;
				if (num != 0)
				{
				}
				num = (short)308936704;
				short num3 = num;
				return this._startVersion;
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000F0A38 File Offset: 0x000EEC38
		public bool IsMatch(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily docProductductLine, global::Motorola.CommonCPS.Server.EntityModel.BLVersion docCPVersion)
		{
			short num = (short)1331232773;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this._endVersion != null)
					{
						num = (short)1035665421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_217;
				case 1:
					goto IL_323;
				case 2:
					if (this._startVersion != null)
					{
						num = (short)744882188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 3:
					if (docCPVersion == global::Motorola.CommonCPS.Server.EntityModel.BLVersion.DefaultBLVersion)
					{
						num = (short)68550670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1084162056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1747303424;
					short num3 = num;
					num = (short)1691663360;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_217;
					default:
						num = (short)260112384;
						if (num != 0)
						{
						}
						num = (short)1173094421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_8D;
					}
					continue;
				case 6:
					return false;
				case 7:
					return true;
				case 8:
					if (this._endVersion > docCPVersion)
					{
						num = (short)1210974209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 9:
					if (docCPVersion == global::Motorola.CommonCPS.Server.EntityModel.BLVersion.DefaultBLVersion)
					{
						num = (short)1027473414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)728170521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.StartVersion <= docCPVersion)
					{
						num = (short)1160314884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 11:
					return true;
				case 12:
					num = (short)372310031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1911095299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					return false;
				case 15:
					if (this._endVersion == null)
					{
						num = (short)1277034515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 16:
					num = (short)752877568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)26148888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					return true;
				case 19:
					num = (short)1083965449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)181075990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (this._endVersion > docCPVersion)
					{
						num = (short)1988427794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 22:
					if (this._endVersion == null)
					{
						num = (short)1245708295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38F;
				case 23:
					num = (short)369426433;
					if (num != 0)
					{
					}
					if (this._startVersion == null)
					{
						num = (short)1967063056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_217;
				case 24:
					if (this._startVersion == null)
					{
						num = (short)1059586068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38F;
				case 25:
					if (this._startVersion <= docCPVersion)
					{
						num = (short)714276875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_8D:
				if (this.IsProductLineMatch(docProductductLine))
				{
					num = (short)329580561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_183:
				num = (short)1174601738;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_217:
				num = (short)491388930;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38F:
				num = (short)537067543;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_323:
			num = (short)1219821568;
			short num4 = num;
			return true;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000F0ED8 File Offset: 0x000EF0D8
		public bool IsProductLineMatch(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily docProductLine)
		{
			short num;
			for (;;)
			{
				num = (short)1718943749;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_172;
					case 1:
						goto IL_5C;
					case 2:
						if ((this.Product & docProductLine) == docProductLine)
						{
							num = (short)693698564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						if (docProductLine == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
						{
							num = (short)401604608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)199557122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return true;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					}
					IL_3D:
					if (this.Product == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
					{
						num = (short)267124737;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)2105868291;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_5C:
				num = (short)1966342145;
				if (num != 0)
				{
				}
				num = (short)1420855196;
				short num3 = num;
				num = (short)1546160028;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_B8;
				}
			}
			IL_B8:
			num = (short)1570963456;
			if (num != 0)
			{
			}
			return true;
			IL_172:
			num = (short)792133632;
			short num4 = num;
			return false;
		}

		// Token: 0x04000A95 RID: 2709
		private const char SplitStartEnd = '-';

		// Token: 0x04000A96 RID: 2710
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily _productLineFlag;

		// Token: 0x04000A97 RID: 2711
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.BLVersion _startVersion;

		// Token: 0x04000A98 RID: 2712
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.BLVersion _endVersion;
	}
}
