using Grpc.Net.Client;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Howdy, Y'all!");

var channel = GrpcChannel.ForAddress("http://localhost:5263");
var client  = new GrpcService79.Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new GrpcService79.HelloRequest { Name = "Dude" });
Console.WriteLine("From gRPC server: " + reply.Message);
