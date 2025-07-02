
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ImportadorRemisiones
{
    public class WebServer
    {
        private readonly HttpListener _listener = new HttpListener();
        private readonly Func<string, Task> _requestHandler;

        public WebServer(string uri, Func<string, Task> requestHandler)
        {
            _listener.Prefixes.Add(uri);
            _requestHandler = requestHandler;
        }

        public void Start()
        {
            _listener.Start();
            Task.Run(() => Run());
        }

        public void Stop()
        {
            _listener.Stop();
        }

        private async Task Run()
        {
            while (_listener.IsListening)
            {
                try
                {
                    var context = await _listener.GetContextAsync();
                    await ProcessRequest(context);
                }
                catch (HttpListenerException ex)
                {
                    // This exception is thrown when the listener is stopped.
                    if (ex.ErrorCode == 995)
                        return;
                }
                catch (Exception ex)
                {
                    // Log other exceptions
                    Console.WriteLine($"Request error: {ex.Message}");
                }
            }
        }

        private async Task ProcessRequest(HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;

            if (request.HttpMethod == "POST" && request.Url.AbsolutePath == "/api/enviar-a-contpaq")
            {
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    var json = await reader.ReadToEndAsync();
                    await _requestHandler(json);

                    var buffer = Encoding.UTF8.GetBytes("{"status": "OK"}");
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                }
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
            }

            response.OutputStream.Close();
        }
    }
}
