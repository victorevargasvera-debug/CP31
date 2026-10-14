using System;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001B1 RID: 433
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ReleaseVersionSection
	{
		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x000F12A8 File Offset: 0x000EF4A8
		public bool IsReleaseVersionSensitive
		{
			get
			{
				short num = (short)2468713;
				short num2 = num;
				num = (short)1077324649;
				switch (num2 == num)
				{
				}
				num = (short)1672544257;
				if (num != 0)
				{
				}
				num = (short)1353842688;
				short num3 = num;
				num = (short)1718222848;
				if (num != 0)
				{
				}
				return !string.IsNullOrEmpty(this._releaseVersion);
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x000F1360 File Offset: 0x000EF560
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x000F1414 File Offset: 0x000EF614
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily Product
		{
			get
			{
				short num = (short)300511104;
				short num2 = num;
				num = (short)262303616;
				switch (num2 == num)
				{
				}
				num = (short)1749876736;
				if (num != 0)
				{
				}
				num = (short)1069809664;
				short num3 = num;
				num = (short)408944641;
				if (num != 0)
				{
				}
				return this._productLineFlag;
			}
			set
			{
				short num = (short)1463952496;
				short num2 = num;
				num = (short)1181230192;
				switch (num2 == num)
				{
				}
				num = (short)876806144;
				if (num != 0)
				{
				}
				num = (short)540934144;
				short num3 = num;
				num = (short)1372061697;
				if (num != 0)
				{
				}
				this._productLineFlag = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x000F14C4 File Offset: 0x000EF6C4
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x000F1638 File Offset: 0x000EF838
		public string ReleaseVersion
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				short num2;
				string text;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						goto IL_110;
					case 1:
						goto IL_D9;
					case 2:
						if (!string.IsNullOrEmpty(this._releaseVersion))
						{
							num2 = (short)1977024515;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D9;
					case 3:
						text = this._releaseVersion;
						num2 = (short)1926561793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (text.Length != 1)
						{
							num2 = (short)405340160;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_15F;
					}
					goto IL_24;
					IL_D9:
					num2 = (short)530513924;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_15F:
				return string.Empty;
				IL_24:
				text = string.Empty;
				num2 = (short)995328609;
				short num3 = num2;
				num2 = (short)1988985441;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_110:
					num2 = (short)1354563584;
					short num4 = num2;
					return text;
				}
				default:
				{
					num2 = (short)382140416;
					if (num2 != 0)
					{
					}
					num2 = (short)118095873;
					if (num2 != 0)
					{
					}
					num2 = (short)331350018;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			set
			{
				int a_ = 3;
				short num = (short)323092481;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_124;
					case 1:
					{
						num = (short)960123734;
						short num3 = num;
						num = (short)841962326;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_124;
						default:
						{
							num = (short)1243217920;
							short num4 = num;
							num = (short)1939800064;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B5;
							}
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_144;
					case 3:
						num = (short)1244528640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B5:
					num = (short)766836737;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(value))
					{
						num = (short)1596325891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_124:
					if (!string.IsNullOrWhiteSpace(value))
					{
						goto IL_146;
					}
					num = (short)21757954;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F9:
				throw new global::System.Runtime.Serialization.InvalidDataContractException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("攀氂┄椆昈缊ⴌ愎琐瘒焔㜖漘縚漜氞䠠䰢䬤ܦ䀨䴪ബ䨮尰䌲䄴丶ᤸ䠺䤼䴾⡀ⵂ≄", a_));
				IL_144:
				goto IL_F9;
				IL_146:
				this._releaseVersion = value;
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000F1794 File Offset: 0x000EF994
		public bool IsMatch(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily docProductductLine, string docReleaseVersion)
		{
			short num = (short)1057030147;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)866713600;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return true;
				case 1:
					if (string.IsNullOrEmpty(this._releaseVersion))
					{
						num = (short)1148387332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1626800133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)36700161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 4:
					goto IL_180;
				case 5:
					num = (short)507707393;
					if (num != 0)
					{
					}
					if (string.Compare(this._releaseVersion, docReleaseVersion, global::System.StringComparison.OrdinalIgnoreCase) <= 0)
					{
						num = (short)5636096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_65:
				if (!this.IsProductLineMatch(docProductductLine))
				{
					return false;
				}
				num = (short)2074062051;
				short num4 = num;
				num = (short)243051747;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)1296367616;
					if (num != 0)
					{
					}
					num = (short)1104019458;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return true;
			IL_180:
			return true;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x000F1928 File Offset: 0x000EFB28
		public bool IsProductLineMatch(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily docProductLine)
		{
			short num = (short)1063124995;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return true;
				case 1:
					if (docProductLine == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
					{
						num = (short)1548877828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)304873477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return true;
				case 3:
				{
					num = (short)1670184961;
					if (num != 0)
					{
					}
					num = (short)1204158464;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					continue;
				}
				case 4:
					return false;
				case 5:
					if ((this.Product & docProductLine) == docProductLine)
					{
						num = (short)1299185664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_8B:
				if (this.Product == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
				{
					num = (short)838341033;
					short num4 = num;
					num = (short)2110132649;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1734672384;
						if (num != 0)
						{
						}
						num = (short)917962754;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)1907949569;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
		}

		// Token: 0x04000A9A RID: 2714
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily _productLineFlag;

		// Token: 0x04000A9B RID: 2715
		[global::System.Runtime.Serialization.DataMember]
		private string _releaseVersion;
	}
}
