// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/index.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/index.proto</summary>
  public static partial class IndexReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/index.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IndexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9pbmRleC5wcm90bxIaZ29v",
            "Z2xlLmNsb3VkLmFpcGxhdGZvcm0udjEaH2dvb2dsZS9hcGkvZmllbGRfYmVo",
            "YXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aM2dvb2ds",
            "ZS9jbG91ZC9haXBsYXRmb3JtL3YxL2RlcGxveWVkX2luZGV4X3JlZi5wcm90",
            "bxocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxofZ29vZ2xlL3Byb3Rv",
            "YnVmL3RpbWVzdGFtcC5wcm90byKqBAoFSW5kZXgSEQoEbmFtZRgBIAEoCUID",
            "4EEDEhkKDGRpc3BsYXlfbmFtZRgCIAEoCUID4EECEhMKC2Rlc2NyaXB0aW9u",
            "GAMgASgJEiAKE21ldGFkYXRhX3NjaGVtYV91cmkYBCABKAlCA+BBBRIoCght",
            "ZXRhZGF0YRgGIAEoCzIWLmdvb2dsZS5wcm90b2J1Zi5WYWx1ZRJLChBkZXBs",
            "b3llZF9pbmRleGVzGAcgAygLMiwuZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0u",
            "djEuRGVwbG95ZWRJbmRleFJlZkID4EEDEgwKBGV0YWcYCCABKAkSPQoGbGFi",
            "ZWxzGAkgAygLMi0uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuSW5kZXgu",
            "TGFiZWxzRW50cnkSNAoLY3JlYXRlX3RpbWUYCiABKAsyGi5nb29nbGUucHJv",
            "dG9idWYuVGltZXN0YW1wQgPgQQMSNAoLdXBkYXRlX3RpbWUYCyABKAsyGi5n",
            "b29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMaLQoLTGFiZWxzRW50cnkS",
            "CwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ATpd6kFaCh9haXBsYXRm",
            "b3JtLmdvb2dsZWFwaXMuY29tL0luZGV4Ejdwcm9qZWN0cy97cHJvamVjdH0v",
            "bG9jYXRpb25zL3tsb2NhdGlvbn0vaW5kZXhlcy97aW5kZXh9Qs4BCh5jb20u",
            "Z29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjFCCkluZGV4UHJvdG9QAVpEZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9haXBs",
            "YXRmb3JtL3YxO2FpcGxhdGZvcm2qAhpHb29nbGUuQ2xvdWQuQUlQbGF0Zm9y",
            "bS5WMcoCGkdvb2dsZVxDbG91ZFxBSVBsYXRmb3JtXFYx6gIdR29vZ2xlOjpD",
            "bG91ZDo6QUlQbGF0Zm9ybTo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.DeployedIndexRefReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Index), global::Google.Cloud.AIPlatform.V1.Index.Parser, new[]{ "Name", "DisplayName", "Description", "MetadataSchemaUri", "Metadata", "DeployedIndexes", "Etag", "Labels", "CreateTime", "UpdateTime" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A representation of a collection of database items organized in a way that
  /// allows for approximate nearest neighbor (a.k.a ANN) algorithms search.
  /// </summary>
  public sealed partial class Index : pb::IMessage<Index>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Index> _parser = new pb::MessageParser<Index>(() => new Index());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Index> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.IndexReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Index() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Index(Index other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      metadataSchemaUri_ = other.metadataSchemaUri_;
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      deployedIndexes_ = other.deployedIndexes_.Clone();
      etag_ = other.etag_;
      labels_ = other.labels_.Clone();
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Index Clone() {
      return new Index(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The resource name of the Index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. The display name of the Index.
    /// The name can be up to 128 characters long and can be consist of any UTF-8
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// The description of the Index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata_schema_uri" field.</summary>
    public const int MetadataSchemaUriFieldNumber = 4;
    private string metadataSchemaUri_ = "";
    /// <summary>
    /// Immutable. Points to a YAML file stored on Google Cloud Storage describing additional
    /// information about the Index, that is specific to it. Unset if the Index
    /// does not have any additional information.
    /// The schema is defined as an OpenAPI 3.0.2 [Schema
    /// Object](https://github.com/OAI/OpenAPI-Specification/blob/main/versions/3.0.2.md#schemaObject).
    /// Note: The URI given on output will be immutable and probably different,
    /// including the URI scheme, than the one given on input. The output URI will
    /// point to a location where the user only has a read access.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MetadataSchemaUri {
      get { return metadataSchemaUri_; }
      set {
        metadataSchemaUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Value metadata_;
    /// <summary>
    /// An additional information about the Index; the schema of the metadata can
    /// be found in [metadata_schema][google.cloud.aiplatform.v1.Index.metadata_schema_uri].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Value Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "deployed_indexes" field.</summary>
    public const int DeployedIndexesFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Google.Cloud.AIPlatform.V1.DeployedIndexRef> _repeated_deployedIndexes_codec
        = pb::FieldCodec.ForMessage(58, global::Google.Cloud.AIPlatform.V1.DeployedIndexRef.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.DeployedIndexRef> deployedIndexes_ = new pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.DeployedIndexRef>();
    /// <summary>
    /// Output only. The pointers to DeployedIndexes created from this Index.
    /// An Index can be only deleted if all its DeployedIndexes had been undeployed
    /// first.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.DeployedIndexRef> DeployedIndexes {
      get { return deployedIndexes_; }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 8;
    private string etag_ = "";
    /// <summary>
    /// Used to perform consistent read-modify-write updates. If not set, a blind
    /// "overwrite" update happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 9;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 74);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// The labels with user-defined metadata to organize your Indexes.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    ///
    /// See https://goo.gl/xmQnxf for more information and examples of labels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 10;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this Index was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 11;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when this Index was most recently updated.
    /// This also includes any update to the contents of the Index.
    /// Note that Operations working on this Index may have their
    /// [Operations.metadata.generic_metadata.update_time]
    /// [google.cloud.aiplatform.v1.GenericOperationMetadata.update_time] a little after the value of this
    /// timestamp, yet that does not mean their results are not already reflected
    /// in the Index. Result of any successfully completed Operation on the Index
    /// is reflected in it.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Index);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Index other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (MetadataSchemaUri != other.MetadataSchemaUri) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if(!deployedIndexes_.Equals(other.deployedIndexes_)) return false;
      if (Etag != other.Etag) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (MetadataSchemaUri.Length != 0) hash ^= MetadataSchemaUri.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      hash ^= deployedIndexes_.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (MetadataSchemaUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(MetadataSchemaUri);
      }
      if (metadata_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Metadata);
      }
      deployedIndexes_.WriteTo(output, _repeated_deployedIndexes_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Etag);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (createTime_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(UpdateTime);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (MetadataSchemaUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(MetadataSchemaUri);
      }
      if (metadata_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Metadata);
      }
      deployedIndexes_.WriteTo(ref output, _repeated_deployedIndexes_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Etag);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (createTime_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(UpdateTime);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (MetadataSchemaUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MetadataSchemaUri);
      }
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      size += deployedIndexes_.CalculateSize(_repeated_deployedIndexes_codec);
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Index other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.MetadataSchemaUri.Length != 0) {
        MetadataSchemaUri = other.MetadataSchemaUri;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          Metadata = new global::Google.Protobuf.WellKnownTypes.Value();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      deployedIndexes_.Add(other.deployedIndexes_);
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      labels_.Add(other.labels_);
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            MetadataSchemaUri = input.ReadString();
            break;
          }
          case 50: {
            if (metadata_ == null) {
              Metadata = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 58: {
            deployedIndexes_.AddEntriesFrom(input, _repeated_deployedIndexes_codec);
            break;
          }
          case 66: {
            Etag = input.ReadString();
            break;
          }
          case 74: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 82: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 90: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            MetadataSchemaUri = input.ReadString();
            break;
          }
          case 50: {
            if (metadata_ == null) {
              Metadata = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 58: {
            deployedIndexes_.AddEntriesFrom(ref input, _repeated_deployedIndexes_codec);
            break;
          }
          case 66: {
            Etag = input.ReadString();
            break;
          }
          case 74: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 82: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 90: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
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
