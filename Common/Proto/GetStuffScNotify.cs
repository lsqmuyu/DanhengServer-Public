// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetStuffScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetStuffScNotify.proto</summary>
  public static partial class GetStuffScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GetStuffScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetStuffScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZHZXRTdHVmZlNjTm90aWZ5LnByb3RvGhJHZXRTdHVmZlR5cGUucHJvdG8i",
            "SwoQR2V0U3R1ZmZTY05vdGlmeRIiCgtDSUNQTkJDTUhPQxgBIAEoDjINLkdl",
            "dFN0dWZmVHlwZRITCgtESUFESFBBSExHQxgEIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GetStuffTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetStuffScNotify), global::EggLink.DanhengServer.Proto.GetStuffScNotify.Parser, new[]{ "CICPNBCMHOC", "DIADHPAHLGC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetStuffScNotify : pb::IMessage<GetStuffScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetStuffScNotify> _parser = new pb::MessageParser<GetStuffScNotify>(() => new GetStuffScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetStuffScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetStuffScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetStuffScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetStuffScNotify(GetStuffScNotify other) : this() {
      cICPNBCMHOC_ = other.cICPNBCMHOC_;
      dIADHPAHLGC_ = other.dIADHPAHLGC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetStuffScNotify Clone() {
      return new GetStuffScNotify(this);
    }

    /// <summary>Field number for the "CICPNBCMHOC" field.</summary>
    public const int CICPNBCMHOCFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.GetStuffType cICPNBCMHOC_ = global::EggLink.DanhengServer.Proto.GetStuffType.Unknow;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GetStuffType CICPNBCMHOC {
      get { return cICPNBCMHOC_; }
      set {
        cICPNBCMHOC_ = value;
      }
    }

    /// <summary>Field number for the "DIADHPAHLGC" field.</summary>
    public const int DIADHPAHLGCFieldNumber = 4;
    private uint dIADHPAHLGC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DIADHPAHLGC {
      get { return dIADHPAHLGC_; }
      set {
        dIADHPAHLGC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetStuffScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetStuffScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CICPNBCMHOC != other.CICPNBCMHOC) return false;
      if (DIADHPAHLGC != other.DIADHPAHLGC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CICPNBCMHOC != global::EggLink.DanhengServer.Proto.GetStuffType.Unknow) hash ^= CICPNBCMHOC.GetHashCode();
      if (DIADHPAHLGC != 0) hash ^= DIADHPAHLGC.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CICPNBCMHOC != global::EggLink.DanhengServer.Proto.GetStuffType.Unknow) {
        output.WriteRawTag(8);
        output.WriteEnum((int) CICPNBCMHOC);
      }
      if (DIADHPAHLGC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DIADHPAHLGC);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CICPNBCMHOC != global::EggLink.DanhengServer.Proto.GetStuffType.Unknow) {
        output.WriteRawTag(8);
        output.WriteEnum((int) CICPNBCMHOC);
      }
      if (DIADHPAHLGC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DIADHPAHLGC);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CICPNBCMHOC != global::EggLink.DanhengServer.Proto.GetStuffType.Unknow) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CICPNBCMHOC);
      }
      if (DIADHPAHLGC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DIADHPAHLGC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetStuffScNotify other) {
      if (other == null) {
        return;
      }
      if (other.CICPNBCMHOC != global::EggLink.DanhengServer.Proto.GetStuffType.Unknow) {
        CICPNBCMHOC = other.CICPNBCMHOC;
      }
      if (other.DIADHPAHLGC != 0) {
        DIADHPAHLGC = other.DIADHPAHLGC;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CICPNBCMHOC = (global::EggLink.DanhengServer.Proto.GetStuffType) input.ReadEnum();
            break;
          }
          case 32: {
            DIADHPAHLGC = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            CICPNBCMHOC = (global::EggLink.DanhengServer.Proto.GetStuffType) input.ReadEnum();
            break;
          }
          case 32: {
            DIADHPAHLGC = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code