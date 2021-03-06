// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: api/api.proto
// </auto-generated>
// Original file comments:
// api.proto
// Fully specifies the client-server API endpoints.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DF.Game.API.API {
  /// <summary>
  /// DownFlux surfaces client-server API endpoints to play the game.
  /// </summary>
  public static partial class DownFlux
  {
    static readonly string __ServiceName = "game.api.api.DownFlux";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::DF.Game.API.API.AddClientRequest> __Marshaller_game_api_api_AddClientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.AddClientRequest.Parser));
    static readonly grpc::Marshaller<global::DF.Game.API.API.AddClientResponse> __Marshaller_game_api_api_AddClientResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.AddClientResponse.Parser));
    static readonly grpc::Marshaller<global::DF.Game.API.API.AttackRequest> __Marshaller_game_api_api_AttackRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.AttackRequest.Parser));
    static readonly grpc::Marshaller<global::DF.Game.API.API.AttackResponse> __Marshaller_game_api_api_AttackResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.AttackResponse.Parser));
    static readonly grpc::Marshaller<global::DF.Game.API.API.MoveRequest> __Marshaller_game_api_api_MoveRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.MoveRequest.Parser));
    static readonly grpc::Marshaller<global::DF.Game.API.API.MoveResponse> __Marshaller_game_api_api_MoveResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.MoveResponse.Parser));
    static readonly grpc::Marshaller<global::DF.Game.API.API.StreamDataRequest> __Marshaller_game_api_api_StreamDataRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.StreamDataRequest.Parser));
    static readonly grpc::Marshaller<global::DF.Game.API.API.StreamDataResponse> __Marshaller_game_api_api_StreamDataResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.StreamDataResponse.Parser));
    static readonly grpc::Marshaller<global::DF.Game.API.API.GetStatusRequest> __Marshaller_game_api_api_GetStatusRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.GetStatusRequest.Parser));
    static readonly grpc::Marshaller<global::DF.Game.API.API.GetStatusResponse> __Marshaller_game_api_api_GetStatusResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DF.Game.API.API.GetStatusResponse.Parser));

    static readonly grpc::Method<global::DF.Game.API.API.AddClientRequest, global::DF.Game.API.API.AddClientResponse> __Method_AddClient = new grpc::Method<global::DF.Game.API.API.AddClientRequest, global::DF.Game.API.API.AddClientResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddClient",
        __Marshaller_game_api_api_AddClientRequest,
        __Marshaller_game_api_api_AddClientResponse);

    static readonly grpc::Method<global::DF.Game.API.API.AttackRequest, global::DF.Game.API.API.AttackResponse> __Method_Attack = new grpc::Method<global::DF.Game.API.API.AttackRequest, global::DF.Game.API.API.AttackResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Attack",
        __Marshaller_game_api_api_AttackRequest,
        __Marshaller_game_api_api_AttackResponse);

    static readonly grpc::Method<global::DF.Game.API.API.MoveRequest, global::DF.Game.API.API.MoveResponse> __Method_Move = new grpc::Method<global::DF.Game.API.API.MoveRequest, global::DF.Game.API.API.MoveResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Move",
        __Marshaller_game_api_api_MoveRequest,
        __Marshaller_game_api_api_MoveResponse);

    static readonly grpc::Method<global::DF.Game.API.API.StreamDataRequest, global::DF.Game.API.API.StreamDataResponse> __Method_StreamData = new grpc::Method<global::DF.Game.API.API.StreamDataRequest, global::DF.Game.API.API.StreamDataResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "StreamData",
        __Marshaller_game_api_api_StreamDataRequest,
        __Marshaller_game_api_api_StreamDataResponse);

    static readonly grpc::Method<global::DF.Game.API.API.GetStatusRequest, global::DF.Game.API.API.GetStatusResponse> __Method_GetStatus = new grpc::Method<global::DF.Game.API.API.GetStatusRequest, global::DF.Game.API.API.GetStatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStatus",
        __Marshaller_game_api_api_GetStatusRequest,
        __Marshaller_game_api_api_GetStatusResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DF.Game.API.API.ApiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DownFlux</summary>
    [grpc::BindServiceMethod(typeof(DownFlux), "BindService")]
    public abstract partial class DownFluxBase
    {
      /// <summary>
      /// AddClient instructs the server to create a new client object, and
      /// represents a new player joining the game.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::DF.Game.API.API.AddClientResponse> AddClient(global::DF.Game.API.API.AddClientRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DF.Game.API.API.AttackResponse> Attack(global::DF.Game.API.API.AttackRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Move represents a player's intent to move an entity to the specified
      /// target location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::DF.Game.API.API.MoveResponse> Move(global::DF.Game.API.API.MoveRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// StreamData is a persistent client-server connection communicating the
      /// game state. See https://docs.downflux.com/design/network.html for more
      /// details on the specific format and intent of the messages.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task StreamData(global::DF.Game.API.API.StreamDataRequest request, grpc::IServerStreamWriter<global::DF.Game.API.API.StreamDataResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// GetStatus returns the internal game server status. This is useful for the
      /// client to know when the server has formally started processing ticks.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::DF.Game.API.API.GetStatusResponse> GetStatus(global::DF.Game.API.API.GetStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DownFlux</summary>
    public partial class DownFluxClient : grpc::ClientBase<DownFluxClient>
    {
      /// <summary>Creates a new client for DownFlux</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DownFluxClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DownFlux that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DownFluxClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DownFluxClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DownFluxClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// AddClient instructs the server to create a new client object, and
      /// represents a new player joining the game.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DF.Game.API.API.AddClientResponse AddClient(global::DF.Game.API.API.AddClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// AddClient instructs the server to create a new client object, and
      /// represents a new player joining the game.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DF.Game.API.API.AddClientResponse AddClient(global::DF.Game.API.API.AddClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddClient, null, options, request);
      }
      /// <summary>
      /// AddClient instructs the server to create a new client object, and
      /// represents a new player joining the game.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DF.Game.API.API.AddClientResponse> AddClientAsync(global::DF.Game.API.API.AddClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddClientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// AddClient instructs the server to create a new client object, and
      /// represents a new player joining the game.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DF.Game.API.API.AddClientResponse> AddClientAsync(global::DF.Game.API.API.AddClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddClient, null, options, request);
      }
      public virtual global::DF.Game.API.API.AttackResponse Attack(global::DF.Game.API.API.AttackRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Attack(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DF.Game.API.API.AttackResponse Attack(global::DF.Game.API.API.AttackRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Attack, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DF.Game.API.API.AttackResponse> AttackAsync(global::DF.Game.API.API.AttackRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AttackAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DF.Game.API.API.AttackResponse> AttackAsync(global::DF.Game.API.API.AttackRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Attack, null, options, request);
      }
      /// <summary>
      /// Move represents a player's intent to move an entity to the specified
      /// target location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DF.Game.API.API.MoveResponse Move(global::DF.Game.API.API.MoveRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Move(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Move represents a player's intent to move an entity to the specified
      /// target location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DF.Game.API.API.MoveResponse Move(global::DF.Game.API.API.MoveRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Move, null, options, request);
      }
      /// <summary>
      /// Move represents a player's intent to move an entity to the specified
      /// target location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DF.Game.API.API.MoveResponse> MoveAsync(global::DF.Game.API.API.MoveRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MoveAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Move represents a player's intent to move an entity to the specified
      /// target location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DF.Game.API.API.MoveResponse> MoveAsync(global::DF.Game.API.API.MoveRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Move, null, options, request);
      }
      /// <summary>
      /// StreamData is a persistent client-server connection communicating the
      /// game state. See https://docs.downflux.com/design/network.html for more
      /// details on the specific format and intent of the messages.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::DF.Game.API.API.StreamDataResponse> StreamData(global::DF.Game.API.API.StreamDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// StreamData is a persistent client-server connection communicating the
      /// game state. See https://docs.downflux.com/design/network.html for more
      /// details on the specific format and intent of the messages.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::DF.Game.API.API.StreamDataResponse> StreamData(global::DF.Game.API.API.StreamDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_StreamData, null, options, request);
      }
      /// <summary>
      /// GetStatus returns the internal game server status. This is useful for the
      /// client to know when the server has formally started processing ticks.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DF.Game.API.API.GetStatusResponse GetStatus(global::DF.Game.API.API.GetStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetStatus returns the internal game server status. This is useful for the
      /// client to know when the server has formally started processing ticks.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DF.Game.API.API.GetStatusResponse GetStatus(global::DF.Game.API.API.GetStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStatus, null, options, request);
      }
      /// <summary>
      /// GetStatus returns the internal game server status. This is useful for the
      /// client to know when the server has formally started processing ticks.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DF.Game.API.API.GetStatusResponse> GetStatusAsync(global::DF.Game.API.API.GetStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetStatus returns the internal game server status. This is useful for the
      /// client to know when the server has formally started processing ticks.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DF.Game.API.API.GetStatusResponse> GetStatusAsync(global::DF.Game.API.API.GetStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStatus, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DownFluxClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DownFluxClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DownFluxBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddClient, serviceImpl.AddClient)
          .AddMethod(__Method_Attack, serviceImpl.Attack)
          .AddMethod(__Method_Move, serviceImpl.Move)
          .AddMethod(__Method_StreamData, serviceImpl.StreamData)
          .AddMethod(__Method_GetStatus, serviceImpl.GetStatus).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DownFluxBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddClient, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DF.Game.API.API.AddClientRequest, global::DF.Game.API.API.AddClientResponse>(serviceImpl.AddClient));
      serviceBinder.AddMethod(__Method_Attack, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DF.Game.API.API.AttackRequest, global::DF.Game.API.API.AttackResponse>(serviceImpl.Attack));
      serviceBinder.AddMethod(__Method_Move, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DF.Game.API.API.MoveRequest, global::DF.Game.API.API.MoveResponse>(serviceImpl.Move));
      serviceBinder.AddMethod(__Method_StreamData, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::DF.Game.API.API.StreamDataRequest, global::DF.Game.API.API.StreamDataResponse>(serviceImpl.StreamData));
      serviceBinder.AddMethod(__Method_GetStatus, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DF.Game.API.API.GetStatusRequest, global::DF.Game.API.API.GetStatusResponse>(serviceImpl.GetStatus));
    }

  }
}
#endregion
