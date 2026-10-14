using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000400 RID: 1024
	internal class VarVec : global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002F9F RID: 12191 RVA: 0x00095286 File Offset: 0x00093486
		internal void Clear()
		{
			this.m_bitVector.Length = 0;
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x00095294 File Offset: 0x00093494
		internal void And(global::System.Data.Entity.Core.Query.InternalTrees.VarVec other)
		{
			this.Align(other);
			this.m_bitVector.And(other.m_bitVector);
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x000952AF File Offset: 0x000934AF
		internal void Or(global::System.Data.Entity.Core.Query.InternalTrees.VarVec other)
		{
			this.Align(other);
			this.m_bitVector.Or(other.m_bitVector);
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x000952CC File Offset: 0x000934CC
		internal void Minus(global::System.Data.Entity.Core.Query.InternalTrees.VarVec other)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec(other);
			varVec.m_bitVector.Length = this.m_bitVector.Length;
			varVec.m_bitVector.Not();
			this.And(varVec);
			this.m_command.ReleaseVarVec(varVec);
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x0009531C File Offset: 0x0009351C
		internal bool Overlaps(global::System.Data.Entity.Core.Query.InternalTrees.VarVec other)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec(other);
			varVec.And(this);
			bool result = !varVec.IsEmpty;
			this.m_command.ReleaseVarVec(varVec);
			return result;
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x00095354 File Offset: 0x00093554
		internal bool Subsumes(global::System.Data.Entity.Core.Query.InternalTrees.VarVec other)
		{
			int[] array = this.m_bitVector.m_array;
			int[] array2 = other.m_bitVector.m_array;
			if (array2.Length > array.Length)
			{
				for (int i = array.Length; i < array2.Length; i++)
				{
					if (array2[i] != 0)
					{
						return false;
					}
				}
			}
			int num = global::System.Math.Min(array2.Length, array.Length);
			for (int j = 0; j < num; j++)
			{
				if ((array[j] & array2[j]) != array2[j])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000953C6 File Offset: 0x000935C6
		internal void InitFrom(global::System.Data.Entity.Core.Query.InternalTrees.VarVec other)
		{
			this.Clear();
			this.m_bitVector.Length = other.m_bitVector.Length;
			this.m_bitVector.Or(other.m_bitVector);
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x000953F6 File Offset: 0x000935F6
		internal void InitFrom(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> other)
		{
			this.InitFrom(other, false);
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00095400 File Offset: 0x00093600
		internal void InitFrom(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> other, bool ignoreParameters)
		{
			this.Clear();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in other)
			{
				if (!ignoreParameters || var.VarType != global::System.Data.Entity.Core.Query.InternalTrees.VarType.Parameter)
				{
					this.Set(var);
				}
			}
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x0009545C File Offset: 0x0009365C
		public global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> GetEnumerator()
		{
			return this.m_command.GetVarVecEnumerator(this);
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x0009546A File Offset: 0x0009366A
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x00095474 File Offset: 0x00093674
		internal int Count
		{
			get
			{
				int num = 0;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in this)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x000954BC File Offset: 0x000936BC
		internal bool IsSet(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			this.Align(v.Id);
			return this.m_bitVector.Get(v.Id);
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x000954DB File Offset: 0x000936DB
		internal void Set(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			this.Align(v.Id);
			this.m_bitVector.Set(v.Id, true);
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x000954FB File Offset: 0x000936FB
		internal void Clear(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			this.Align(v.Id);
			this.m_bitVector.Set(v.Id, false);
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x0009551B File Offset: 0x0009371B
		internal bool IsEmpty
		{
			get
			{
				return this.First == null;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x00095528 File Offset: 0x00093728
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var First
		{
			get
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator = this.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return enumerator.Current;
					}
				}
				return null;
			}
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00095570 File Offset: 0x00093770
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Remap(global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in this)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var v;
				if (!varMap.TryGetValue(var, out v))
				{
					v = var;
				}
				varVec.Set(v);
			}
			return varVec;
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x000955D4 File Offset: 0x000937D4
		internal VarVec(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			this.m_bitVector = new global::System.Data.Entity.Core.Query.InternalTrees.BitVec(64);
			this.m_command = command;
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x000955F0 File Offset: 0x000937F0
		private void Align(global::System.Data.Entity.Core.Query.InternalTrees.VarVec other)
		{
			if (other.m_bitVector.Length == this.m_bitVector.Length)
			{
				return;
			}
			if (other.m_bitVector.Length > this.m_bitVector.Length)
			{
				this.m_bitVector.Length = other.m_bitVector.Length;
				return;
			}
			other.m_bitVector.Length = this.m_bitVector.Length;
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x0009565B File Offset: 0x0009385B
		private void Align(int idx)
		{
			if (idx >= this.m_bitVector.Length)
			{
				this.m_bitVector.Length = idx + 1;
			}
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x0009567C File Offset: 0x0009387C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = string.Empty;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in this)
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}{1}", new object[]
				{
					text,
					var.Id
				});
				text = ",";
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x00095700 File Offset: 0x00093900
		public global::System.Data.Entity.Core.Query.InternalTrees.VarVec Clone()
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec();
			varVec.InitFrom(this);
			return varVec;
		}

		// Token: 0x04001012 RID: 4114
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.BitVec m_bitVector;

		// Token: 0x04001013 RID: 4115
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;

		// Token: 0x02000A0B RID: 2571
		internal class VarVecEnumerator : global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060060CE RID: 24782 RVA: 0x0014BE07 File Offset: 0x0014A007
			internal VarVecEnumerator(global::System.Data.Entity.Core.Query.InternalTrees.VarVec vec)
			{
				this.Init(vec);
			}

			// Token: 0x060060CF RID: 24783 RVA: 0x0014BE16 File Offset: 0x0014A016
			internal void Init(global::System.Data.Entity.Core.Query.InternalTrees.VarVec vec)
			{
				this.m_position = -1;
				this.m_command = vec.m_command;
				this.m_bitArray = vec.m_bitVector;
			}

			// Token: 0x170010AA RID: 4266
			// (get) Token: 0x060060D0 RID: 24784 RVA: 0x0014BE37 File Offset: 0x0014A037
			public global::System.Data.Entity.Core.Query.InternalTrees.Var Current
			{
				get
				{
					if (this.m_position < 0 || this.m_position >= this.m_bitArray.Length)
					{
						return null;
					}
					return this.m_command.GetVar(this.m_position);
				}
			}

			// Token: 0x170010AB RID: 4267
			// (get) Token: 0x060060D1 RID: 24785 RVA: 0x0014BE68 File Offset: 0x0014A068
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060060D2 RID: 24786 RVA: 0x0014BE70 File Offset: 0x0014A070
			public bool MoveNext()
			{
				int[] array = this.m_bitArray.m_array;
				this.m_position++;
				int length = this.m_bitArray.Length;
				int arrayLength = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(length, 32);
				int i = this.m_position / 32;
				if (i < arrayLength)
				{
					int num = array[i];
					int num2 = -1 << this.m_position % 32;
					num &= num2;
					if (num != 0)
					{
						this.m_position = i * 32 + global::System.Data.Entity.Core.Query.InternalTrees.VarVec.VarVecEnumerator.MultiplyDeBruijnBitPosition[(int)((uint)((long)(num & -num) * 125613361L) >> 27)];
						return true;
					}
					for (i++; i < arrayLength; i++)
					{
						num = array[i];
						if (num != 0)
						{
							this.m_position = i * 32 + global::System.Data.Entity.Core.Query.InternalTrees.VarVec.VarVecEnumerator.MultiplyDeBruijnBitPosition[(int)((uint)((long)(num & -num) * 125613361L) >> 27)];
							return true;
						}
					}
				}
				this.m_position = length;
				return false;
			}

			// Token: 0x060060D3 RID: 24787 RVA: 0x0014BF4C File Offset: 0x0014A14C
			public void Reset()
			{
				this.m_position = -1;
			}

			// Token: 0x060060D4 RID: 24788 RVA: 0x0014BF55 File Offset: 0x0014A155
			public void Dispose()
			{
				global::System.GC.SuppressFinalize(this);
				this.m_bitArray = null;
				this.m_command.ReleaseVarVecEnumerator(this);
			}

			// Token: 0x04002920 RID: 10528
			private int m_position;

			// Token: 0x04002921 RID: 10529
			private global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;

			// Token: 0x04002922 RID: 10530
			private global::System.Data.Entity.Core.Query.InternalTrees.BitVec m_bitArray;

			// Token: 0x04002923 RID: 10531
			private static readonly int[] MultiplyDeBruijnBitPosition = new int[]
			{
				0,
				1,
				28,
				2,
				29,
				14,
				24,
				3,
				30,
				22,
				20,
				15,
				25,
				17,
				4,
				8,
				31,
				27,
				13,
				23,
				21,
				19,
				16,
				7,
				26,
				12,
				18,
				6,
				11,
				5,
				10,
				9
			};
		}
	}
}
