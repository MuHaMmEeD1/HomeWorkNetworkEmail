
using System.Net;

HttpListener listener = new HttpListener();
listener.Prefixes.Add("http://localhost:12345/");

listener.Start();

while (true) {

    HttpListenerContext context = listener.GetContext();

    HttpListenerRequest request = context.Request;
    HttpListenerResponse response = context.Response;
    response.ContentType = "text/html";

    StreamWriter writer = new StreamWriter(response.OutputStream);

    writer.WriteLine(File.ReadAllText("Pages/Email.html"));

    for (int i = 0; i < request.QueryString.Count; i++)
    {
        Console.WriteLine(request.QueryString[i]);
    }

    writer.Dispose();

}




















