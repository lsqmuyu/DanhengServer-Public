// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RestoreWolfBroGameArchiveCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RestoreWolfBroGameArchiveCsReq.proto</summary>
  public static partial class RestoreWolfBroGameArchiveCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for RestoreWolfBroGameArchiveCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RestoreWolfBroGameArchiveCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRSZXN0b3JlV29sZkJyb0dhbWVBcmNoaXZlQ3NSZXEucHJvdG8aEE1vdGlv",
            "bkluZm8ucHJvdG8aFEdyb3VwU3RhdGVJbmZvLnByb3RvIokBCh5SZXN0b3Jl",
            "V29sZkJyb0dhbWVBcmNoaXZlQ3NSZXESGwoGbW90aW9uGA4gASgLMgsuTW90",
            "aW9uSW5mbxIpChBncm91cF9zdGF0ZV9pbmZvGAQgASgLMg8uR3JvdXBTdGF0",
            "ZUluZm8SEwoLQkVQQklBQkpJTksYAyABKAgSCgoCaWQYCyABKA1CHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.GroupStateInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RestoreWolfBroGameArchiveCsReq), global::EggLink.DanhengServer.Proto.RestoreWolfBroGameArchiveCsReq.Parser, new[]{ "Motion", "GroupStateInfo", "BEPBIABJINK", "Id" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RestoreWolfBroGameArchiveCsReq : pb::IMessage<RestoreWolfBroGameArchiveCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RestoreWolfBroGameArchiveCsReq> _parser = new pb::MessageParser<RestoreWolfBroGameArchiveCsReq>(() => new RestoreWolfBroGameArchiveCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RestoreWolfBroGameArchiveCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RestoreWolfBroGameArchiveCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RestoreWolfBroGameArchiveCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RestoreWolfBroGameArchiveCsReq(RestoreWolfBroGameArchiveCsReq other) : this() {
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      groupStateInfo_ = other.groupStateInfo_ != null ? other.groupStateInfo_.Clone() : null;
      bEPBIABJINK_ = other.bEPBIABJINK_;
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RestoreWolfBroGameArchiveCsReq Clone() {
      return new RestoreWolfBroGameArchiveCsReq(this);
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    /// <summary>Field number for the "group_state_info" field.</summary>
    public const int GroupStateInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.GroupStateInfo groupStateInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GroupStateInfo GroupStateInfo {
      get { return groupStateInfo_; }
      set {
        groupStateInfo_ = value;
      }
    }

    /// <summary>Field number for the "BEPBIABJINK" field.</summary>
    public const int BEPBIABJINKFieldNumber = 3;
    private bool bEPBIABJINK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BEPBIABJINK {
      get { return bEPBIABJINK_; }
      set {
        bEPBIABJINK_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 11;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RestoreWolfBroGameArchiveCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RestoreWolfBroGameArchiveCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Motion, other.Motion)) return false;
      if (!object.Equals(GroupStateInfo, other.GroupStateInfo)) return false;
      if (BEPBIABJINK != other.BEPBIABJINK) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (motion_ != null) hash ^= Motion.GetHashCode();
      if (groupStateInfo_ != null) hash ^= GroupStateInfo.GetHashCode();
      if (BEPBIABJINK != false) hash ^= BEPBIABJINK.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
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
      if (BEPBIABJINK != false) {
        output.WriteRawTag(24);
        output.WriteBool(BEPBIABJINK);
      }
      if (groupStateInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GroupStateInfo);
      }
      if (Id != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Id);
      }
      if (motion_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Motion);
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
      if (BEPBIABJINK != false) {
        output.WriteRawTag(24);
        output.WriteBool(BEPBIABJINK);
      }
      if (groupStateInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GroupStateInfo);
      }
      if (Id != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Id);
      }
      if (motion_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Motion);
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
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (groupStateInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GroupStateInfo);
      }
      if (BEPBIABJINK != false) {
        size += 1 + 1;
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RestoreWolfBroGameArchiveCsReq other) {
      if (other == null) {
        return;
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
      }
      if (other.groupStateInfo_ != null) {
        if (groupStateInfo_ == null) {
          GroupStateInfo = new global::EggLink.DanhengServer.Proto.GroupStateInfo();
        }
        GroupStateInfo.MergeFrom(other.GroupStateInfo);
      }
      if (other.BEPBIABJINK != false) {
        BEPBIABJINK = other.BEPBIABJINK;
      }
      if (other.Id != 0) {
        Id = other.Id;
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
          case 24: {
            BEPBIABJINK = input.ReadBool();
            break;
          }
          case 34: {
            if (groupStateInfo_ == null) {
              GroupStateInfo = new global::EggLink.DanhengServer.Proto.GroupStateInfo();
            }
            input.ReadMessage(GroupStateInfo);
            break;
          }
          case 88: {
            Id = input.ReadUInt32();
            break;
          }
          case 114: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
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
          case 24: {
            BEPBIABJINK = input.ReadBool();
            break;
          }
          case 34: {
            if (groupStateInfo_ == null) {
              GroupStateInfo = new global::EggLink.DanhengServer.Proto.GroupStateInfo();
            }
            input.ReadMessage(GroupStateInfo);
            break;
          }
          case 88: {
            Id = input.ReadUInt32();
            break;
          }
          case 114: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
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