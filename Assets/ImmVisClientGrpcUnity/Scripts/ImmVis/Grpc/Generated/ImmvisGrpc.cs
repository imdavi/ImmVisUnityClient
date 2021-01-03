// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: immvis.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class ImmVisPandas
{
  static readonly string __ServiceName = "ImmVisPandas";

  static readonly grpc::Marshaller<global::Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Empty.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::AvailableDatasetsList> __Marshaller_AvailableDatasetsList = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AvailableDatasetsList.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::LoadDatasetRequest> __Marshaller_LoadDatasetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::LoadDatasetRequest.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::DatasetMetadata> __Marshaller_DatasetMetadata = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DatasetMetadata.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::GetNormalisedDatasetRequest> __Marshaller_GetNormalisedDatasetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GetNormalisedDatasetRequest.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::NormalisedDataset> __Marshaller_NormalisedDataset = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NormalisedDataset.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::GenerateDatasetRequest> __Marshaller_GenerateDatasetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GenerateDatasetRequest.Parser.ParseFrom);

  static readonly grpc::Method<global::Empty, global::AvailableDatasetsList> __Method_ListAvailableDatasets = new grpc::Method<global::Empty, global::AvailableDatasetsList>(
      grpc::MethodType.Unary,
      __ServiceName,
      "ListAvailableDatasets",
      __Marshaller_Empty,
      __Marshaller_AvailableDatasetsList);

  static readonly grpc::Method<global::LoadDatasetRequest, global::DatasetMetadata> __Method_LoadDataset = new grpc::Method<global::LoadDatasetRequest, global::DatasetMetadata>(
      grpc::MethodType.Unary,
      __ServiceName,
      "LoadDataset",
      __Marshaller_LoadDatasetRequest,
      __Marshaller_DatasetMetadata);

  static readonly grpc::Method<global::GetNormalisedDatasetRequest, global::NormalisedDataset> __Method_GetNormalisedDataset = new grpc::Method<global::GetNormalisedDatasetRequest, global::NormalisedDataset>(
      grpc::MethodType.Unary,
      __ServiceName,
      "GetNormalisedDataset",
      __Marshaller_GetNormalisedDatasetRequest,
      __Marshaller_NormalisedDataset);

  static readonly grpc::Method<global::GenerateDatasetRequest, global::DatasetMetadata> __Method_GenerateDataset = new grpc::Method<global::GenerateDatasetRequest, global::DatasetMetadata>(
      grpc::MethodType.Unary,
      __ServiceName,
      "GenerateDataset",
      __Marshaller_GenerateDatasetRequest,
      __Marshaller_DatasetMetadata);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::ImmvisReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of ImmVisPandas</summary>
  [grpc::BindServiceMethod(typeof(ImmVisPandas), "BindService")]
  public abstract partial class ImmVisPandasBase
  {
    public virtual global::System.Threading.Tasks.Task<global::AvailableDatasetsList> ListAvailableDatasets(global::Empty request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    public virtual global::System.Threading.Tasks.Task<global::DatasetMetadata> LoadDataset(global::LoadDatasetRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    public virtual global::System.Threading.Tasks.Task<global::NormalisedDataset> GetNormalisedDataset(global::GetNormalisedDatasetRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    public virtual global::System.Threading.Tasks.Task<global::DatasetMetadata> GenerateDataset(global::GenerateDatasetRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Client for ImmVisPandas</summary>
  public partial class ImmVisPandasClient : grpc::ClientBase<ImmVisPandasClient>
  {
    /// <summary>Creates a new client for ImmVisPandas</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    public ImmVisPandasClient(grpc::ChannelBase channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for ImmVisPandas that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    public ImmVisPandasClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    protected ImmVisPandasClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    protected ImmVisPandasClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    public virtual global::AvailableDatasetsList ListAvailableDatasets(global::Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return ListAvailableDatasets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::AvailableDatasetsList ListAvailableDatasets(global::Empty request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_ListAvailableDatasets, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::AvailableDatasetsList> ListAvailableDatasetsAsync(global::Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return ListAvailableDatasetsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::AvailableDatasetsList> ListAvailableDatasetsAsync(global::Empty request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_ListAvailableDatasets, null, options, request);
    }
    public virtual global::DatasetMetadata LoadDataset(global::LoadDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return LoadDataset(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::DatasetMetadata LoadDataset(global::LoadDatasetRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_LoadDataset, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::DatasetMetadata> LoadDatasetAsync(global::LoadDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return LoadDatasetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::DatasetMetadata> LoadDatasetAsync(global::LoadDatasetRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_LoadDataset, null, options, request);
    }
    public virtual global::NormalisedDataset GetNormalisedDataset(global::GetNormalisedDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return GetNormalisedDataset(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::NormalisedDataset GetNormalisedDataset(global::GetNormalisedDatasetRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_GetNormalisedDataset, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::NormalisedDataset> GetNormalisedDatasetAsync(global::GetNormalisedDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return GetNormalisedDatasetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::NormalisedDataset> GetNormalisedDatasetAsync(global::GetNormalisedDatasetRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_GetNormalisedDataset, null, options, request);
    }
    public virtual global::DatasetMetadata GenerateDataset(global::GenerateDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return GenerateDataset(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::DatasetMetadata GenerateDataset(global::GenerateDatasetRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_GenerateDataset, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::DatasetMetadata> GenerateDatasetAsync(global::GenerateDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return GenerateDatasetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::DatasetMetadata> GenerateDatasetAsync(global::GenerateDatasetRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_GenerateDataset, null, options, request);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    protected override ImmVisPandasClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new ImmVisPandasClient(configuration);
    }
  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static grpc::ServerServiceDefinition BindService(ImmVisPandasBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_ListAvailableDatasets, serviceImpl.ListAvailableDatasets)
        .AddMethod(__Method_LoadDataset, serviceImpl.LoadDataset)
        .AddMethod(__Method_GetNormalisedDataset, serviceImpl.GetNormalisedDataset)
        .AddMethod(__Method_GenerateDataset, serviceImpl.GenerateDataset).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static void BindService(grpc::ServiceBinderBase serviceBinder, ImmVisPandasBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_ListAvailableDatasets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Empty, global::AvailableDatasetsList>(serviceImpl.ListAvailableDatasets));
    serviceBinder.AddMethod(__Method_LoadDataset, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LoadDatasetRequest, global::DatasetMetadata>(serviceImpl.LoadDataset));
    serviceBinder.AddMethod(__Method_GetNormalisedDataset, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GetNormalisedDatasetRequest, global::NormalisedDataset>(serviceImpl.GetNormalisedDataset));
    serviceBinder.AddMethod(__Method_GenerateDataset, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GenerateDatasetRequest, global::DatasetMetadata>(serviceImpl.GenerateDataset));
  }

}
#endregion
