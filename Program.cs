// See https://aka.ms/new-console-template for more information


using gRPC;
using Grpc.Net.Client;

using var grpcChannel = GrpcChannel.ForAddress("http://localhost:5289");
var grpcClient = new ToDoIt.ToDoItClient(grpcChannel);

var reply =  grpcClient.ListToDo
    (new GetAllRequest() { });


Console.WriteLine(reply.ToDo);

Console.ReadKey();
