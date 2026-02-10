using RabbitMQ.Client;
using System.Text;

// 1. Opret forbindelse til serveren (Docker)
var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = await factory.CreateConnectionAsync();
using var channel = await connection.CreateChannelAsync();

// 2. Erklær en kø (hvis den ikke findes)
await channel.QueueDeclareAsync(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

// 3. Send en besked
string message = "Hello World fra 4. semester!";
var body = Encoding.UTF8.GetBytes(message);

await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "hello", body: body);
Console.WriteLine($" [x] Sendte: {message}");

Console.WriteLine(" Tryk [enter] for at lukke.");
Console.ReadLine();