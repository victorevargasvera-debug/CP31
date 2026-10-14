using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;
using Motorola.CommonCPS.Server.EntityModel.DefineAttributes;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000022 RID: 34
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public abstract class IEntity : global::Motorola.CommonCPS.Server.EntityModel.CloneableObj
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000D428 File Offset: 0x0000B628
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.DefineAttributes.a]
		public global::System.Guid Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1587850695;
				short num2 = num;
				num = (short)1139256775;
				switch (num2 == num)
				{
				}
				num = (short)1973092353;
				if (num != 0)
				{
				}
				num = (short)776077312;
				short num3 = num;
				num = (short)391839744;
				if (num != 0)
				{
				}
				return this.<Uuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1629899701;
				short num2 = num;
				num = (short)1319062453;
				switch (num2 == num)
				{
				}
				num = (short)416612353;
				if (num != 0)
				{
				}
				num = (short)1247019008;
				short num3 = num;
				num = (short)1359216640;
				if (num != 0)
				{
				}
				this.<Uuid>k__BackingField = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000D58C File Offset: 0x0000B78C
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000D638 File Offset: 0x0000B838
		[global::Motorola.CommonCPS.Server.EntityModel.DefineAttributes.a]
		[global::System.Runtime.Serialization.DataMember]
		public byte[] Timestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)521011201;
				if (num != 0)
				{
				}
				num = (short)1515828867;
				short num2 = num;
				num = (short)994883203;
				switch (num2 == num)
				{
				}
				num = (short)1458110464;
				short num3 = num;
				num = (short)1224212480;
				if (num != 0)
				{
				}
				return this.<Timestamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1280159184;
				short num2 = num;
				num = (short)1544400336;
				switch (num2 == num)
				{
				}
				num = (short)487129089;
				if (num != 0)
				{
				}
				num = (short)1399455744;
				short num3 = num;
				num = (short)296353792;
				if (num != 0)
				{
				}
				this.<Timestamp>k__BackingField = value;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
		public bool IsUuidNullorEmpty()
		{
			short num = (short)1742100676;
			short num2 = num;
			num = (short)1318279364;
			switch (num2 == num)
			{
			}
			num = (short)1289814017;
			if (num != 0)
			{
			}
			num = (short)1233256448;
			short num3 = num;
			num = (short)589430784;
			if (num != 0)
			{
			}
			return this.Uuid.IsNullOrEmpty();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000D79C File Offset: 0x0000B99C
		public global::Motorola.CommonCPS.Server.EntityModel.IEntity SafeClone(bool isNewUuid = true)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.IEntity entity;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (entity != null)
					{
						num2 = (short)1851981826;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return entity;
				case 1:
				{
					if (!isNewUuid)
					{
						return entity;
					}
					num2 = (short)497843802;
					short num3 = num2;
					num2 = (short)640253530;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DD;
					default:
						num2 = (short)158531584;
						if (num2 != 0)
						{
						}
						num2 = (short)439353348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					entity.Uuid = global::Motorola.CommonCPS.Server.EntityModel.UuidOP.NewSqeuentialGuid();
					num2 = (short)824311811;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_DD;
				case 4:
					num2 = (short)860356608;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_DD:
			num2 = (short)1261764608;
			short num4 = num2;
			num2 = (short)811859969;
			if (num2 != 0)
			{
			}
			return entity;
			IL_24:
			entity = (global::System.Activator.CreateInstance(this.GetEntityType()) as global::Motorola.CommonCPS.Server.EntityModel.IEntity);
			global::Motorola.CommonCPS.Server.EntityModel.IEntity.a(this, entity);
			num2 = (short)923009025;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000D910 File Offset: 0x0000BB10
		public void SetEntityValues(global::Motorola.CommonCPS.Server.EntityModel.IEntity fromObject)
		{
			short num;
			try
			{
				num = (short)2074542080;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					int num3;
					global::System.Reflection.PropertyInfo[] properties;
					global::System.Guid uuid;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
						{
							if (num3 >= properties.Length)
							{
								num = (short)1752104961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Reflection.PropertyInfo propertyInfo = properties[num3];
							num = (short)1352663044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_3E1;
						case 2:
							goto IL_B4;
						case 3:
							goto IL_401;
						case 4:
							try
							{
								num = (short)36896774;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Reflection.PropertyInfo propertyInfo;
									switch (num2)
									{
									case 0:
									{
										global::System.Reflection.PropertyInfo property = this.GetType().GetProperty(propertyInfo.Name);
										num = (short)1221394442;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										if (propertyInfo.PropertyType.GenericTypeArguments[0].IsSubclassOf(typeof(global::Motorola.CommonCPS.Server.EntityModel.IEntity)))
										{
											num = (short)1083375619;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2B8;
									case 2:
										goto IL_22D;
									case 3:
									{
										num = (short)437543591;
										short num4 = num;
										num = (short)1170432679;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1E0;
										default:
											num = (short)1081999360;
											if (num != 0)
											{
											}
											num = (short)391315458;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										global::System.Reflection.PropertyInfo property;
										if (property.CanWrite)
										{
											num = (short)883556357;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3BD;
									}
									case 5:
									{
										global::System.Reflection.PropertyInfo property;
										property.SetValue(this, propertyInfo.GetValue(fromObject, null), null);
										num = (short)731316233;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_159;
										}
										continue;
									case 7:
										if (propertyInfo.CanRead)
										{
											num = (short)1575682048;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3BD;
									case 8:
										goto IL_313;
									case 9:
										goto IL_3BD;
									case 10:
									{
										global::System.Reflection.PropertyInfo property;
										if (property != null)
										{
											num = (short)2049376271;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3BD;
									}
									case 11:
										goto IL_3D6;
									case 12:
										num = (short)1212612616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
										if (propertyInfo.PropertyType.IsGenericType)
										{
											num = (short)1758461966;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2B8;
									case 14:
										num = (short)472449025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 15:
										goto IL_1E0;
									}
									IL_159:
									if (propertyInfo.PropertyType.IsSubclassOf(typeof(global::Motorola.CommonCPS.Server.EntityModel.IEntity)))
									{
										num = (short)1652817932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)110952461;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1E0:
									num = (short)265158660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2B8:
									num = (short)1210122247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_3BD:
									num = (short)669843467;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_22D:
								IL_313:
								IL_3D6:
								goto IL_7A;
							}
							catch
							{
								goto IL_7A;
							}
							goto IL_3E1;
							IL_7A:
							num3++;
							num = (short)1609695237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_B4;
						}
						goto IL_47;
						IL_B4:
						num = (short)1286864896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3E1:
						this.Uuid = uuid;
						num = (short)1861156867;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_401:
					break;
					IL_47:
					uuid = this.Uuid;
					properties = fromObject.GetType().GetProperties();
					num3 = 0;
					num = (short)1807876098;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			catch
			{
			}
			num = (short)582025217;
			if (num != 0)
			{
			}
			num = (short)1351548928;
			short num5 = num;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000DDAC File Offset: 0x0000BFAC
		public global::System.Type GetEntityType()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::System.Type type;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)286053505;
					short num3 = num2;
					num2 = (short)1541461121;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A7;
					default:
						goto IL_F3;
					}
					break;
				}
				case 1:
					type = type.BaseType;
					goto IL_A7;
				case 2:
					if (type.FullName.Contains(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("娈爊縌笎琐縒㬔化砘漚簜ㄞ搠䴢儤並崨刪̬欮䠰崲吴娶倸堺洼䴾⹀㭂ⱄ≆㩈", a_)))
					{
						num2 = (short)679215104;
						short num4 = num2;
						num2 = (short)428867585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return type;
				}
				goto IL_25;
				IL_A7:
				num2 = (short)591855616;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F3:
			num2 = (short)1450835969;
			if (num2 != 0)
			{
			}
			num2 = (short)53084160;
			if (num2 != 0)
			{
			}
			return type;
			IL_25:
			type = base.GetType();
			num2 = (short)721682434;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		public static bool AreIdentical<T>(global::System.Collections.Generic.List<T> list1, global::System.Collections.Generic.List<T> list2, global::System.Func<global::System.Collections.Generic.List<T>, global::System.Collections.Generic.List<T>> sortFunc) where T : global::Motorola.CommonCPS.Server.EntityModel.IEntity
		{
			short num = (short)1554972672;
			switch (num)
			{
			default:
			{
				num = (short)299630603;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					int? num4;
					int? num6;
					int? num7;
					int? num8;
					switch (num2)
					{
					case 0:
						IL_3B4:
						if (list2.Count == 0)
						{
							num = (short)1101070346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CC;
					case 1:
						num = (short)444203024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (list2 != null)
						{
							num = (short)239009805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
					{
						global::System.Collections.Generic.List<T> list3;
						if (num3 >= list3.Count)
						{
							num = (short)861274116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						T t = list3[num3];
						global::System.Collections.Generic.List<T> list4;
						T t2 = list4[num3];
						num = (short)257490962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_2A3;
					case 5:
					{
						int? num5;
						num4 = num5;
						goto IL_401;
					}
					case 6:
						if (list1.Count == 0)
						{
							num = (short)1173487623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CC;
					case 7:
						goto IL_185;
					case 8:
						if (list1 == null)
						{
							num = (short)1676345368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)806617097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num4 = new int?(list1.Count);
						goto IL_401;
					case 10:
						goto IL_3D8;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 12:
						if (num6.GetValueOrDefault() == num7.GetValueOrDefault() & num6 != null == (num7 != null))
						{
							num = (short)233373717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						num = (short)1035075584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (list2 == null)
						{
							num = (short)890503188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1685127185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return false;
					case 16:
					{
						T t;
						T t2;
						if (!t.IsIdentical<T>(t2))
						{
							num = (short)1738604559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_164;
					}
					case 17:
						num8 = new int?(list2.Count);
						goto IL_48F;
					case 18:
					{
						T t;
						T t2;
						if (t.Uuid != t2.Uuid)
						{
							num = (short)1785069569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_164;
					}
					case 19:
						goto IL_1EF;
					case 20:
					{
						int? num5 = null;
						num = (short)362020887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.Collections.Generic.List<T> list3 = sortFunc(list1);
						global::System.Collections.Generic.List<T> list4 = sortFunc(list2);
						num3 = 0;
						num = (short)516554771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						num = (short)282460166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						int? num5;
						num8 = num5;
						goto IL_48F;
					}
					case 24:
					{
						int? num5 = null;
						num = (short)436928517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_1EF;
					}
					IL_AB:
					if (list1 != null)
					{
						num = (short)338100246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_185;
					IL_164:
					num3++;
					num = (short)863043609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_185:
					num = (short)998047746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EF:
					num = (short)237238128;
					short num9 = num;
					num = (short)1675949936;
					switch ((num9 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B4;
					default:
					{
						num = (short)1204486144;
						if (num != 0)
						{
						}
						num = (short)820641792;
						short num10 = num;
						num = (short)1198587907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_2CC:
					num = (short)2142765064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_401:
					num6 = num4;
					num = (short)2002386958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48F:
					num7 = num8;
					num = (short)1668415500;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_2A3:
				num = (short)34799617;
				if (num != 0)
				{
				}
				return true;
				IL_3D8:
				return true;
			}
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000E3E4 File Offset: 0x0000C5E4
		public bool IsIdentical<T>(object objToCompare) where T : global::Motorola.CommonCPS.Server.EntityModel.IEntity
		{
			short num = (short)1370030080;
			switch (num)
			{
			default:
			{
				num = (short)2066219009;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!(this is T))
						{
							num = (short)91357186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1958871043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1658650625;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 2:
						return false;
					case 3:
						goto IL_BA;
					case 4:
						num = (short)850591744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_80:
					if (!(objToCompare is T))
					{
						return false;
					}
					num = (short)345571332;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BA:
				num = (short)886112256;
				short num3 = num;
				goto IL_124;
				bool result;
				try
				{
					for (;;)
					{
						IL_124:
						switch (0)
						{
						case 0:
							goto IL_1AD;
						}
						int num4;
						global::System.Reflection.PropertyInfo[] properties;
						for (;;)
						{
							IL_12E:
							switch (num2)
							{
							case 0:
								num = (short)583991300;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::System.Array array;
								if (array != null)
								{
									num = (short)1013514242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3D2;
							}
							case 2:
								num = (short)278331419;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (num4 >= properties.Length)
								{
									num = (short)210829325;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Reflection.PropertyInfo propertyInfo = properties[num4];
								num = (short)1178796042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								object value;
								object value2;
								if (!value.Equals(value2))
								{
									num = (short)1500905480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1DC;
							}
							case 5:
							{
								global::System.Array array;
								global::System.Collections.Generic.IEnumerable<object> first = array.Cast<object>();
								global::System.Array array2;
								global::System.Collections.Generic.IEnumerable<object> second = array2.Cast<object>();
								if (!first.SequenceEqual(second))
								{
									num = (short)1934032917;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1DC;
							}
							case 6:
							{
								global::System.Reflection.PropertyInfo propertyInfo;
								object value = base.GetType().GetProperty(propertyInfo.Name).GetValue(this);
								object value2 = objToCompare.GetType().GetProperty(propertyInfo.Name).GetValue(objToCompare);
								global::System.Array array = value as global::System.Array;
								global::System.Array array2 = value2 as global::System.Array;
								num = (short)225705985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								object value;
								if (!(value is global::System.Collections.ICollection))
								{
									num = (short)1574043664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1DC;
							}
							case 8:
								result = false;
								num = (short)928055325;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
							{
								object value;
								if (!(value is global::Motorola.CommonCPS.Server.EntityModel.IEntity))
								{
									num = (short)1852243985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1DC;
							}
							case 10:
							{
								global::System.Reflection.PropertyInfo propertyInfo;
								if (propertyInfo.GetCustomAttribute<global::Motorola.CommonCPS.Server.EntityModel.DefineAttributes.a>() == null)
								{
									num = (short)417529862;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1DC;
							}
							case 11:
							{
								object value;
								if (value != null)
								{
									num = (short)910032896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1DC;
							}
							case 12:
								num = (short)1116864521;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								result = true;
								num = (short)1364721689;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								num = (short)153878546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
								goto IL_2B1;
							case 16:
								num = (short)555024407;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								num = (short)205586458;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
							{
								num = (short)2073153753;
								short num5 = num;
								num = (short)2015416537;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_124;
								default:
								{
									num = (short)1974796288;
									if (num != 0)
									{
									}
									object value;
									object value2;
									if (value == null ^ value2 == null)
									{
										num = (short)2108882968;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1830289419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 19:
								num = (short)743440389;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 20:
								goto IL_2B1;
							case 21:
								result = false;
								num = (short)526385180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 22:
								goto IL_57B;
							case 23:
							{
								object value2;
								if (!(value2 is global::System.Collections.ICollection))
								{
									num = (short)954466316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1DC;
							}
							case 24:
								result = false;
								num = (short)227344406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 25:
								goto IL_61B;
							case 26:
							{
								object value2;
								if (!(value2 is global::Motorola.CommonCPS.Server.EntityModel.IEntity))
								{
									num = (short)1914109966;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1DC;
							}
							case 27:
							{
								global::System.Array array2;
								if (array2 != null)
								{
									num = (short)196870163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3D2;
							}
							case 28:
								goto IL_3CD;
							case 29:
								goto IL_2AC;
							}
							break;
							IL_1DC:
							num4++;
							num = (short)1520369684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2B1:
							num = (short)1485176835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3D2:
							num = (short)1059913735;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1AD:
						properties = typeof(T).GetProperties();
						num4 = 0;
						num = (short)528941071;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_12E;
					}
					IL_2AC:
					IL_3CD:
					IL_57B:
					IL_61B:;
				}
				catch (global::System.NullReferenceException)
				{
					return false;
				}
				return result;
			}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000EA34 File Offset: 0x0000CC34
		private static void a(object A_0, object A_1)
		{
			short num;
			try
			{
				num = (short)662962176;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					int num4;
					global::System.Reflection.PropertyInfo[] properties;
					for (;;)
					{
						IL_29:
						switch (num2)
						{
						case 0:
							goto IL_D1;
						case 1:
							try
							{
								num = (short)1415446535;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Reflection.PropertyInfo propertyInfo;
									switch (num2)
									{
									case 0:
										goto IL_280;
									case 1:
									{
										global::System.Reflection.PropertyInfo property;
										if (property.CanWrite)
										{
											goto IL_212;
										}
										goto IL_280;
									}
									case 2:
									{
										global::System.Reflection.PropertyInfo property;
										property.SetValue(A_1, propertyInfo.GetValue(A_0, null), null);
										num = (short)1492254720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_298;
									case 4:
									{
										global::System.Reflection.PropertyInfo property = A_1.GetType().GetProperty(propertyInfo.Name);
										num = (short)1331560453;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::System.Reflection.PropertyInfo property;
										if (property != null)
										{
											num = (short)2011693062;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_280;
									}
									case 6:
									{
										num = (short)498629535;
										short num3 = num;
										num = (short)2129361823;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_212;
										default:
											num = (short)1619001344;
											if (num != 0)
											{
											}
											num = (short)254279681;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
										switch (0)
										{
										case 0:
											goto IL_154;
										}
										continue;
									}
									IL_154:
									if (propertyInfo.CanRead)
									{
										num = (short)653918212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_280;
									IL_212:
									num = (short)515833858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_280:
									num = (short)2108882947;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_298:
								goto IL_6D;
							}
							catch
							{
								goto IL_6D;
							}
							goto IL_2A3;
							IL_6D:
							num = (short)1508507649;
							if (num != 0)
							{
							}
							num4++;
							num = (short)1715273728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2BB;
						case 3:
						{
							if (num4 >= properties.Length)
							{
								num = (short)1113128964;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Reflection.PropertyInfo propertyInfo = properties[num4];
							num = (short)574816257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_2A3;
						case 5:
							goto IL_D1;
						}
						goto IL_48;
						IL_D1:
						num = (short)1047068675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A3:
						num = (short)32702466;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2BB:
					break;
					IL_48:
					properties = A_0.GetType().GetProperties();
					num4 = 0;
					num = (short)1734148101;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
			}
			catch
			{
			}
			num = (short)1372848128;
			short num5 = num;
		}
	}
}
