// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NNLHJAIPCBO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NNLHJAIPCBO.proto</summary>
  public static partial class NNLHJAIPCBOReflection {

    #region Descriptor
    /// <summary>File descriptor for NNLHJAIPCBO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NNLHJAIPCBOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOTkxISkFJUENCTy5wcm90byJeCgtOTkxISkFJUENCTxITCgtBTk5KUExG",
            "Q0JNQhgPIAEoDRITCgtQREJCQUVJRUpKQhgFIAEoDRITCgtPSUhERVBNREpC",
            "SRgIIAEoDRIQCghwYW5lbF9pZBgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NNLHJAIPCBO), global::EggLink.DanhengServer.Proto.NNLHJAIPCBO.Parser, new[]{ "ANNJPLFCBMB", "PDBBAEIEJJB", "OIHDEPMDJBI", "PanelId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NNLHJAIPCBO : pb::IMessage<NNLHJAIPCBO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NNLHJAIPCBO> _parser = new pb::MessageParser<NNLHJAIPCBO>(() => new NNLHJAIPCBO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NNLHJAIPCBO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NNLHJAIPCBOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NNLHJAIPCBO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NNLHJAIPCBO(NNLHJAIPCBO other) : this() {
      aNNJPLFCBMB_ = other.aNNJPLFCBMB_;
      pDBBAEIEJJB_ = other.pDBBAEIEJJB_;
      oIHDEPMDJBI_ = other.oIHDEPMDJBI_;
      panelId_ = other.panelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NNLHJAIPCBO Clone() {
      return new NNLHJAIPCBO(this);
    }

    /// <summary>Field number for the "ANNJPLFCBMB" field.</summary>
    public const int ANNJPLFCBMBFieldNumber = 15;
    private uint aNNJPLFCBMB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ANNJPLFCBMB {
      get { return aNNJPLFCBMB_; }
      set {
        aNNJPLFCBMB_ = value;
      }
    }

    /// <summary>Field number for the "PDBBAEIEJJB" field.</summary>
    public const int PDBBAEIEJJBFieldNumber = 5;
    private uint pDBBAEIEJJB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PDBBAEIEJJB {
      get { return pDBBAEIEJJB_; }
      set {
        pDBBAEIEJJB_ = value;
      }
    }

    /// <summary>Field number for the "OIHDEPMDJBI" field.</summary>
    public const int OIHDEPMDJBIFieldNumber = 8;
    private uint oIHDEPMDJBI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OIHDEPMDJBI {
      get { return oIHDEPMDJBI_; }
      set {
        oIHDEPMDJBI_ = value;
      }
    }

    /// <summary>Field number for the "panel_id" field.</summary>
    public const int PanelIdFieldNumber = 4;
    private uint panelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PanelId {
      get { return panelId_; }
      set {
        panelId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NNLHJAIPCBO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NNLHJAIPCBO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ANNJPLFCBMB != other.ANNJPLFCBMB) return false;
      if (PDBBAEIEJJB != other.PDBBAEIEJJB) return false;
      if (OIHDEPMDJBI != other.OIHDEPMDJBI) return false;
      if (PanelId != other.PanelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ANNJPLFCBMB != 0) hash ^= ANNJPLFCBMB.GetHashCode();
      if (PDBBAEIEJJB != 0) hash ^= PDBBAEIEJJB.GetHashCode();
      if (OIHDEPMDJBI != 0) hash ^= OIHDEPMDJBI.GetHashCode();
      if (PanelId != 0) hash ^= PanelId.GetHashCode();
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
      if (PanelId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PanelId);
      }
      if (PDBBAEIEJJB != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PDBBAEIEJJB);
      }
      if (OIHDEPMDJBI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OIHDEPMDJBI);
      }
      if (ANNJPLFCBMB != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ANNJPLFCBMB);
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
      if (PanelId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PanelId);
      }
      if (PDBBAEIEJJB != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PDBBAEIEJJB);
      }
      if (OIHDEPMDJBI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OIHDEPMDJBI);
      }
      if (ANNJPLFCBMB != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ANNJPLFCBMB);
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
      if (ANNJPLFCBMB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ANNJPLFCBMB);
      }
      if (PDBBAEIEJJB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PDBBAEIEJJB);
      }
      if (OIHDEPMDJBI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OIHDEPMDJBI);
      }
      if (PanelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PanelId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NNLHJAIPCBO other) {
      if (other == null) {
        return;
      }
      if (other.ANNJPLFCBMB != 0) {
        ANNJPLFCBMB = other.ANNJPLFCBMB;
      }
      if (other.PDBBAEIEJJB != 0) {
        PDBBAEIEJJB = other.PDBBAEIEJJB;
      }
      if (other.OIHDEPMDJBI != 0) {
        OIHDEPMDJBI = other.OIHDEPMDJBI;
      }
      if (other.PanelId != 0) {
        PanelId = other.PanelId;
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
            PanelId = input.ReadUInt32();
            break;
          }
          case 40: {
            PDBBAEIEJJB = input.ReadUInt32();
            break;
          }
          case 64: {
            OIHDEPMDJBI = input.ReadUInt32();
            break;
          }
          case 120: {
            ANNJPLFCBMB = input.ReadUInt32();
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
            PanelId = input.ReadUInt32();
            break;
          }
          case 40: {
            PDBBAEIEJJB = input.ReadUInt32();
            break;
          }
          case 64: {
            OIHDEPMDJBI = input.ReadUInt32();
            break;
          }
          case 120: {
            ANNJPLFCBMB = input.ReadUInt32();
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