using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000106 RID: 262
	[global::System.Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonReader : global::Newtonsoft.Json.JsonReader
	{
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00035B8A File Offset: 0x00033D8A
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x00035B92 File Offset: 0x00033D92
		[global::System.Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
		public bool JsonNet35BinaryCompatibility
		{
			get
			{
				return this._jsonNet35BinaryCompatibility;
			}
			set
			{
				this._jsonNet35BinaryCompatibility = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00035B9B File Offset: 0x00033D9B
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x00035BA3 File Offset: 0x00033DA3
		public bool ReadRootValueAsArray
		{
			get
			{
				return this._readRootValueAsArray;
			}
			set
			{
				this._readRootValueAsArray = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00035BAC File Offset: 0x00033DAC
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x00035BB4 File Offset: 0x00033DB4
		public global::System.DateTimeKind DateTimeKindHandling
		{
			get
			{
				return this._dateTimeKindHandling;
			}
			set
			{
				this._dateTimeKindHandling = value;
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00035BBD File Offset: 0x00033DBD
		public BsonReader(global::System.IO.Stream stream) : this(stream, false, global::System.DateTimeKind.Local)
		{
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00035BC8 File Offset: 0x00033DC8
		public BsonReader(global::System.IO.BinaryReader reader) : this(reader, false, global::System.DateTimeKind.Local)
		{
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00035BD3 File Offset: 0x00033DD3
		public BsonReader(global::System.IO.Stream stream, bool readRootValueAsArray, global::System.DateTimeKind dateTimeKindHandling)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(stream, "stream");
			this._reader = new global::System.IO.BinaryReader(stream);
			this._stack = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Bson.BsonReader.ContainerContext>();
			this._readRootValueAsArray = readRootValueAsArray;
			this._dateTimeKindHandling = dateTimeKindHandling;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00035C0B File Offset: 0x00033E0B
		public BsonReader(global::System.IO.BinaryReader reader, bool readRootValueAsArray, global::System.DateTimeKind dateTimeKindHandling)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(reader, "reader");
			this._reader = reader;
			this._stack = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Bson.BsonReader.ContainerContext>();
			this._readRootValueAsArray = readRootValueAsArray;
			this._dateTimeKindHandling = dateTimeKindHandling;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00035C3E File Offset: 0x00033E3E
		private string ReadElement()
		{
			this._currentElementType = this.ReadType();
			return this.ReadString();
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00035C54 File Offset: 0x00033E54
		public override bool Read()
		{
			bool result;
			try
			{
				bool flag;
				switch (this._bsonReaderState)
				{
				case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.Normal:
					flag = this.ReadNormal();
					break;
				case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceStart:
				case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceRef:
				case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceId:
					flag = this.ReadReference();
					break;
				case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeStart:
				case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeCode:
				case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeScope:
				case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeScopeObject:
				case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeScopeEnd:
					flag = this.ReadCodeWScope();
					break;
				default:
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._bsonReaderState));
				}
				if (!flag)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.None);
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (global::System.IO.EndOfStreamException)
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.None);
				result = false;
			}
			return result;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00035D00 File Offset: 0x00033F00
		public override void Close()
		{
			base.Close();
			if (base.CloseInput)
			{
				global::System.IO.BinaryReader reader = this._reader;
				if (reader == null)
				{
					return;
				}
				reader.Close();
			}
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00035D20 File Offset: 0x00033F20
		private bool ReadCodeWScope()
		{
			switch (this._bsonReaderState)
			{
			case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeStart:
				base.SetToken(global::Newtonsoft.Json.JsonToken.PropertyName, "$code");
				this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeCode;
				return true;
			case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeCode:
				this.ReadInt32();
				base.SetToken(global::Newtonsoft.Json.JsonToken.String, this.ReadLengthString());
				this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeScope;
				return true;
			case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeScope:
			{
				if (base.CurrentState == global::Newtonsoft.Json.JsonReader.State.PostValue)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.PropertyName, "$scope");
					return true;
				}
				base.SetToken(global::Newtonsoft.Json.JsonToken.StartObject);
				this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeScopeObject;
				global::Newtonsoft.Json.Bson.BsonReader.ContainerContext containerContext = new global::Newtonsoft.Json.Bson.BsonReader.ContainerContext(global::Newtonsoft.Json.Bson.BsonType.Object);
				this.PushContext(containerContext);
				containerContext.Length = this.ReadInt32();
				return true;
			}
			case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeScopeObject:
			{
				bool flag = this.ReadNormal();
				if (flag && this.TokenType == global::Newtonsoft.Json.JsonToken.EndObject)
				{
					this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeScopeEnd;
				}
				return flag;
			}
			case global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeScopeEnd:
				base.SetToken(global::Newtonsoft.Json.JsonToken.EndObject);
				this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.Normal;
				return true;
			default:
				throw new global::System.ArgumentOutOfRangeException();
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00035DFC File Offset: 0x00033FFC
		private bool ReadReference()
		{
			global::Newtonsoft.Json.JsonReader.State currentState = base.CurrentState;
			if (currentState != global::Newtonsoft.Json.JsonReader.State.Property)
			{
				if (currentState == global::Newtonsoft.Json.JsonReader.State.ObjectStart)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.PropertyName, "$ref");
					this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceRef;
					return true;
				}
				if (currentState != global::Newtonsoft.Json.JsonReader.State.PostValue)
				{
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state when reading BSON reference: " + base.CurrentState.ToString());
				}
				if (this._bsonReaderState == global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceRef)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.PropertyName, "$id");
					this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceId;
					return true;
				}
				if (this._bsonReaderState == global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceId)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.EndObject);
					this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.Normal;
					return true;
				}
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state when reading BSON reference: " + this._bsonReaderState.ToString());
			}
			else
			{
				if (this._bsonReaderState == global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceRef)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.String, this.ReadLengthString());
					return true;
				}
				if (this._bsonReaderState == global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceId)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, this.ReadBytes(12));
					return true;
				}
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state when reading BSON reference: " + this._bsonReaderState.ToString());
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00035F0C File Offset: 0x0003410C
		private bool ReadNormal()
		{
			switch (base.CurrentState)
			{
			case global::Newtonsoft.Json.JsonReader.State.Start:
				break;
			case global::Newtonsoft.Json.JsonReader.State.Complete:
			case global::Newtonsoft.Json.JsonReader.State.Closed:
				return false;
			case global::Newtonsoft.Json.JsonReader.State.Property:
				this.ReadType(this._currentElementType);
				return true;
			case global::Newtonsoft.Json.JsonReader.State.ObjectStart:
			case global::Newtonsoft.Json.JsonReader.State.ArrayStart:
			case global::Newtonsoft.Json.JsonReader.State.PostValue:
			{
				global::Newtonsoft.Json.Bson.BsonReader.ContainerContext currentContext = this._currentContext;
				if (currentContext == null)
				{
					if (!base.SupportMultipleContent)
					{
						return false;
					}
				}
				else
				{
					int num = currentContext.Length - 1;
					if (currentContext.Position < num)
					{
						if (currentContext.Type == global::Newtonsoft.Json.Bson.BsonType.Array)
						{
							this.ReadElement();
							this.ReadType(this._currentElementType);
							return true;
						}
						base.SetToken(global::Newtonsoft.Json.JsonToken.PropertyName, this.ReadElement());
						return true;
					}
					else
					{
						if (currentContext.Position != num)
						{
							throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Read past end of current container context.");
						}
						if (this.ReadByte() != 0)
						{
							throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected end of object byte value.");
						}
						this.PopContext();
						if (this._currentContext != null)
						{
							this.MovePosition(currentContext.Length);
						}
						global::Newtonsoft.Json.JsonToken token = (currentContext.Type == global::Newtonsoft.Json.Bson.BsonType.Object) ? global::Newtonsoft.Json.JsonToken.EndObject : global::Newtonsoft.Json.JsonToken.EndArray;
						base.SetToken(token);
						return true;
					}
				}
				break;
			}
			case global::Newtonsoft.Json.JsonReader.State.Object:
			case global::Newtonsoft.Json.JsonReader.State.Array:
				goto IL_145;
			case global::Newtonsoft.Json.JsonReader.State.ConstructorStart:
			case global::Newtonsoft.Json.JsonReader.State.Constructor:
			case global::Newtonsoft.Json.JsonReader.State.Error:
			case global::Newtonsoft.Json.JsonReader.State.Finished:
				return false;
			default:
				goto IL_145;
			}
			global::Newtonsoft.Json.JsonToken token2 = (!this._readRootValueAsArray) ? global::Newtonsoft.Json.JsonToken.StartObject : global::Newtonsoft.Json.JsonToken.StartArray;
			global::Newtonsoft.Json.Bson.BsonType type = (!this._readRootValueAsArray) ? global::Newtonsoft.Json.Bson.BsonType.Object : global::Newtonsoft.Json.Bson.BsonType.Array;
			base.SetToken(token2);
			global::Newtonsoft.Json.Bson.BsonReader.ContainerContext containerContext = new global::Newtonsoft.Json.Bson.BsonReader.ContainerContext(type);
			this.PushContext(containerContext);
			containerContext.Length = this.ReadInt32();
			return true;
			IL_145:
			throw new global::System.ArgumentOutOfRangeException();
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00036068 File Offset: 0x00034268
		private void PopContext()
		{
			this._stack.RemoveAt(this._stack.Count - 1);
			if (this._stack.Count == 0)
			{
				this._currentContext = null;
				return;
			}
			this._currentContext = this._stack[this._stack.Count - 1];
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x000360C0 File Offset: 0x000342C0
		private void PushContext(global::Newtonsoft.Json.Bson.BsonReader.ContainerContext newContext)
		{
			this._stack.Add(newContext);
			this._currentContext = newContext;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000360D5 File Offset: 0x000342D5
		private byte ReadByte()
		{
			this.MovePosition(1);
			return this._reader.ReadByte();
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000360EC File Offset: 0x000342EC
		private void ReadType(global::Newtonsoft.Json.Bson.BsonType type)
		{
			switch (type)
			{
			case global::Newtonsoft.Json.Bson.BsonType.Number:
			{
				double num = this.ReadDouble();
				if (this._floatParseHandling == global::Newtonsoft.Json.FloatParseHandling.Decimal)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.Float, global::System.Convert.ToDecimal(num, global::System.Globalization.CultureInfo.InvariantCulture));
					return;
				}
				base.SetToken(global::Newtonsoft.Json.JsonToken.Float, num);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.String:
			case global::Newtonsoft.Json.Bson.BsonType.Symbol:
				base.SetToken(global::Newtonsoft.Json.JsonToken.String, this.ReadLengthString());
				return;
			case global::Newtonsoft.Json.Bson.BsonType.Object:
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.StartObject);
				global::Newtonsoft.Json.Bson.BsonReader.ContainerContext containerContext = new global::Newtonsoft.Json.Bson.BsonReader.ContainerContext(global::Newtonsoft.Json.Bson.BsonType.Object);
				this.PushContext(containerContext);
				containerContext.Length = this.ReadInt32();
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Array:
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.StartArray);
				global::Newtonsoft.Json.Bson.BsonReader.ContainerContext containerContext2 = new global::Newtonsoft.Json.Bson.BsonReader.ContainerContext(global::Newtonsoft.Json.Bson.BsonType.Array);
				this.PushContext(containerContext2);
				containerContext2.Length = this.ReadInt32();
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Binary:
			{
				global::Newtonsoft.Json.Bson.BsonBinaryType bsonBinaryType;
				byte[] array = this.ReadBinary(out bsonBinaryType);
				object value = (bsonBinaryType != global::Newtonsoft.Json.Bson.BsonBinaryType.Uuid) ? array : new global::System.Guid(array);
				base.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, value);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Undefined:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Undefined);
				return;
			case global::Newtonsoft.Json.Bson.BsonType.Oid:
			{
				byte[] value2 = this.ReadBytes(12);
				base.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, value2);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Boolean:
			{
				bool flag = global::System.Convert.ToBoolean(this.ReadByte());
				base.SetToken(global::Newtonsoft.Json.JsonToken.Boolean, flag);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Date:
			{
				global::System.DateTime dateTime = global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertJavaScriptTicksToDateTime(this.ReadInt64());
				global::System.DateTimeKind dateTimeKindHandling = this.DateTimeKindHandling;
				global::System.DateTime dateTime2;
				if (dateTimeKindHandling != global::System.DateTimeKind.Unspecified)
				{
					if (dateTimeKindHandling != global::System.DateTimeKind.Local)
					{
						dateTime2 = dateTime;
					}
					else
					{
						dateTime2 = dateTime.ToLocalTime();
					}
				}
				else
				{
					dateTime2 = global::System.DateTime.SpecifyKind(dateTime, global::System.DateTimeKind.Unspecified);
				}
				base.SetToken(global::Newtonsoft.Json.JsonToken.Date, dateTime2);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Null:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Null);
				return;
			case global::Newtonsoft.Json.Bson.BsonType.Regex:
			{
				string str = this.ReadString();
				string str2 = this.ReadString();
				string value3 = "/" + str + "/" + str2;
				base.SetToken(global::Newtonsoft.Json.JsonToken.String, value3);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Reference:
				base.SetToken(global::Newtonsoft.Json.JsonToken.StartObject);
				this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.ReferenceStart;
				return;
			case global::Newtonsoft.Json.Bson.BsonType.Code:
				base.SetToken(global::Newtonsoft.Json.JsonToken.String, this.ReadLengthString());
				return;
			case global::Newtonsoft.Json.Bson.BsonType.CodeWScope:
				base.SetToken(global::Newtonsoft.Json.JsonToken.StartObject);
				this._bsonReaderState = global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState.CodeWScopeStart;
				return;
			case global::Newtonsoft.Json.Bson.BsonType.Integer:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Integer, (long)this.ReadInt32());
				return;
			case global::Newtonsoft.Json.Bson.BsonType.TimeStamp:
			case global::Newtonsoft.Json.Bson.BsonType.Long:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Integer, this.ReadInt64());
				return;
			default:
				throw new global::System.ArgumentOutOfRangeException("type", "Unexpected BsonType value: " + type.ToString());
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0003633C File Offset: 0x0003453C
		private byte[] ReadBinary(out global::Newtonsoft.Json.Bson.BsonBinaryType binaryType)
		{
			int count = this.ReadInt32();
			binaryType = (global::Newtonsoft.Json.Bson.BsonBinaryType)this.ReadByte();
			if (binaryType == global::Newtonsoft.Json.Bson.BsonBinaryType.BinaryOld && !this._jsonNet35BinaryCompatibility)
			{
				count = this.ReadInt32();
			}
			return this.ReadBytes(count);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00036374 File Offset: 0x00034574
		private string ReadString()
		{
			this.EnsureBuffers();
			global::System.Text.StringBuilder stringBuilder = null;
			int num = 0;
			int num2 = 0;
			int num4;
			for (;;)
			{
				int num3 = num2;
				byte b;
				while (num3 < 128 && (b = this._reader.ReadByte()) > 0)
				{
					this._byteBuffer[num3++] = b;
				}
				num4 = num3 - num2;
				num += num4;
				if (num3 < 128 && stringBuilder == null)
				{
					break;
				}
				int lastFullCharStop = this.GetLastFullCharStop(num3 - 1);
				int chars = global::System.Text.Encoding.UTF8.GetChars(this._byteBuffer, 0, lastFullCharStop + 1, this._charBuffer, 0);
				if (stringBuilder == null)
				{
					stringBuilder = new global::System.Text.StringBuilder(256);
				}
				stringBuilder.Append(this._charBuffer, 0, chars);
				if (lastFullCharStop < num4 - 1)
				{
					num2 = num4 - lastFullCharStop - 1;
					global::System.Array.Copy(this._byteBuffer, lastFullCharStop + 1, this._byteBuffer, 0, num2);
				}
				else
				{
					if (num3 < 128)
					{
						goto Block_6;
					}
					num2 = 0;
				}
			}
			int chars2 = global::System.Text.Encoding.UTF8.GetChars(this._byteBuffer, 0, num4, this._charBuffer, 0);
			this.MovePosition(num + 1);
			return new string(this._charBuffer, 0, chars2);
			Block_6:
			this.MovePosition(num + 1);
			return stringBuilder.ToString();
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00036494 File Offset: 0x00034694
		private string ReadLengthString()
		{
			int num = this.ReadInt32();
			this.MovePosition(num);
			string @string = this.GetString(num - 1);
			this._reader.ReadByte();
			return @string;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000364C4 File Offset: 0x000346C4
		private string GetString(int length)
		{
			if (length == 0)
			{
				return string.Empty;
			}
			this.EnsureBuffers();
			global::System.Text.StringBuilder stringBuilder = null;
			int num = 0;
			int num2 = 0;
			int num3;
			for (;;)
			{
				int count = (length - num > 128 - num2) ? (128 - num2) : (length - num);
				num3 = this._reader.Read(this._byteBuffer, num2, count);
				if (num3 == 0)
				{
					break;
				}
				num += num3;
				num3 += num2;
				if (num3 == length)
				{
					goto Block_4;
				}
				int lastFullCharStop = this.GetLastFullCharStop(num3 - 1);
				if (stringBuilder == null)
				{
					stringBuilder = new global::System.Text.StringBuilder(length);
				}
				int chars = global::System.Text.Encoding.UTF8.GetChars(this._byteBuffer, 0, lastFullCharStop + 1, this._charBuffer, 0);
				stringBuilder.Append(this._charBuffer, 0, chars);
				if (lastFullCharStop < num3 - 1)
				{
					num2 = num3 - lastFullCharStop - 1;
					global::System.Array.Copy(this._byteBuffer, lastFullCharStop + 1, this._byteBuffer, 0, num2);
				}
				else
				{
					num2 = 0;
				}
				if (num >= length)
				{
					goto Block_7;
				}
			}
			throw new global::System.IO.EndOfStreamException("Unable to read beyond the end of the stream.");
			Block_4:
			int chars2 = global::System.Text.Encoding.UTF8.GetChars(this._byteBuffer, 0, num3, this._charBuffer, 0);
			return new string(this._charBuffer, 0, chars2);
			Block_7:
			return stringBuilder.ToString();
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000365DC File Offset: 0x000347DC
		private int GetLastFullCharStop(int start)
		{
			int i = start;
			int num = 0;
			while (i >= 0)
			{
				num = this.BytesInSequence(this._byteBuffer[i]);
				if (num == 0)
				{
					i--;
				}
				else
				{
					if (num != 1)
					{
						i--;
						break;
					}
					break;
				}
			}
			if (num == start - i)
			{
				return start;
			}
			return i;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00036620 File Offset: 0x00034820
		private int BytesInSequence(byte b)
		{
			if (b <= global::Newtonsoft.Json.Bson.BsonReader.SeqRange1[1])
			{
				return 1;
			}
			if (b >= global::Newtonsoft.Json.Bson.BsonReader.SeqRange2[0] && b <= global::Newtonsoft.Json.Bson.BsonReader.SeqRange2[1])
			{
				return 2;
			}
			if (b >= global::Newtonsoft.Json.Bson.BsonReader.SeqRange3[0] && b <= global::Newtonsoft.Json.Bson.BsonReader.SeqRange3[1])
			{
				return 3;
			}
			if (b >= global::Newtonsoft.Json.Bson.BsonReader.SeqRange4[0] && b <= global::Newtonsoft.Json.Bson.BsonReader.SeqRange4[1])
			{
				return 4;
			}
			return 0;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0003667C File Offset: 0x0003487C
		private void EnsureBuffers()
		{
			if (this._byteBuffer == null)
			{
				this._byteBuffer = new byte[128];
			}
			if (this._charBuffer == null)
			{
				int maxCharCount = global::System.Text.Encoding.UTF8.GetMaxCharCount(128);
				this._charBuffer = new char[maxCharCount];
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000366C5 File Offset: 0x000348C5
		private double ReadDouble()
		{
			this.MovePosition(8);
			return this._reader.ReadDouble();
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x000366D9 File Offset: 0x000348D9
		private int ReadInt32()
		{
			this.MovePosition(4);
			return this._reader.ReadInt32();
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x000366ED File Offset: 0x000348ED
		private long ReadInt64()
		{
			this.MovePosition(8);
			return this._reader.ReadInt64();
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00036701 File Offset: 0x00034901
		private global::Newtonsoft.Json.Bson.BsonType ReadType()
		{
			this.MovePosition(1);
			return (global::Newtonsoft.Json.Bson.BsonType)this._reader.ReadSByte();
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00036715 File Offset: 0x00034915
		private void MovePosition(int count)
		{
			this._currentContext.Position += count;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0003672A File Offset: 0x0003492A
		private byte[] ReadBytes(int count)
		{
			this.MovePosition(count);
			return this._reader.ReadBytes(count);
		}

		// Token: 0x0400040D RID: 1037
		private const int MaxCharBytesSize = 128;

		// Token: 0x0400040E RID: 1038
		private static readonly byte[] SeqRange1 = new byte[]
		{
			0,
			127
		};

		// Token: 0x0400040F RID: 1039
		private static readonly byte[] SeqRange2 = new byte[]
		{
			194,
			223
		};

		// Token: 0x04000410 RID: 1040
		private static readonly byte[] SeqRange3 = new byte[]
		{
			224,
			239
		};

		// Token: 0x04000411 RID: 1041
		private static readonly byte[] SeqRange4 = new byte[]
		{
			240,
			244
		};

		// Token: 0x04000412 RID: 1042
		private readonly global::System.IO.BinaryReader _reader;

		// Token: 0x04000413 RID: 1043
		private readonly global::System.Collections.Generic.List<global::Newtonsoft.Json.Bson.BsonReader.ContainerContext> _stack;

		// Token: 0x04000414 RID: 1044
		private byte[] _byteBuffer;

		// Token: 0x04000415 RID: 1045
		private char[] _charBuffer;

		// Token: 0x04000416 RID: 1046
		private global::Newtonsoft.Json.Bson.BsonType _currentElementType;

		// Token: 0x04000417 RID: 1047
		private global::Newtonsoft.Json.Bson.BsonReader.BsonReaderState _bsonReaderState;

		// Token: 0x04000418 RID: 1048
		private global::Newtonsoft.Json.Bson.BsonReader.ContainerContext _currentContext;

		// Token: 0x04000419 RID: 1049
		private bool _readRootValueAsArray;

		// Token: 0x0400041A RID: 1050
		private bool _jsonNet35BinaryCompatibility;

		// Token: 0x0400041B RID: 1051
		private global::System.DateTimeKind _dateTimeKindHandling;

		// Token: 0x020001E2 RID: 482
		private enum BsonReaderState
		{
			// Token: 0x0400085D RID: 2141
			Normal,
			// Token: 0x0400085E RID: 2142
			ReferenceStart,
			// Token: 0x0400085F RID: 2143
			ReferenceRef,
			// Token: 0x04000860 RID: 2144
			ReferenceId,
			// Token: 0x04000861 RID: 2145
			CodeWScopeStart,
			// Token: 0x04000862 RID: 2146
			CodeWScopeCode,
			// Token: 0x04000863 RID: 2147
			CodeWScopeScope,
			// Token: 0x04000864 RID: 2148
			CodeWScopeScopeObject,
			// Token: 0x04000865 RID: 2149
			CodeWScopeScopeEnd
		}

		// Token: 0x020001E3 RID: 483
		private class ContainerContext
		{
			// Token: 0x06001043 RID: 4163 RVA: 0x000479A5 File Offset: 0x00045BA5
			public ContainerContext(global::Newtonsoft.Json.Bson.BsonType type)
			{
				this.Type = type;
			}

			// Token: 0x04000866 RID: 2150
			public readonly global::Newtonsoft.Json.Bson.BsonType Type;

			// Token: 0x04000867 RID: 2151
			public int Length;

			// Token: 0x04000868 RID: 2152
			public int Position;
		}
	}
}
