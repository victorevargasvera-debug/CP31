using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Motorola.CommonCPS.CommonContract;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel
{
	// Token: 0x020001C8 RID: 456
	public class MultipleFieldsXML : global::System.IEquatable<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML>
	{
		// Token: 0x06001757 RID: 5975 RVA: 0x000FC6D0 File Offset: 0x000FA8D0
		public global::System.Collections.Generic.Dictionary<string, object> ConvertToDictionary()
		{
			short num = (short)2077425665;
			if (num != 0)
			{
			}
			num = (short)812778449;
			short num2 = num;
			num = (short)769983441;
			global::System.Collections.Generic.Dictionary<string, object> dictionary;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1603928064;
				if (num != 0)
				{
				}
				dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator = this.NameAndValueList.GetEnumerator())
				{
					num = (short)1815805953;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_BC;
							}
							continue;
						case 2:
							goto IL_139;
						case 3:
							num = (short)1541668866;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1167130627;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue = enumerator.Current;
							dictionary.Add(nameAndValue.Name, nameAndValue.Value);
							num = (short)318701568;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_EE:
						num = (short)1669988356;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_BC:
						goto IL_EE;
					}
					IL_139:;
				}
				break;
			}
			num = (short)1473118208;
			short num4 = num;
			return dictionary;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000FC864 File Offset: 0x000FAA64
		public MultipleFieldsXML()
		{
			this.NameAndValueList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>();
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x000FC884 File Offset: 0x000FAA84
		// (set) Token: 0x0600175A RID: 5978 RVA: 0x000FC934 File Offset: 0x000FAB34
		[global::System.Xml.Serialization.XmlElement("Field")]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue> NameAndValueList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)541523969;
				if (num != 0)
				{
				}
				num = (short)1243283456;
				short num2 = num;
				num = (short)794732528;
				short num3 = num;
				num = (short)543336432;
				switch (num3 == num)
				{
				}
				num = (short)1831993344;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)489547473;
				short num2 = num;
				num = (short)1761994449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)635109376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584398337;
				if (num != 0)
				{
				}
				num = (short)1131675648;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000FC9E4 File Offset: 0x000FABE4
		public object GetValue(string Name)
		{
			short num = (short)1051890829;
			short num2 = num;
			num = (short)1326879885;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue> source;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)620429312;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML.a a = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML.a();
				a.a = Name;
				source = this.NameAndValueList.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue, bool>(a.b));
				if (source.Count<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>() != 1)
				{
					num = (short)1009778689;
					if (num != 0)
					{
					}
					return null;
				}
				break;
			}
			}
			num = (short)1179582464;
			short num3 = num;
			return source.First<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>().Value;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000FCACC File Offset: 0x000FACCC
		public bool TrySetValue(string FieldName, object value)
		{
			short num = (short)616090513;
			short num2 = num;
			num = (short)427019153;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1244594176;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML.b b = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML.b();
				b.a = FieldName;
				result = false;
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue> source = this.NameAndValueList.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue, bool>(b.b));
				if (source.Count<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>() == 1)
				{
					try
					{
						num = (short)434503681;
						if (num != 0)
						{
						}
						source.First<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>().Value = value;
						result = true;
					}
					catch
					{
					}
				}
				break;
			}
			}
			num = (short)1725300736;
			short num3 = num;
			return result;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x000FCBC8 File Offset: 0x000FADC8
		public string SerializeToXML(bool NeedZip = true)
		{
			short num = (short)389986236;
			short num2 = num;
			num = (short)1001109436;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1489240064;
				if (num != 0)
				{
				}
				if (!NeedZip)
				{
					num = (short)1673723905;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.CommonContract.Serializer.Serialize_ToXMLString(this);
				}
				break;
			}
			num = (short)1108803584;
			short num3 = num;
			return global::Motorola.CommonCPS.CommonContract.Serializer.Serialize_ToXMLZipString(this);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x000FCC84 File Offset: 0x000FAE84
		public static global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML DeserializeFromXML(string xmlString)
		{
			int a_ = 4;
			short num = (short)1983643649;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 2:
				{
					num = (short)928841729;
					if (num != 0)
					{
					}
					num = (short)813654727;
					short num3 = num;
					num = (short)1530094279;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E5;
					default:
						goto IL_166;
					}
					break;
				}
				case 3:
					goto IL_E0;
				case 4:
					result = (global::Motorola.CommonCPS.CommonContract.Serializer.Deserialize_FromXMLString(xmlString, typeof(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML)) as global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML);
					num = (short)312410115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (xmlString.Substring(0, 5).Equals(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㸁㬃縅攇昉", a_)))
					{
						num = (short)751632388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = (global::Motorola.CommonCPS.CommonContract.Serializer.Deserialize_FromXMLZipString(xmlString, typeof(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML)) as global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML);
					num = (short)467140608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				if (xmlString == null)
				{
					num = (short)1863581696;
					short num4 = num;
					num = (short)391053314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E5:
				num = (short)1721892869;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E0:
			return result;
			IL_166:
			num = (short)2144796672;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x000FCE40 File Offset: 0x000FB040
		public bool Equals(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML other)
		{
			short num = (short)550483530;
			short num2 = num;
			num = (short)547468874;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2096627712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)304414720;
			if (num != 0)
			{
			}
			num = (short)124977153;
			if (num != 0)
			{
			}
			return this.Equals(other, null);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000FCEF0 File Offset: 0x000FB0F0
		public bool Equals(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML other, global::System.Collections.Generic.List<string> IgnoreFields)
		{
			short num = (short)1976041472;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1009516545;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
					goto IL_2C2;
				case 2:
				{
					num = (short)1722917683;
					short num3 = num;
					num = (short)1300669235;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_29E;
					case 1:
						goto IL_E9;
					}
					goto Block_2;
				}
				}
				IL_5A:
				if (this.NameAndValueList.Count<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>() != other.NameAndValueList.Count<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>())
				{
					num = (short)1566769154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_29E:
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator = this.NameAndValueList.GetEnumerator();
				num = (short)1196032001;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			num = (short)1706098688;
			short num4 = num;
			IL_E9:
			num = (short)406388736;
			if (num != 0)
			{
			}
			return false;
			IL_2C2:
			try
			{
				num = (short)202244101;
				num2 = (int)((global::System.IntPtr)num);
				bool result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_16C;
					case 1:
						num = (short)1960968194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
						if (!IgnoreFields.Contains(nameAndValue.Name))
						{
							num = (short)1606549507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_220;
					case 4:
					{
						global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
						if (!other.GetValue(nameAndValue.Name).Equals(nameAndValue.Value))
						{
							num = (short)1915224073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_154;
						}
						continue;
					case 6:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1301807111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue = enumerator.Current;
						num = (short)1075838986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1905786888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_28A;
					case 9:
						result = false;
						num = (short)26017792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (IgnoreFields != null)
						{
							num = (short)1419706369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_220;
					}
					IL_171:
					num = (short)1809448966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_154:
					goto IL_171;
					IL_220:
					num = (short)887947268;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_16C:
				return result;
				IL_28A:
				return true;
			}
			finally
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x04000AE3 RID: 2787
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue> a;

		// Token: 0x020001C9 RID: 457
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06001762 RID: 5986 RVA: 0x000FD1F8 File Offset: 0x000FB3F8
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue A_0)
			{
				short num = (short)1479916894;
				short num2 = num;
				num = (short)1096924510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1829896192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1205338113;
				if (num != 0)
				{
				}
				num = (short)1703280640;
				if (num != 0)
				{
				}
				return A_0.Name == this.a;
			}

			// Token: 0x04000AE4 RID: 2788
			public string a;
		}

		// Token: 0x020001CA RID: 458
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06001764 RID: 5988 RVA: 0x000FD2C4 File Offset: 0x000FB4C4
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue A_0)
			{
				short num = (short)494348688;
				short num2 = num;
				num = (short)177744272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1250689024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)877723649;
				if (num != 0)
				{
				}
				num = (short)1325793280;
				if (num != 0)
				{
				}
				return A_0.Name == this.a;
			}

			// Token: 0x04000AE5 RID: 2789
			public string a;
		}
	}
}
