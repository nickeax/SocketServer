using System.Net.Sockets;

namespace Server;
public class Server
{
    static Socket listenSocket;
}

class ClientData
{
    public Socket clientSocket;
    public Thread clientThread;
    public string id;

    public ClientData()
    {
        id = Guid.NewGuid().ToString();    
    }

    public ClientData(Socket clientSocket)
    {
        this.clientSocket = clientSocket;
    }
}