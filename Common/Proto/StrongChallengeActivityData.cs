// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StrongChallengeActivityData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StrongChallengeActivityData.proto</summary>
  public static partial class StrongChallengeActivityDataReflection {

    #region Descriptor
    /// <summary>File descriptor for StrongChallengeActivityData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StrongChallengeActivityDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFTdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eURhdGEucHJvdG8aH1N0cm9uZ0No",
            "YWxsZW5nZUF2YXRhckRhdGEucHJvdG8imgEKG1N0cm9uZ0NoYWxsZW5nZUFj",
            "dGl2aXR5RGF0YRIQCghwYW5lbF9pZBgLIAEoDRIvCgtIRkRNRkNFSUdOTxgH",
            "IAEoCzIaLlN0cm9uZ0NoYWxsZW5nZUF2YXRhckRhdGESEQoJbWF4X3Njb3Jl",
            "GA8gASgNEhMKC09DRE5OT0ZDSUVCGAQgASgNEhAKCHN0YWdlX2lkGAYgASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.StrongChallengeAvatarDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StrongChallengeActivityData), global::EggLink.DanhengServer.Proto.StrongChallengeActivityData.Parser, new[]{ "PanelId", "HFDMFCEIGNO", "MaxScore", "OCDNNOFCIEB", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StrongChallengeActivityData : pb::IMessage<StrongChallengeActivityData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StrongChallengeActivityData> _parser = new pb::MessageParser<StrongChallengeActivityData>(() => new StrongChallengeActivityData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StrongChallengeActivityData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StrongChallengeActivityDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityData(StrongChallengeActivityData other) : this() {
      panelId_ = other.panelId_;
      hFDMFCEIGNO_ = other.hFDMFCEIGNO_ != null ? other.hFDMFCEIGNO_.Clone() : null;
      maxScore_ = other.maxScore_;
      oCDNNOFCIEB_ = other.oCDNNOFCIEB_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityData Clone() {
      return new StrongChallengeActivityData(this);
    }

    /// <summary>Field number for the "panel_id" field.</summary>
    public const int PanelIdFieldNumber = 11;
    private uint panelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PanelId {
      get { return panelId_; }
      set {
        panelId_ = value;
      }
    }

    /// <summary>Field number for the "HFDMFCEIGNO" field.</summary>
    public const int HFDMFCEIGNOFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData hFDMFCEIGNO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData HFDMFCEIGNO {
      get { return hFDMFCEIGNO_; }
      set {
        hFDMFCEIGNO_ = value;
      }
    }

    /// <summary>Field number for the "max_score" field.</summary>
    public const int MaxScoreFieldNumber = 15;
    private uint maxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxScore {
      get { return maxScore_; }
      set {
        maxScore_ = value;
      }
    }

    /// <summary>Field number for the "OCDNNOFCIEB" field.</summary>
    public const int OCDNNOFCIEBFieldNumber = 4;
    private uint oCDNNOFCIEB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OCDNNOFCIEB {
      get { return oCDNNOFCIEB_; }
      set {
        oCDNNOFCIEB_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 6;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StrongChallengeActivityData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StrongChallengeActivityData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PanelId != other.PanelId) return false;
      if (!object.Equals(HFDMFCEIGNO, other.HFDMFCEIGNO)) return false;
      if (MaxScore != other.MaxScore) return false;
      if (OCDNNOFCIEB != other.OCDNNOFCIEB) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PanelId != 0) hash ^= PanelId.GetHashCode();
      if (hFDMFCEIGNO_ != null) hash ^= HFDMFCEIGNO.GetHashCode();
      if (MaxScore != 0) hash ^= MaxScore.GetHashCode();
      if (OCDNNOFCIEB != 0) hash ^= OCDNNOFCIEB.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
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
      if (OCDNNOFCIEB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OCDNNOFCIEB);
      }
      if (StageId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StageId);
      }
      if (hFDMFCEIGNO_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(HFDMFCEIGNO);
      }
      if (PanelId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PanelId);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MaxScore);
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
      if (OCDNNOFCIEB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OCDNNOFCIEB);
      }
      if (StageId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StageId);
      }
      if (hFDMFCEIGNO_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(HFDMFCEIGNO);
      }
      if (PanelId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PanelId);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MaxScore);
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
      if (PanelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PanelId);
      }
      if (hFDMFCEIGNO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HFDMFCEIGNO);
      }
      if (MaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScore);
      }
      if (OCDNNOFCIEB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OCDNNOFCIEB);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StrongChallengeActivityData other) {
      if (other == null) {
        return;
      }
      if (other.PanelId != 0) {
        PanelId = other.PanelId;
      }
      if (other.hFDMFCEIGNO_ != null) {
        if (hFDMFCEIGNO_ == null) {
          HFDMFCEIGNO = new global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData();
        }
        HFDMFCEIGNO.MergeFrom(other.HFDMFCEIGNO);
      }
      if (other.MaxScore != 0) {
        MaxScore = other.MaxScore;
      }
      if (other.OCDNNOFCIEB != 0) {
        OCDNNOFCIEB = other.OCDNNOFCIEB;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
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
          case 32: {
            OCDNNOFCIEB = input.ReadUInt32();
            break;
          }
          case 48: {
            StageId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (hFDMFCEIGNO_ == null) {
              HFDMFCEIGNO = new global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData();
            }
            input.ReadMessage(HFDMFCEIGNO);
            break;
          }
          case 88: {
            PanelId = input.ReadUInt32();
            break;
          }
          case 120: {
            MaxScore = input.ReadUInt32();
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
          case 32: {
            OCDNNOFCIEB = input.ReadUInt32();
            break;
          }
          case 48: {
            StageId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (hFDMFCEIGNO_ == null) {
              HFDMFCEIGNO = new global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData();
            }
            input.ReadMessage(HFDMFCEIGNO);
            break;
          }
          case 88: {
            PanelId = input.ReadUInt32();
            break;
          }
          case 120: {
            MaxScore = input.ReadUInt32();
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