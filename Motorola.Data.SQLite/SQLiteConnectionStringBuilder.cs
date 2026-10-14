using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SQLite;
using System.Runtime.CompilerServices;

namespace Motorola.Data.SQLite
{
	// Token: 0x02000018 RID: 24
	public class SQLiteConnectionStringBuilder : global::System.Collections.IDictionary, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.ComponentModel.ICustomTypeDescriptor
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00006690 File Offset: 0x00004890
		public static implicit operator global::System.Data.SQLite.SQLiteConnectionStringBuilder(global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder parameter)
		{
			short num = (short)426835969;
			if (num != 0)
			{
			}
			num = (short)1840571367;
			short num2 = num;
			num = (short)2128929767;
			global::System.Data.SQLite.SQLiteConnectionStringBuilder result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1746534400;
				if (num != 0)
				{
				}
				result = parameter.a;
				break;
			}
			num = (short)154271744;
			short num3 = num;
			return result;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00006748 File Offset: 0x00004948
		public static implicit operator global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder(global::System.Data.SQLite.SQLiteConnectionStringBuilder parameter)
		{
			short num = (short)902308843;
			short num2 = num;
			num = (short)503849963;
			global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1744502784;
				if (num != 0)
				{
				}
				result = new global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder
				{
					a = parameter
				};
				break;
			}
			num = (short)1462894593;
			if (num != 0)
			{
			}
			num = (short)1356791808;
			short num3 = num;
			return result;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006808 File Offset: 0x00004A08
		static SQLiteConnectionStringBuilder()
		{
			short num = (short)1268711425;
			if (num != 0)
			{
			}
			num = (short)334476876;
			short num2 = num;
			num = (short)420656716;
			switch (num2 == num)
			{
			}
			num = (short)575275008;
			short num3 = num;
			num = (short)411238400;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.c();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000068B8 File Offset: 0x00004AB8
		public SQLiteConnectionStringBuilder()
		{
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteConnectionStringBuilder>(new global::System.Func<global::System.Data.SQLite.SQLiteConnectionStringBuilder>(this.c));
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000068E0 File Offset: 0x00004AE0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000699C File Offset: 0x00004B9C
		public string DataSource
		{
			get
			{
				short num = (short)1020978477;
				short num2 = num;
				num = (short)793961773;
				switch (num2 == num)
				{
				}
				num = (short)1349844993;
				if (num != 0)
				{
				}
				num = (short)1341849600;
				short num3 = num;
				num = (short)881197056;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<string>(new global::System.Func<string>(this.b));
			}
			set
			{
				short num = (short)1450689244;
				short num2 = num;
				num = (short)106218204;
				switch (num2 == num)
				{
				}
				num = (short)1164574721;
				if (num != 0)
				{
				}
				num = (short)1484455936;
				short num3 = num;
				num = (short)1487536128;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder.a a = new global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder.a();
				a.a = this;
				a.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<string>(new global::System.Func<string>(a.c));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00006A70 File Offset: 0x00004C70
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00006B30 File Offset: 0x00004D30
		public string ConnectionString
		{
			get
			{
				short num = (short)104083604;
				short num2 = num;
				num = (short)676475028;
				switch (num2 == num)
				{
				}
				num = (short)928972801;
				if (num != 0)
				{
				}
				num = (short)1171783680;
				short num3 = num;
				num = (short)896401408;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<string>(new global::System.Func<string>(this.a));
			}
			set
			{
				short num = (short)1904338532;
				short num2 = num;
				num = (short)1338435172;
				switch (num2 == num)
				{
				}
				num = (short)403832832;
				if (num != 0)
				{
				}
				num = (short)878641152;
				short num3 = num;
				num = (short)1098055681;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder.b b = new global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder.b();
				b.a = this;
				b.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<string>(new global::System.Func<string>(b.c));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00006C04 File Offset: 0x00004E04
		public global::System.Collections.ICollection Keys
		{
			get
			{
				short num = (short)799402158;
				short num2 = num;
				num = (short)1004071086;
				switch (num2 == num)
				{
				}
				num = (short)764477441;
				if (num != 0)
				{
				}
				num = (short)1703477248;
				short num3 = num;
				num = (short)286720000;
				if (num != 0)
				{
				}
				return this.a.Keys;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public global::System.Collections.ICollection Values
		{
			get
			{
				short num = (short)388473670;
				short num2 = num;
				num = (short)1148035910;
				switch (num2 == num)
				{
				}
				num = (short)391970816;
				if (num != 0)
				{
				}
				num = (short)325976064;
				short num3 = num;
				num = (short)1355743233;
				if (num != 0)
				{
				}
				return this.a.Values;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00006D68 File Offset: 0x00004F68
		public bool IsReadOnly
		{
			get
			{
				short num = (short)1224610941;
				short num2 = num;
				num = (short)1978995837;
				switch (num2 == num)
				{
				}
				num = (short)1630535680;
				if (num != 0)
				{
				}
				num = (short)123600896;
				short num3 = num;
				num = (short)993525761;
				if (num != 0)
				{
				}
				return this.a.IsReadOnly;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00006E1C File Offset: 0x0000501C
		public bool IsFixedSize
		{
			get
			{
				short num = (short)366882810;
				short num2 = num;
				num = (short)775827450;
				switch (num2 == num)
				{
				}
				num = (short)1323106305;
				if (num != 0)
				{
				}
				num = (short)1684275200;
				short num3 = num;
				num = (short)1040908288;
				if (num != 0)
				{
				}
				return this.a.IsFixedSize;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00006ED0 File Offset: 0x000050D0
		public int Count
		{
			get
			{
				short num = (short)1297350657;
				if (num != 0)
				{
				}
				num = (short)1717111439;
				short num2 = num;
				num = (short)118164111;
				switch (num2 == num)
				{
				}
				num = (short)472973312;
				short num3 = num;
				num = (short)1992163328;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006F84 File Offset: 0x00005184
		public object SyncRoot
		{
			get
			{
				short num = (short)90389642;
				short num2 = num;
				num = (short)1865038986;
				switch (num2 == num)
				{
				}
				num = (short)1303707649;
				if (num != 0)
				{
				}
				num = (short)1154482176;
				short num3 = num;
				num = (short)925761536;
				if (num != 0)
				{
				}
				return this.a.SyncRoot;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000703C File Offset: 0x0000523C
		public bool IsSynchronized
		{
			get
			{
				short num = (short)2100657154;
				short num2 = num;
				num = (short)348224514;
				switch (num2 == num)
				{
				}
				num = (short)496893952;
				if (num != 0)
				{
				}
				num = (short)1642332160;
				short num3 = num;
				num = (short)142868481;
				if (num != 0)
				{
				}
				return this.a.IsSynchronized;
			}
		}

		// Token: 0x17000019 RID: 25
		public object this[object key]
		{
			get
			{
				short num = (short)1059806120;
				short num2 = num;
				num = (short)166550440;
				switch (num2 == num)
				{
				}
				num = (short)946601985;
				if (num != 0)
				{
				}
				num = (short)1758330880;
				short num3 = num;
				num = (short)1724186624;
				if (num != 0)
				{
				}
				return this.a[key];
			}
			set
			{
				short num = (short)1230298812;
				short num2 = num;
				num = (short)1030086332;
				switch (num2 == num)
				{
				}
				num = (short)794296320;
				if (num != 0)
				{
				}
				num = (short)456130560;
				short num3 = num;
				num = (short)1845952513;
				if (num != 0)
				{
				}
				this.a[key] = value;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000725C File Offset: 0x0000545C
		public override string ToString()
		{
			short num;
			string result;
			for (;;)
			{
				num = (short)1491664897;
				if (num != 0)
				{
				}
				result = this.a.ToString();
				num = (short)354309073;
				short num2 = num;
				num = (short)1312314321;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6B;
				}
			}
			IL_6B:
			num = (short)1181024256;
			short num3 = num;
			num = (short)722862080;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007314 File Offset: 0x00005514
		public bool Contains(object key)
		{
			bool result;
			short num;
			for (;;)
			{
				result = this.a.Contains(key);
				num = (short)1396521188;
				short num2 = num;
				num = (short)429275364;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_45;
				}
			}
			IL_45:
			num = (short)41222144;
			if (num != 0)
			{
			}
			num = (short)1896415232;
			short num3 = num;
			num = (short)260636673;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000073D0 File Offset: 0x000055D0
		public void Add(object key, object value)
		{
			short num = (short)1929062813;
			short num2 = num;
			num = (short)1718102429;
			switch (num2 == num)
			{
			}
			num = (short)383057921;
			if (num != 0)
			{
			}
			num = (short)1257701376;
			short num3 = num;
			num = (short)699596800;
			if (num != 0)
			{
			}
			this.a.Add(key, value);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007488 File Offset: 0x00005688
		public void Clear()
		{
			short num = (short)1179582465;
			if (num != 0)
			{
			}
			num = (short)1815191314;
			short num2 = num;
			num = (short)1351065362;
			switch (num2 == num)
			{
			}
			num = (short)1356398592;
			short num3 = num;
			num = (short)2046623744;
			if (num != 0)
			{
			}
			this.a.Clear();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000753C File Offset: 0x0000573C
		public global::System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			global::System.Collections.IDictionaryEnumerator enumerator;
			short num;
			for (;;)
			{
				enumerator = this.a.GetEnumerator();
				num = (short)986236132;
				short num2 = num;
				num = (short)1076085988;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_43;
				}
			}
			IL_43:
			num = (short)517013505;
			if (num != 0)
			{
			}
			num = (short)538181632;
			short num3 = num;
			num = (short)1277624320;
			if (num != 0)
			{
			}
			return enumerator;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000075F4 File Offset: 0x000057F4
		public void Remove(object key)
		{
			short num = (short)1523652953;
			short num2 = num;
			num = (short)706943321;
			switch (num2 == num)
			{
			}
			num = (short)212074496;
			if (num != 0)
			{
			}
			num = (short)2114519040;
			short num3 = num;
			num = (short)627048449;
			if (num != 0)
			{
			}
			this.a.Remove(key);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000076AC File Offset: 0x000058AC
		public void CopyTo(global::System.Array array, int index)
		{
			short num = (short)1804903889;
			short num2 = num;
			num = (short)319333841;
			switch (num2 == num)
			{
			}
			num = (short)1949761537;
			if (num != 0)
			{
			}
			num = (short)1487601664;
			short num3 = num;
			num = (short)1681588224;
			if (num != 0)
			{
			}
			this.a.CopyTo(array, index);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00007760 File Offset: 0x00005960
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num;
			global::System.Collections.IEnumerator enumerator;
			for (;;)
			{
				num = (short)1152385025;
				if (num != 0)
				{
				}
				enumerator = this.a.GetEnumerator();
				num = (short)1127650503;
				short num2 = num;
				num = (short)12031175;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6B;
				}
			}
			IL_6B:
			num = (short)1535115264;
			short num3 = num;
			num = (short)2108948480;
			if (num != 0)
			{
			}
			return enumerator;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00007818 File Offset: 0x00005A18
		public global::System.ComponentModel.AttributeCollection GetAttributes()
		{
			global::System.ComponentModel.AttributeCollection attributes;
			short num;
			for (;;)
			{
				attributes = this.a.GetAttributes();
				num = (short)1449309231;
				short num2 = num;
				num = (short)1151185967;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_44;
				}
			}
			IL_44:
			num = (short)1284177920;
			if (num != 0)
			{
			}
			num = (short)159383552;
			short num3 = num;
			num = (short)538509313;
			if (num != 0)
			{
			}
			return attributes;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000078D4 File Offset: 0x00005AD4
		public string GetClassName()
		{
			string className;
			short num;
			for (;;)
			{
				className = this.a.GetClassName();
				num = (short)1103993330;
				short num2 = num;
				num = (short)976787954;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_45;
				}
			}
			IL_45:
			num = (short)331350017;
			if (num != 0)
			{
			}
			num = (short)327024640;
			short num3 = num;
			num = (short)561774592;
			if (num != 0)
			{
			}
			return className;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000798C File Offset: 0x00005B8C
		public string GetComponentName()
		{
			string componentName;
			short num;
			for (;;)
			{
				componentName = this.a.GetComponentName();
				num = (short)1553233959;
				short num2 = num;
				num = (short)9467943;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_43;
				}
			}
			IL_43:
			num = (short)946995201;
			if (num != 0)
			{
			}
			num = (short)942080000;
			short num3 = num;
			num = (short)2145845248;
			if (num != 0)
			{
			}
			return componentName;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00007A44 File Offset: 0x00005C44
		public global::System.ComponentModel.TypeConverter GetConverter()
		{
			global::System.ComponentModel.TypeConverter converter;
			short num;
			for (;;)
			{
				converter = this.a.GetConverter();
				num = (short)546079938;
				short num2 = num;
				num = (short)269386946;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_44;
				}
			}
			IL_44:
			num = (short)1731526657;
			if (num != 0)
			{
			}
			num = (short)1088946176;
			short num3 = num;
			num = (short)418512896;
			if (num != 0)
			{
			}
			return converter;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00007B00 File Offset: 0x00005D00
		public global::System.ComponentModel.EventDescriptor GetDefaultEvent()
		{
			global::System.ComponentModel.EventDescriptor defaultEvent;
			short num;
			for (;;)
			{
				defaultEvent = this.a.GetDefaultEvent();
				num = (short)171442177;
				if (num != 0)
				{
				}
				num = (short)2142568023;
				short num2 = num;
				num = (short)415170135;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6E;
				}
			}
			IL_6E:
			num = (short)1472004096;
			short num3 = num;
			num = (short)2117730304;
			if (num != 0)
			{
			}
			return defaultEvent;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00007BBC File Offset: 0x00005DBC
		public global::System.ComponentModel.PropertyDescriptor GetDefaultProperty()
		{
			global::System.ComponentModel.PropertyDescriptor defaultProperty;
			short num;
			for (;;)
			{
				defaultProperty = this.a.GetDefaultProperty();
				num = (short)649515419;
				short num2 = num;
				num = (short)541184411;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_44;
				}
			}
			IL_44:
			num = (short)597032961;
			if (num != 0)
			{
			}
			num = (short)652673024;
			short num3 = num;
			num = (short)1662713856;
			if (num != 0)
			{
			}
			return defaultProperty;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00007C78 File Offset: 0x00005E78
		public object GetEditor(global::System.Type editorBaseType)
		{
			object editor;
			short num;
			for (;;)
			{
				editor = this.a.GetEditor(editorBaseType);
				num = (short)109857160;
				short num2 = num;
				num = (short)46287240;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_46;
				}
			}
			IL_46:
			num = (short)2111569921;
			if (num != 0)
			{
			}
			num = (short)1287258112;
			short num3 = num;
			num = (short)2036465664;
			if (num != 0)
			{
			}
			return editor;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00007D30 File Offset: 0x00005F30
		public global::System.ComponentModel.EventDescriptorCollection GetEvents()
		{
			global::System.ComponentModel.EventDescriptorCollection events;
			short num;
			for (;;)
			{
				events = this.a.GetEvents();
				num = (short)119635381;
				short num2 = num;
				num = (short)297106869;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_44;
				}
			}
			IL_44:
			num = (short)1183055873;
			if (num != 0)
			{
			}
			num = (short)160169984;
			short num3 = num;
			num = (short)964100096;
			if (num != 0)
			{
			}
			return events;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00007DEC File Offset: 0x00005FEC
		public global::System.ComponentModel.EventDescriptorCollection GetEvents(global::System.Attribute[] attributes)
		{
			global::System.ComponentModel.EventDescriptorCollection events;
			short num;
			for (;;)
			{
				events = this.a.GetEvents(attributes);
				num = (short)789372745;
				short num2 = num;
				num = (short)291561289;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_44;
				}
			}
			IL_44:
			num = (short)755564545;
			if (num != 0)
			{
			}
			num = (short)794230784;
			short num3 = num;
			num = (short)1181876224;
			if (num != 0)
			{
			}
			return events;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00007EA8 File Offset: 0x000060A8
		public global::System.ComponentModel.PropertyDescriptorCollection GetProperties()
		{
			global::System.ComponentModel.PropertyDescriptorCollection properties;
			short num;
			for (;;)
			{
				properties = this.a.GetProperties();
				num = (short)2058866259;
				short num2 = num;
				num = (short)465817171;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_46;
				}
			}
			IL_46:
			num = (short)1073545216;
			if (num != 0)
			{
			}
			num = (short)912916480;
			short num3 = num;
			num = (short)1012400129;
			if (num != 0)
			{
			}
			return properties;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00007F64 File Offset: 0x00006164
		public global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.Attribute[] attributes)
		{
			global::System.ComponentModel.PropertyDescriptorCollection properties;
			short num;
			for (;;)
			{
				properties = this.a.GetProperties(attributes);
				num = (short)1406546025;
				short num2 = num;
				num = (short)406007913;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_47;
				}
			}
			IL_47:
			num = (short)2075394049;
			if (num != 0)
			{
			}
			num = (short)873988096;
			short num3 = num;
			num = (short)652738560;
			if (num != 0)
			{
			}
			return properties;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000801C File Offset: 0x0000621C
		public object GetPropertyOwner(global::System.ComponentModel.PropertyDescriptor pd)
		{
			object propertyOwner;
			short num;
			for (;;)
			{
				propertyOwner = this.a.GetPropertyOwner(pd);
				num = (short)611201141;
				short num2 = num;
				num = (short)756232309;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_45;
				}
			}
			IL_45:
			num = (short)1023148032;
			if (num != 0)
			{
			}
			num = (short)42926080;
			short num3 = num;
			num = (short)190054401;
			if (num != 0)
			{
			}
			return propertyOwner;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000080D8 File Offset: 0x000062D8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteConnectionStringBuilder c()
		{
			short num = (short)438152201;
			short num2 = num;
			num = (short)835103753;
			switch (num2 == num)
			{
			}
			num = (short)50855937;
			if (num != 0)
			{
			}
			num = (short)1115881472;
			short num3 = num;
			num = (short)1773207552;
			if (num != 0)
			{
			}
			return this.a = new global::System.Data.SQLite.SQLiteConnectionStringBuilder();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008190 File Offset: 0x00006390
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b()
		{
			short num = (short)1799060348;
			short num2 = num;
			num = (short)809859964;
			switch (num2 == num)
			{
			}
			num = (short)1128202241;
			if (num != 0)
			{
			}
			num = (short)1393164288;
			short num3 = num;
			num = (short)423165952;
			if (num != 0)
			{
			}
			return this.a.DataSource;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008244 File Offset: 0x00006444
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a()
		{
			short num = (short)2041038776;
			short num2 = num;
			num = (short)1128187832;
			switch (num2 == num)
			{
			}
			num = (short)1468858368;
			if (num != 0)
			{
			}
			num = (short)641990656;
			short num3 = num;
			num = (short)2142699521;
			if (num != 0)
			{
			}
			return this.a.ConnectionString;
		}

		// Token: 0x0400002B RID: 43
		internal global::System.Data.SQLite.SQLiteConnectionStringBuilder a;

		// Token: 0x02000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600009F RID: 159 RVA: 0x0000830C File Offset: 0x0000650C
			internal string c()
			{
				short num = (short)1014029447;
				short num2 = num;
				num = (short)825351303;
				switch (num2 == num)
				{
				}
				num = (short)584056833;
				if (num != 0)
				{
				}
				num = (short)1903624192;
				short num3 = num;
				num = (short)1862991872;
				if (num != 0)
				{
				}
				return this.a.a.DataSource = this.b;
			}

			// Token: 0x0400002C RID: 44
			public global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder a;

			// Token: 0x0400002D RID: 45
			public string b;
		}

		// Token: 0x0200001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060000A1 RID: 161 RVA: 0x000083E4 File Offset: 0x000065E4
			internal string c()
			{
				short num = (short)1891041281;
				if (num != 0)
				{
				}
				num = (short)405508111;
				short num2 = num;
				num = (short)265261071;
				switch (num2 == num)
				{
				}
				num = (short)1988820992;
				short num3 = num;
				num = (short)326893568;
				if (num != 0)
				{
				}
				return this.a.a.ConnectionString = this.b;
			}

			// Token: 0x0400002E RID: 46
			public global::Motorola.Data.SQLite.SQLiteConnectionStringBuilder a;

			// Token: 0x0400002F RID: 47
			public string b;
		}
	}
}
