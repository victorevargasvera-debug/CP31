using System;
using System.Collections;
using System.IO;
using System.Text;
using NPOI.POIFS.Dev;
using NPOI.Util;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002BD RID: 701
	public abstract class Property : global::NPOI.POIFS.Properties.Child, global::NPOI.POIFS.Dev.POIFSViewable
	{
		// Token: 0x06001352 RID: 4946 RVA: 0x0003A020 File Offset: 0x00038220
		protected Property()
		{
			this._raw_data = new byte[128];
			for (int i = 0; i < this._raw_data.Length; i++)
			{
				this._raw_data[i] = 0;
			}
			this._name_size = new global::NPOI.Util.ShortField(64);
			this._property_type = new global::NPOI.Util.ByteField(66);
			this._node_color = new global::NPOI.Util.ByteField(67);
			this._previous_property = new global::NPOI.Util.IntegerField(68, -1, this._raw_data);
			this._next_property = new global::NPOI.Util.IntegerField(72, -1, this._raw_data);
			this._child_property = new global::NPOI.Util.IntegerField(76, -1, this._raw_data);
			this._storage_clsid = new global::NPOI.Util.ClassID(this._raw_data, 80);
			this._user_flags = new global::NPOI.Util.IntegerField(96, 0, this._raw_data);
			this._seconds_1 = new global::NPOI.Util.IntegerField(100, 0, this._raw_data);
			this._days_1 = new global::NPOI.Util.IntegerField(104, 0, this._raw_data);
			this._seconds_2 = new global::NPOI.Util.IntegerField(108, 0, this._raw_data);
			this._days_2 = new global::NPOI.Util.IntegerField(112, 0, this._raw_data);
			this._start_block = new global::NPOI.Util.IntegerField(116);
			this._size = new global::NPOI.Util.IntegerField(120, 0, this._raw_data);
			this._index = -1;
			this.Name = "";
			this.NextChild = null;
			this.PreviousChild = null;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0003A17C File Offset: 0x0003837C
		protected Property(int index, byte[] array, int offset)
		{
			this._raw_data = new byte[128];
			global::System.Array.Copy(array, offset, this._raw_data, 0, 128);
			this._name_size = new global::NPOI.Util.ShortField(64, this._raw_data);
			this._property_type = new global::NPOI.Util.ByteField(66, this._raw_data);
			this._node_color = new global::NPOI.Util.ByteField(67, this._raw_data);
			this._previous_property = new global::NPOI.Util.IntegerField(68, this._raw_data);
			this._next_property = new global::NPOI.Util.IntegerField(72, this._raw_data);
			this._child_property = new global::NPOI.Util.IntegerField(76, this._raw_data);
			this._storage_clsid = new global::NPOI.Util.ClassID(this._raw_data, 80);
			this._user_flags = new global::NPOI.Util.IntegerField(96, 0, this._raw_data);
			this._seconds_1 = new global::NPOI.Util.IntegerField(100, this._raw_data);
			this._days_1 = new global::NPOI.Util.IntegerField(104, this._raw_data);
			this._seconds_2 = new global::NPOI.Util.IntegerField(108, this._raw_data);
			this._days_2 = new global::NPOI.Util.IntegerField(112, this._raw_data);
			this._start_block = new global::NPOI.Util.IntegerField(116, this._raw_data);
			this._size = new global::NPOI.Util.IntegerField(120, this._raw_data);
			this._index = index;
			int num = (int)(this._name_size.Value / 2 - 1);
			if (num < 1)
			{
				this._name = "";
			}
			else
			{
				char[] array2 = new char[num];
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					array2[i] = (char)new global::NPOI.Util.ShortField(num2, this._raw_data).Value;
					num2 += 2;
				}
				this._name = new string(array2, 0, num);
			}
			this._next_child = null;
			this._previous_child = null;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0003A32F File Offset: 0x0003852F
		public void WriteData(global::System.IO.Stream stream)
		{
			stream.Write(this._raw_data, 0, this._raw_data.Length);
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x0003A35A File Offset: 0x0003855A
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x0003A346 File Offset: 0x00038546
		public int StartBlock
		{
			get
			{
				return this._start_block.Value;
			}
			set
			{
				this._start_block.Set(value, this._raw_data);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x0003A367 File Offset: 0x00038567
		public bool ShouldUseSmallBlocks
		{
			get
			{
				return global::NPOI.POIFS.Properties.Property.IsSmall(this._size.Value);
			}
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0003A379 File Offset: 0x00038579
		public static bool IsSmall(int length)
		{
			return length < 4096;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x0003A383 File Offset: 0x00038583
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x0003A38C File Offset: 0x0003858C
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				char[] array = value.ToCharArray();
				int num = global::System.Math.Min(array.Length, 31);
				this._name = new string(array, 0, num);
				short num2 = 0;
				int i;
				for (i = 0; i < num; i++)
				{
					global::NPOI.Util.ShortField.Write((int)num2, (short)array[i], ref this._raw_data);
					num2 += 2;
				}
				while (i < 32)
				{
					global::NPOI.Util.ShortField.Write((int)num2, 0, ref this._raw_data);
					num2 += 2;
					i++;
				}
				this._name_size.Set((short)((num + 1) * 2), ref this._raw_data);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00006EB4 File Offset: 0x000050B4
		public virtual bool IsDirectory
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0003A410 File Offset: 0x00038610
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0003A418 File Offset: 0x00038618
		public global::NPOI.Util.ClassID StorageClsid
		{
			get
			{
				return this._storage_clsid;
			}
			set
			{
				this._storage_clsid = value;
				if (value == null)
				{
					for (int i = 80; i < 96; i++)
					{
						this._raw_data[i] = 0;
					}
					return;
				}
				value.Write(this._raw_data, 80);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x0003A455 File Offset: 0x00038655
		public byte PropertyType
		{
			set
			{
				this._property_type.Set(value, this._raw_data);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x0003A469 File Offset: 0x00038669
		public byte NodeColor
		{
			set
			{
				this._node_color.Set(value, this._raw_data);
			}
		}

		// Token: 0x170003A5 RID: 933
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x0003A47D File Offset: 0x0003867D
		public int ChildProperty
		{
			set
			{
				this._child_property.Set(value, this._raw_data);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0003A491 File Offset: 0x00038691
		public int ChildIndex
		{
			get
			{
				return this._child_property.Value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x0003A4B2 File Offset: 0x000386B2
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x0003A49E File Offset: 0x0003869E
		public virtual int Size
		{
			get
			{
				return this._size.Value;
			}
			set
			{
				this._size.Set(value, this._raw_data);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0003A4BF File Offset: 0x000386BF
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x0003A4C7 File Offset: 0x000386C7
		public int Index
		{
			get
			{
				return this._index;
			}
			set
			{
				this._index = value;
			}
		}

		// Token: 0x06001366 RID: 4966
		public abstract void PreWrite();

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0003A4D0 File Offset: 0x000386D0
		public int NextChildIndex
		{
			get
			{
				return this._next_property.Value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0003A4DD File Offset: 0x000386DD
		public int PreviousChildIndex
		{
			get
			{
				return this._previous_property.Value;
			}
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0003A4EA File Offset: 0x000386EA
		public static bool IsValidIndex(int index)
		{
			return index != -1;
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0003A51E File Offset: 0x0003871E
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x0003A4F3 File Offset: 0x000386F3
		public global::NPOI.POIFS.Properties.Child PreviousChild
		{
			get
			{
				return this._previous_child;
			}
			set
			{
				this._previous_child = value;
				this._previous_property.Set((value == null) ? -1 : ((global::NPOI.POIFS.Properties.Property)value).Index, this._raw_data);
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0003A551 File Offset: 0x00038751
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x0003A526 File Offset: 0x00038726
		public global::NPOI.POIFS.Properties.Child NextChild
		{
			get
			{
				return this._next_child;
			}
			set
			{
				this._next_child = value;
				this._next_property.Set((value == null) ? -1 : ((global::NPOI.POIFS.Properties.Property)value).Index, this._raw_data);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0003A55C File Offset: 0x0003875C
		public global::System.Array ViewableArray
		{
			get
			{
				string[] array = new string[5];
				array.SetValue("Name          = \"" + this.Name + "\"", 0);
				array.SetValue("Property Type = " + this._property_type.Value.ToString(), 1);
				array.SetValue("Node Color    = " + this._node_color.Value.ToString(), 2);
				long num = (long)this._days_1.Value;
				num <<= 32;
				array.SetValue("Time 1        = " + (num + ((long)this._seconds_1.Value & 65535L)).ToString(), 3);
				num = (long)this._days_2.Value;
				num <<= 32;
				array.SetValue("Time 2        = " + (num + ((long)this._seconds_2.Value & 65535L)).ToString(), 4);
				return array;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x0003A653 File Offset: 0x00038853
		public global::System.Collections.IEnumerator ViewableIterator
		{
			get
			{
				return global::System.Collections.ArrayList.ReadOnly(new global::System.Collections.ArrayList()).GetEnumerator();
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x00008875 File Offset: 0x00006A75
		public bool PreferArray
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x0003A664 File Offset: 0x00038864
		public string ShortDescription
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append("Property: \"").Append(this.Name).Append("\"");
				return stringBuilder.ToString();
			}
		}

		// Token: 0x040007F5 RID: 2037
		private const byte _default_fill = 0;

		// Token: 0x040007F6 RID: 2038
		private const int _name_size_offset = 64;

		// Token: 0x040007F7 RID: 2039
		private const int _max_name_length = 31;

		// Token: 0x040007F8 RID: 2040
		protected const int _NO_INDEX = -1;

		// Token: 0x040007F9 RID: 2041
		private const int _node_color_offset = 67;

		// Token: 0x040007FA RID: 2042
		private const int _previous_property_offset = 68;

		// Token: 0x040007FB RID: 2043
		private const int _next_property_offset = 72;

		// Token: 0x040007FC RID: 2044
		private const int _child_property_offset = 76;

		// Token: 0x040007FD RID: 2045
		private const int _storage_clsid_offset = 80;

		// Token: 0x040007FE RID: 2046
		private const int _user_flags_offset = 96;

		// Token: 0x040007FF RID: 2047
		private const int _seconds_1_offset = 100;

		// Token: 0x04000800 RID: 2048
		private const int _days_1_offset = 104;

		// Token: 0x04000801 RID: 2049
		private const int _seconds_2_offset = 108;

		// Token: 0x04000802 RID: 2050
		private const int _days_2_offset = 112;

		// Token: 0x04000803 RID: 2051
		private const int _start_block_offset = 116;

		// Token: 0x04000804 RID: 2052
		private const int _size_offset = 120;

		// Token: 0x04000805 RID: 2053
		protected const byte _NODE_BLACK = 1;

		// Token: 0x04000806 RID: 2054
		protected const byte _NODE_RED = 0;

		// Token: 0x04000807 RID: 2055
		private const int _big_block_minimum_bytes = 4096;

		// Token: 0x04000808 RID: 2056
		private string _name;

		// Token: 0x04000809 RID: 2057
		private global::NPOI.Util.ShortField _name_size;

		// Token: 0x0400080A RID: 2058
		private global::NPOI.Util.ByteField _property_type;

		// Token: 0x0400080B RID: 2059
		private global::NPOI.Util.ByteField _node_color;

		// Token: 0x0400080C RID: 2060
		private global::NPOI.Util.IntegerField _previous_property;

		// Token: 0x0400080D RID: 2061
		private global::NPOI.Util.IntegerField _next_property;

		// Token: 0x0400080E RID: 2062
		private global::NPOI.Util.IntegerField _child_property;

		// Token: 0x0400080F RID: 2063
		private global::NPOI.Util.ClassID _storage_clsid;

		// Token: 0x04000810 RID: 2064
		private global::NPOI.Util.IntegerField _user_flags;

		// Token: 0x04000811 RID: 2065
		private global::NPOI.Util.IntegerField _seconds_1;

		// Token: 0x04000812 RID: 2066
		private global::NPOI.Util.IntegerField _days_1;

		// Token: 0x04000813 RID: 2067
		private global::NPOI.Util.IntegerField _seconds_2;

		// Token: 0x04000814 RID: 2068
		private global::NPOI.Util.IntegerField _days_2;

		// Token: 0x04000815 RID: 2069
		private global::NPOI.Util.IntegerField _start_block;

		// Token: 0x04000816 RID: 2070
		private global::NPOI.Util.IntegerField _size;

		// Token: 0x04000817 RID: 2071
		private byte[] _raw_data;

		// Token: 0x04000818 RID: 2072
		private int _index;

		// Token: 0x04000819 RID: 2073
		private global::NPOI.POIFS.Properties.Child _next_child;

		// Token: 0x0400081A RID: 2074
		private global::NPOI.POIFS.Properties.Child _previous_child;
	}
}
