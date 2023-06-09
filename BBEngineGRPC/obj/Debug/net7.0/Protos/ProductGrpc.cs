// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Product.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BBEngineGRPC.Protos {
  public static partial class Product
  {
    static readonly string __ServiceName = "product.Product";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BBEngineGRPC.Protos.ProductRequest> __Marshaller_product_ProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BBEngineGRPC.Protos.ProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BBEngineGRPC.Protos.ProductListItem> __Marshaller_product_ProductListItem = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BBEngineGRPC.Protos.ProductListItem.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BBEngineGRPC.Protos.ProductRequestEmpty> __Marshaller_product_ProductRequestEmpty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BBEngineGRPC.Protos.ProductRequestEmpty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BBEngineGRPC.Protos.ProductList> __Marshaller_product_ProductList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BBEngineGRPC.Protos.ProductList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BBEngineGRPC.Protos.CreateProductRequest> __Marshaller_product_CreateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BBEngineGRPC.Protos.CreateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BBEngineGRPC.Protos.ResponseMessage> __Marshaller_product_ResponseMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BBEngineGRPC.Protos.ResponseMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BBEngineGRPC.Protos.UpdateProductRequest> __Marshaller_product_UpdateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BBEngineGRPC.Protos.UpdateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BBEngineGRPC.Protos.DeleteProductRequest> __Marshaller_product_DeleteProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BBEngineGRPC.Protos.DeleteProductRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BBEngineGRPC.Protos.ProductRequest, global::BBEngineGRPC.Protos.ProductListItem> __Method_FindProduct = new grpc::Method<global::BBEngineGRPC.Protos.ProductRequest, global::BBEngineGRPC.Protos.ProductListItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FindProduct",
        __Marshaller_product_ProductRequest,
        __Marshaller_product_ProductListItem);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BBEngineGRPC.Protos.ProductRequestEmpty, global::BBEngineGRPC.Protos.ProductListItem> __Method_GetAllProduct = new grpc::Method<global::BBEngineGRPC.Protos.ProductRequestEmpty, global::BBEngineGRPC.Protos.ProductListItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllProduct",
        __Marshaller_product_ProductRequestEmpty,
        __Marshaller_product_ProductListItem);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BBEngineGRPC.Protos.ProductRequest, global::BBEngineGRPC.Protos.ProductList> __Method_GetProductById = new grpc::Method<global::BBEngineGRPC.Protos.ProductRequest, global::BBEngineGRPC.Protos.ProductList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductById",
        __Marshaller_product_ProductRequest,
        __Marshaller_product_ProductList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BBEngineGRPC.Protos.CreateProductRequest, global::BBEngineGRPC.Protos.ResponseMessage> __Method_CreateProduct = new grpc::Method<global::BBEngineGRPC.Protos.CreateProductRequest, global::BBEngineGRPC.Protos.ResponseMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateProduct",
        __Marshaller_product_CreateProductRequest,
        __Marshaller_product_ResponseMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BBEngineGRPC.Protos.UpdateProductRequest, global::BBEngineGRPC.Protos.ResponseMessage> __Method_UpdateProduct = new grpc::Method<global::BBEngineGRPC.Protos.UpdateProductRequest, global::BBEngineGRPC.Protos.ResponseMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProduct",
        __Marshaller_product_UpdateProductRequest,
        __Marshaller_product_ResponseMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BBEngineGRPC.Protos.DeleteProductRequest, global::BBEngineGRPC.Protos.ResponseMessage> __Method_DeleteProduct = new grpc::Method<global::BBEngineGRPC.Protos.DeleteProductRequest, global::BBEngineGRPC.Protos.ResponseMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteProduct",
        __Marshaller_product_DeleteProductRequest,
        __Marshaller_product_ResponseMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BBEngineGRPC.Protos.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Product</summary>
    [grpc::BindServiceMethod(typeof(Product), "BindService")]
    public abstract partial class ProductBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BBEngineGRPC.Protos.ProductListItem> FindProduct(global::BBEngineGRPC.Protos.ProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BBEngineGRPC.Protos.ProductListItem> GetAllProduct(global::BBEngineGRPC.Protos.ProductRequestEmpty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BBEngineGRPC.Protos.ProductList> GetProductById(global::BBEngineGRPC.Protos.ProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BBEngineGRPC.Protos.ResponseMessage> CreateProduct(global::BBEngineGRPC.Protos.CreateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BBEngineGRPC.Protos.ResponseMessage> UpdateProduct(global::BBEngineGRPC.Protos.UpdateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BBEngineGRPC.Protos.ResponseMessage> DeleteProduct(global::BBEngineGRPC.Protos.DeleteProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_FindProduct, serviceImpl.FindProduct)
          .AddMethod(__Method_GetAllProduct, serviceImpl.GetAllProduct)
          .AddMethod(__Method_GetProductById, serviceImpl.GetProductById)
          .AddMethod(__Method_CreateProduct, serviceImpl.CreateProduct)
          .AddMethod(__Method_UpdateProduct, serviceImpl.UpdateProduct)
          .AddMethod(__Method_DeleteProduct, serviceImpl.DeleteProduct).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_FindProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BBEngineGRPC.Protos.ProductRequest, global::BBEngineGRPC.Protos.ProductListItem>(serviceImpl.FindProduct));
      serviceBinder.AddMethod(__Method_GetAllProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BBEngineGRPC.Protos.ProductRequestEmpty, global::BBEngineGRPC.Protos.ProductListItem>(serviceImpl.GetAllProduct));
      serviceBinder.AddMethod(__Method_GetProductById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BBEngineGRPC.Protos.ProductRequest, global::BBEngineGRPC.Protos.ProductList>(serviceImpl.GetProductById));
      serviceBinder.AddMethod(__Method_CreateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BBEngineGRPC.Protos.CreateProductRequest, global::BBEngineGRPC.Protos.ResponseMessage>(serviceImpl.CreateProduct));
      serviceBinder.AddMethod(__Method_UpdateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BBEngineGRPC.Protos.UpdateProductRequest, global::BBEngineGRPC.Protos.ResponseMessage>(serviceImpl.UpdateProduct));
      serviceBinder.AddMethod(__Method_DeleteProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BBEngineGRPC.Protos.DeleteProductRequest, global::BBEngineGRPC.Protos.ResponseMessage>(serviceImpl.DeleteProduct));
    }

  }
}
#endregion
