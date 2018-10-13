using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocket.Portable;

namespace MicrobitBLE.ViewModels
{
    class WebsocketClient
    {
        // private Websockets.IWebSocketConnection connection;
        private WebsocketClient connection;
        private bool Echo;
        void Connect()
        {
            // 2) Get a websocket from your PCL library via the factory
            //  connection = Websockets.WebSocketFactory.Create();
            connection = new WebsocketClient();
            connection. += Connection_OnOpened;
            connection.OnMessage += Connection_OnMessage;
        }

        void Send()
        {            
            connection.Open("http://echo.websocket.org");
            connection.Send("Hello World");
        }

        private void Connection_OnOpened()
        {
           System.Diagnostics.Debug.WriteLine("Opened !");
        }

        private void Connection_OnMessage(string obj)
        {
            Echo = obj == "Hello World";
        }
    }
}
