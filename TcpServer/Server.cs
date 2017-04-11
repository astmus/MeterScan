using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace TcpServer
{
     class Server
       {
           TcpListener Listener; // Объект, принимающий TCP-клиентов
    
           // Запуск сервера
           public Server(int Port)
           {
               Listener = new TcpListener(IPAddress.Parse("192.168.123.1"), Port); // Создаем "слушателя" для указанного порта
               Listener.Start(); // Запускаем его
    
               // В бесконечном цикле
               while (true)
               {
                   // Принимаем нового клиента
                   TcpClient Client = Listener.AcceptTcpClient();
                   // Создаем поток
                   Thread Thread = new Thread(new ParameterizedThreadStart(ClientThread));
                   // И запускаем этот поток, передавая ему принятого клиента
                   Thread.Start(Client);
               }
           }
    
           static void ClientThread(Object StateInfo)
           {
               // Просто создаем новый экземпляр класса Client и передаем ему приведенный к классу TcpClient объект StateInfo
               MessageBox.Show("New client");
           }
    
           // Остановка сервера
           ~Server()
           {
               // Если "слушатель" был создан
               if (Listener != null)
               {
                   // Остановим его
                   Listener.Stop();
               }
           } 
       }
}
