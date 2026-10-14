using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Xml;
using AcpCommonResources;
using AcpUtility;

namespace AcpExceptionLib
{
	// Token: 0x02000003 RID: 3
	[global::System.Serializable]
	public class AcpException : global::System.Exception
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		protected AcpException() : this(global::AcpExceptionLib.AcpException.DefaultErrorMessage)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002134 File Offset: 0x00000334
		protected AcpException(string message) : this(message, null)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000214C File Offset: 0x0000034C
		protected AcpException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002164 File Offset: 0x00000364
		protected AcpException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::AcpExceptionLib.AcpUIValueException.b("裠跢菤裦", a_));
			}
			this.m_ErrorCode = info.GetString(global::AcpExceptionLib.AcpUIValueException.b("ꓠ釢韤裦鯨꣪苬诮铰", a_));
			this.m_ErrorDetails = info.GetString(global::AcpExceptionLib.AcpUIValueException.b("ꓠ釢韤裦鯨꿪裬鯮郰髲駴蓶", a_));
			this.m_ErrorNumber = info.GetInt32(global::AcpExceptionLib.AcpUIValueException.b("ꓠ釢韤裦鯨ꗪ飬苮鏰雲蟴", a_));
			this.Severity = (global::AcpExceptionLib.AcpException.SeverityLevel)info.GetInt32(global::AcpExceptionLib.AcpUIValueException.b("닠蛢鏤苦鯨苪駬雮", a_));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002204 File Offset: 0x00000404
		internal string ErrorCode
		{
			get
			{
				short num = (short)246323391;
				short num2 = num;
				num = (short)564566207;
				switch (num2 == num)
				{
				}
				num = (short)1332805632;
				short num3 = num;
				num = (short)1832058880;
				if (num != 0)
				{
				}
				num = (short)506396673;
				if (num != 0)
				{
				}
				return this.m_ErrorCode;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000022B4 File Offset: 0x000004B4
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002360 File Offset: 0x00000560
		internal global::AcpExceptionLib.AcpException.SeverityLevel Severity
		{
			get
			{
				short num = (short)1248657409;
				if (num != 0)
				{
				}
				num = (short)583693202;
				short num2 = num;
				num = (short)877556626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1766981632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)121176064;
				if (num != 0)
				{
				}
				return this.m_Severity;
			}
			set
			{
				short num = (short)479254198;
				short num2 = num;
				num = (short)942921398;
				switch (num2 == num)
				{
				}
				num = (short)221184000;
				short num3 = num;
				num = (short)338296833;
				if (num != 0)
				{
				}
				num = (short)1666777088;
				if (num != 0)
				{
				}
				this.m_Severity = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002410 File Offset: 0x00000610
		internal string ErrorDetails
		{
			get
			{
				short num = (short)253316883;
				short num2 = num;
				num = (short)727404307;
				switch (num2 == num)
				{
				}
				num = (short)1982398464;
				short num3 = num;
				num = (short)411762689;
				if (num != 0)
				{
				}
				num = (short)1231486976;
				if (num != 0)
				{
				}
				return this.m_ErrorDetails;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000024BC File Offset: 0x000006BC
		internal int ErrorNumber
		{
			get
			{
				short num = (short)1432551426;
				int num2 = (int)((global::System.IntPtr)num);
				int num4;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.Source != null)
						{
							num = (short)1993146373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_162;
					case 1:
						goto IL_D7;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 3:
					{
						num = (short)1329266688;
						short num3 = num;
						goto IL_DC;
					}
					case 4:
						global::AcpExceptionLib.AcpException.a();
						num = (short)122683395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						global::AcpExceptionLib.AcpException.m_ErrorNumberMapOffsets.TryGetValue(this.Source, out num4);
						num = (short)1099431937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3C:
					num = (short)1382816810;
					short num5 = num;
					num = (short)1639390250;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1285160960;
						if (num != 0)
						{
						}
						if (global::AcpExceptionLib.AcpException.m_ErrorNumberMapOffsets.Count == 0)
						{
							num = (short)1062731780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_DC:
					num4 = 0;
					num = (short)604176384;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D7:
				IL_162:
				num = (short)361103361;
				if (num != 0)
				{
				}
				return this.m_ErrorNumber + num4;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000265C File Offset: 0x0000085C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000270C File Offset: 0x0000090C
		internal static global::System.Resources.ResourceManager CustomResourceManager
		{
			get
			{
				short num = (short)1320288256;
				short num2 = num;
				num = (short)641792810;
				short num3 = num;
				num = (short)2117270314;
				switch (num3 == num)
				{
				}
				num = (short)362020864;
				if (num != 0)
				{
				}
				num = (short)1993146369;
				if (num != 0)
				{
				}
				return global::AcpExceptionLib.AcpException.m_CustomResourceManager;
			}
			set
			{
				short num = (short)755892224;
				short num2 = num;
				num = (short)189179758;
				short num3 = num;
				num = (short)119252846;
				switch (num3 == num)
				{
				}
				num = (short)1066926081;
				if (num != 0)
				{
				}
				num = (short)444858368;
				if (num != 0)
				{
				}
				global::AcpExceptionLib.AcpException.m_CustomResourceManager = value;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000027BC File Offset: 0x000009BC
		public static global::AcpExceptionLib.AcpException CreateNewException(string errorCode, string errorDetails, global::AcpExceptionLib.AcpException.SeverityLevel severity, global::System.Exception innerException)
		{
			short num = (short)637992960;
			short num2 = num;
			num = (short)425775923;
			short num3 = num;
			num = (short)226612019;
			switch (num3 == num)
			{
			}
			num = (short)615972865;
			if (num != 0)
			{
			}
			num = (short)98369536;
			if (num != 0)
			{
			}
			global::System.Reflection.Assembly callingAssembly = global::System.Reflection.Assembly.GetCallingAssembly();
			int errorNumber = global::AcpExceptionLib.AcpException.a(errorCode, callingAssembly);
			return new global::AcpExceptionLib.AcpException(global::AcpCommonResources.AcpResources.ResourceManager.GetString(errorCode), innerException)
			{
				m_ErrorCode = errorCode,
				m_ErrorDetails = errorDetails,
				Severity = severity,
				m_ErrorNumber = errorNumber
			};
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000028A4 File Offset: 0x00000AA4
		public override string ToString()
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			global::System.Text.StringBuilder stringBuilder;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					stringBuilder.Append(this.StackTrace);
					stringBuilder.AppendLine();
					num2 = (short)410386445;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_328;
				case 2:
					goto IL_1E8;
				case 3:
					stringBuilder.Append(global::AcpExceptionLib.AcpUIValueException.b("\udadf싡", a_));
					stringBuilder.Append(this.Message);
					num2 = (short)1059717122;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!string.IsNullOrEmpty(this.ErrorCode))
					{
						num2 = (short)554565641;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_328;
				case 5:
				{
					stringBuilder.Append(global::AcpExceptionLib.AcpUIValueException.b("췟쿡짣\ud8e5죧", a_));
					stringBuilder.AppendLine(base.InnerException.ToString());
					num2 = (short)1446641664;
					short num3 = num2;
					num2 = (short)1358430215;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					num2 = (short)1480376881;
					short num4 = num2;
					num2 = (short)634765873;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45A;
					default:
						num2 = (short)1062731776;
						if (num2 != 0)
						{
						}
						num2 = (short)1686831105;
						if (num2 != 0)
						{
						}
						stringBuilder.AppendFormat(global::AcpExceptionLib.AcpUIValueException.b("샟싡", a_) + global::AcpCommonResources.AcpResources.Error_Details.AcpStringFormat(new object[]
						{
							this.ErrorDetails
						}), global::System.Array.Empty<object>());
						stringBuilder.AppendLine();
						num2 = (short)1433141256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					goto IL_233;
				case 8:
					goto IL_2B6;
				case 9:
					stringBuilder.AppendFormat(global::AcpExceptionLib.AcpUIValueException.b("샟", a_) + global::AcpCommonResources.AcpResources.Error_Code.AcpStringFormat(new object[]
					{
						this.ErrorCode
					}), global::System.Array.Empty<object>());
					stringBuilder.AppendLine();
					num2 = (short)1906900993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!string.IsNullOrEmpty(this.Message))
					{
						num2 = (short)1401356291;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E8;
				case 11:
					if (!string.IsNullOrEmpty(this.StackTrace))
					{
						num2 = (short)1011417088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_45A;
				case 12:
					if (!string.IsNullOrEmpty(this.ErrorDetails))
					{
						num2 = (short)414384134;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2B6;
				case 13:
					goto IL_323;
				case 14:
					if (base.InnerException != null)
					{
						num2 = (short)914948101;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_233;
				}
				goto IL_55;
				IL_1E8:
				stringBuilder.AppendLine();
				num2 = (short)2047803396;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_233:
				num2 = (short)441384971;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2B6:
				num2 = (short)195493902;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_328:
				stringBuilder.AppendFormat(global::AcpExceptionLib.AcpUIValueException.b("샟싡", a_) + global::AcpCommonResources.AcpResources.Error_Number.AcpStringFormat(new object[]
				{
					this.ErrorNumber
				}), global::System.Array.Empty<object>());
				stringBuilder.AppendLine();
				stringBuilder.AppendFormat(global::AcpExceptionLib.AcpUIValueException.b("샟싡", a_) + global::AcpCommonResources.AcpResources.Severity.AcpStringFormat(new object[]
				{
					this.Severity.ToString()
				}), global::System.Array.Empty<object>());
				stringBuilder.AppendLine();
				num2 = (short)1173749772;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_323:
			IL_45A:
			return stringBuilder.ToString();
			IL_55:
			stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().FullName);
			num2 = (short)113508362;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002D14 File Offset: 0x00000F14
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			short num = (short)1727503591;
			short num2 = num;
			num = (short)717266151;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1182859264;
				if (num != 0)
				{
				}
				if (info != null)
				{
					num = (short)1419378688;
					short num3 = num;
					info.AddValue(global::AcpExceptionLib.AcpUIValueException.b("ꇣ铥髧藩黫귭鿯雱釳", a_), this.ErrorCode);
					info.AddValue(global::AcpExceptionLib.AcpUIValueException.b("ꇣ铥髧藩黫ꫭ闯蛱闳鿵铷觹", a_), this.ErrorDetails);
					info.AddValue(global::AcpExceptionLib.AcpUIValueException.b("럣菥黧迩黫蟭蓯诱", a_), (int)this.Severity);
					info.AddValue(global::AcpExceptionLib.AcpUIValueException.b("ꇣ铥髧藩黫ꃭ藯鿱雳鏵諷", a_), this.ErrorNumber);
					base.GetObjectData(info, context);
					return;
				}
				break;
			}
			num = (short)302579713;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::AcpExceptionLib.AcpUIValueException.b("跣裥軧藩", a_));
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002E50 File Offset: 0x00001050
		private static void a()
		{
			int a_ = 8;
			short num = (short)33439239;
			short num2 = num;
			num = (short)1265974791;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)585302016;
				if (num != 0)
				{
				}
				num = (short)272760832;
				short num3 = num;
				num = (short)1768685568;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					num = (short)52363265;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.Dictionary<string, int> errorNumberMapOffsets = global::AcpExceptionLib.AcpException.m_ErrorNumberMapOffsets;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_F4;
						}
						for (;;)
						{
							IL_DD:
							switch (num4)
							{
							case 0:
								if (global::AcpExceptionLib.AcpException.m_ErrorNumberMapOffsets.Count == 0)
								{
									num = (short)1806761985;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_49D;
							case 1:
							{
								global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(global::AcpExceptionLib.AcpUIValueException.b("꣤裦鷨蓪鿬胮鷰鋲\udbf4듶觸裺폼뻾戀猂⬄䈆笈礊戌紎弐昒研甖簘椚倜縞儠匢䰤䤦丨Ԫ唬䈮崰", a_));
								num = (short)366411779;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_4B6;
							case 3:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_1C1;
									}
									global::System.Xml.XmlReader xmlReader;
									for (;;)
									{
										IL_176:
										switch (num4)
										{
										case 0:
											goto IL_42C;
										case 1:
											if (!xmlReader.Read())
											{
												num = (short)132317194;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1498873871;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
										{
											int value;
											if (int.TryParse(xmlReader.Value, out value))
											{
												num = (short)1928331273;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_220;
										}
										case 3:
											num = (short)1392705549;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											if (xmlReader.MoveToNextAttribute())
											{
												num = (short)573046795;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_220;
										case 5:
											goto IL_220;
										case 6:
											num = (short)1031864322;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 7:
										{
											string value2 = xmlReader.Value;
											num = (short)575602692;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 8:
											num = (short)46006286;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 9:
										{
											int value;
											string value2;
											global::AcpExceptionLib.AcpException.m_ErrorNumberMapOffsets.Add(value2, value);
											num = (short)825360389;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 10:
											num = (short)92078080;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 11:
										{
											int value = 0;
											num = (short)2132279312;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 12:
											goto IL_220;
										case 13:
											if (xmlReader.MoveToFirstAttribute())
											{
												num = (short)1831469064;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_220;
										case 14:
											if (xmlReader.Name == global::AcpExceptionLib.AcpUIValueException.b("ꯤ蛦蓨軪", a_))
											{
												num = (short)591462407;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_220;
										case 15:
											if (xmlReader.Name == global::AcpExceptionLib.AcpUIValueException.b("뛤裦鳨駪軬諮", a_))
											{
												num = (short)92143619;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_220;
										case 16:
											if (xmlReader.Name == global::AcpExceptionLib.AcpUIValueException.b("ꫤ臦迨飪裬鯮", a_))
											{
												num = (short)1963917318;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_220;
										}
										goto IL_1C1;
										IL_220:
										num = (short)833290241;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_42C:
									return;
									IL_1C1:
									global::System.IO.Stream manifestResourceStream;
									xmlReader = global::System.Xml.XmlReader.Create(manifestResourceStream);
									num = (short)55967756;
									num4 = (int)((global::System.IntPtr)num);
									goto IL_176;
								}
								finally
								{
									num = (short)1012989952;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.IO.Stream manifestResourceStream;
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_464;
											}
											continue;
										case 1:
											goto IL_49A;
										case 2:
											((global::System.IDisposable)manifestResourceStream).Dispose();
											num = (short)1740374017;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_464:
										if (manifestResourceStream == null)
										{
											break;
										}
										num = (short)452263938;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_49A:;
								}
								goto IL_49D;
							}
							goto IL_F4;
							IL_49D:
							num = (short)1908211714;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_4B6:
						break;
						IL_F4:
						global::System.Threading.Monitor.Enter(errorNumberMapOffsets, ref flag);
						num = (short)1831010304;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_DD;
					}
					finally
					{
						num = (short)725155840;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_4EA;
								}
								continue;
							case 1:
								goto IL_520;
							case 2:
								global::System.Threading.Monitor.Exit(errorNumberMapOffsets);
								num = (short)1973223425;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_4EA:
							if (!flag)
							{
								break;
							}
							num = (short)133496834;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_520:;
					}
					break;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000033B4 File Offset: 0x000015B4
		private static int a(string A_0, global::System.Reflection.Assembly A_1)
		{
			int a_ = 16;
			short num = (short)945271718;
			short num2 = num;
			num = (short)470332326;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)663486465;
				if (num != 0)
				{
				}
				num = (short)1777074176;
				short num3 = num;
				num = (short)816185344;
				if (num != 0)
				{
				}
				num = (short)739180544;
				int num4 = (int)num;
				switch (num4)
				{
				default:
					result = -1;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_FE;
						}
						int num5;
						string[] manifestResourceNames;
						for (;;)
						{
							IL_CF:
							switch (num4)
							{
							case 0:
								goto IL_24A;
							case 1:
								goto IL_262;
							case 2:
							{
								string text;
								if (text.Contains(global::AcpExceptionLib.AcpUIValueException.b("곬賮臰뛲跴银鳸诺觼雾渀洂䬄爆搈椊栌紎成㴒朔爖樘琚栜洞䈠䘢嘤", a_)))
								{
									num = (short)957939721;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num5++;
								num = (short)135659528;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								string text;
								if (!int.TryParse(new global::System.Resources.ResourceManager(text.Replace(global::AcpExceptionLib.AcpUIValueException.b("쏬鷮铰胲髴苶诸飺飼賾", a_), ""), A_1).GetString(A_0), out result))
								{
									num = (short)1592131588;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_24A;
							}
							case 4:
								result = -1;
								num = (short)2025390087;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_182;
							case 6:
							{
								if (num5 >= manifestResourceNames.Length)
								{
									num = (short)1751973888;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text = manifestResourceNames[num5];
								num = (short)1407188994;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_24A;
							case 8:
								goto IL_182;
							case 9:
								num = (short)1916993539;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_FE;
							IL_182:
							num = (short)1652686854;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_24A:
							num = (short)321126401;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_262:
						break;
						IL_FE:
						manifestResourceNames = A_1.GetManifestResourceNames();
						num5 = 0;
						num = (short)1847197701;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_CF;
					}
					catch
					{
						result = -1;
					}
					break;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003648 File Offset: 0x00001848
		// Note: this type is marked as 'beforefieldinit'.
		static AcpException()
		{
			short num = (short)360579072;
			short num2 = num;
			num = (short)1616944426;
			short num3 = num;
			num = (short)1917361450;
			switch (num3 == num)
			{
			}
			num = (short)803864576;
			if (num != 0)
			{
			}
			num = (short)1163788289;
			if (num != 0)
			{
			}
			global::AcpExceptionLib.AcpException.DefaultErrorMessage = global::AcpCommonResources.AcpResources.Unknown_Error;
			global::AcpExceptionLib.AcpException.m_ErrorNumberMapOffsets = new global::System.Collections.Generic.Dictionary<string, int>();
		}

		// Token: 0x04000003 RID: 3
		private static readonly string DefaultErrorMessage;

		// Token: 0x04000004 RID: 4
		private const int DefaultErrorNumber = -1;

		// Token: 0x04000005 RID: 5
		private string m_ErrorCode;

		// Token: 0x04000006 RID: 6
		private global::AcpExceptionLib.AcpException.SeverityLevel m_Severity;

		// Token: 0x04000007 RID: 7
		private string m_ErrorDetails;

		// Token: 0x04000008 RID: 8
		private int m_ErrorNumber;

		// Token: 0x04000009 RID: 9
		private static readonly global::System.Collections.Generic.Dictionary<string, int> m_ErrorNumberMapOffsets;

		// Token: 0x0400000A RID: 10
		private static global::System.Resources.ResourceManager m_CustomResourceManager;

		// Token: 0x02000004 RID: 4
		public enum SeverityLevel
		{
			// Token: 0x0400000C RID: 12
			Error,
			// Token: 0x0400000D RID: 13
			Info,
			// Token: 0x0400000E RID: 14
			Warning
		}
	}
}
