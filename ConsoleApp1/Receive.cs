using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

// 1. Opret forbindelse
var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = await factory.CreateConnectionAsync();
using var channel = await connection.CreateChannelAsync();

// 2. Erklær køen (skal matche producerens definition)
await channel.QueueDeclareAsync(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

// 3. Opret en consumer der lytter asynkront
var consumer = new AsyncEventingBasicConsumer(channel);
consumer.ReceivedAsync += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($" [x] Modtog: {message}");
    return Task.CompletedTask;
};

// 4. Start lytning
await channel.BasicConsumeAsync("hello", autoAck: true, consumer: consumer);

Console.WriteLine(" [*] Venter på beskeder. Tryk [enter] for at afslutte.");
Console.ReadLine();