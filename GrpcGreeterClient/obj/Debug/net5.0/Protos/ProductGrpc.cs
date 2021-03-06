// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Product.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcGreeterClient {
  public static partial class Producs
  {
    static readonly string __ServiceName = "Product.Producs";

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

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::GrpcGreeterClient.ProductResponseList> __Marshaller_Product_ProductResponseList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.ProductResponseList.Parser));

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcGreeterClient.ProductResponseList> __Method_GetProducts = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcGreeterClient.ProductResponseList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProducts",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Product_ProductResponseList);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcGreeterClient.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Producs</summary>
    public partial class ProducsClient : grpc::ClientBase<ProducsClient>
    {
      /// <summary>Creates a new client for Producs</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ProducsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Producs that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ProducsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ProducsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ProducsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcGreeterClient.ProductResponseList GetProducts(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProducts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcGreeterClient.ProductResponseList GetProducts(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProducts, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.ProductResponseList> GetProductsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.ProductResponseList> GetProductsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProducts, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ProducsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProducsClient(configuration);
      }
    }

  }
}
#endregion
