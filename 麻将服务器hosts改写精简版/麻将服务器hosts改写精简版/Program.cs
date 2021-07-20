using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Runtime;
using System.Linq;

namespace 麻将服务器hosts改写精简版
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用麻将服务器hosts改写精简版!");
            Console.WriteLine("按下任意键开始...");
            Console.ReadKey();
            Console.WriteLine("提示:服务器超时输出的ping值被设置成0ms\n     超时延迟为1024ms");
            #region Servers_IP
            //验证服务器IP
            var AuthServerIP1 = "13.227.55.68";
            var AuthServerIP2 = "13.35.91.67";
            var AuthServerIP3 = "99.84.227.68";
            var AuthServerIP4 = "52.85.117.68";
            var AuthServerIP5 = "13.33.8.69";
            var AuthServerIP6 = "13.227.48.68";
            var AuthServerIP7 = "65.9.31.69";
            var AuthServerIP8 = "54.230.84.68";
            var AuthServerIP9 = "13.227.231.68";
            var AuthServerIP10 = "99.86.219.68";
            var AuthServerIP11 = "13.33.200.67";
            var AuthServerIP12 = "99.86.203.68";
            var AuthServerIP13 = "13.225.107.68";
            var AuthServerIP14 = "52.85.191.179";
            var AuthServerIP15 = "13.35.41.67";
            var AuthServerIP16 = "13.33.61.69";
            var AuthServerIP17 = "13.35.25.67";
            //会话服务器IP
            var SessionServerIP1 = "54.192.20.105";
            var SessionServerIP2 = "99.84.198.181";
            var SessionServerIP3 = "99.84.230.186";
            var SessionServerIP4 = "99.84.138.181";
            var SessionServerIP5 = "13.249.174.171";
            var SessionServerIP6 = "13.33.150.98";
            var SessionServerIP7 = "13.227.59.108";
            var SessionServerIP8 = "13.249.156.175";
            var SessionServerIP9 = "13.35.31.176";
            var SessionServerIP10 = "13.227.251.106";
            var SessionServerIP11 = "99.86.207.169";
            var SessionServerIP12 = "54.192.89.95";
            var SessionServerIP13 = "13.35.166.182";
            var SessionServerIP14 = "54.192.148.176";
            #endregion
            Console.WriteLine("正在开始测试......\n");
            //开始测试
            Ping ping = new Ping();
            PingOptions pingoptions = new PingOptions();
            pingoptions.DontFragment = true;
            string data = "test data";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 1024;
            #region Ping_Start
            PingReply AuthServer1Reply = ping.Send(AuthServerIP1, timeout, buffer, pingoptions);
            PingReply AuthServer2Reply = ping.Send(AuthServerIP2, timeout, buffer, pingoptions);
            PingReply AuthServer3Reply = ping.Send(AuthServerIP3, timeout, buffer, pingoptions);
            PingReply AuthServer4Reply = ping.Send(AuthServerIP4, timeout, buffer, pingoptions);
            PingReply AuthServer5Reply = ping.Send(AuthServerIP5, timeout, buffer, pingoptions);
            PingReply AuthServer6Reply = ping.Send(AuthServerIP6, timeout, buffer, pingoptions);
            PingReply AuthServer7Reply = ping.Send(AuthServerIP7, timeout, buffer, pingoptions);
            PingReply AuthServer8Reply = ping.Send(AuthServerIP8, timeout, buffer, pingoptions);
            PingReply AuthServer9Reply = ping.Send(AuthServerIP9, timeout, buffer, pingoptions);
            PingReply AuthServer10Reply = ping.Send(AuthServerIP10, timeout, buffer, pingoptions);
            PingReply AuthServer11Reply = ping.Send(AuthServerIP11, timeout, buffer, pingoptions);
            PingReply AuthServer12Reply = ping.Send(AuthServerIP12, timeout, buffer, pingoptions);
            PingReply AuthServer13Reply = ping.Send(AuthServerIP13, timeout, buffer, pingoptions);
            PingReply AuthServer14Reply = ping.Send(AuthServerIP14, timeout, buffer, pingoptions);
            PingReply AuthServer15Reply = ping.Send(AuthServerIP15, timeout, buffer, pingoptions);
            PingReply AuthServer16Reply = ping.Send(AuthServerIP16, timeout, buffer, pingoptions);
            PingReply AuthServer17Reply = ping.Send(AuthServerIP17, timeout, buffer, pingoptions);
            PingReply SessionServer1Reply = ping.Send(SessionServerIP1, timeout, buffer, pingoptions);
            PingReply SessionServer2Reply = ping.Send(SessionServerIP2, timeout, buffer, pingoptions);
            PingReply SessionServer3Reply = ping.Send(SessionServerIP3, timeout, buffer, pingoptions);
            PingReply SessionServer4Reply = ping.Send(SessionServerIP4, timeout, buffer, pingoptions);
            PingReply SessionServer5Reply = ping.Send(SessionServerIP5, timeout, buffer, pingoptions);
            PingReply SessionServer6Reply = ping.Send(SessionServerIP6, timeout, buffer, pingoptions);
            PingReply SessionServer7Reply = ping.Send(SessionServerIP7, timeout, buffer, pingoptions);
            PingReply SessionServer8Reply = ping.Send(SessionServerIP8, timeout, buffer, pingoptions);
            PingReply SessionServer9Reply = ping.Send(SessionServerIP9, timeout, buffer, pingoptions);
            PingReply SessionServer10Reply = ping.Send(SessionServerIP10, timeout, buffer, pingoptions);
            PingReply SessionServer11Reply = ping.Send(SessionServerIP11, timeout, buffer, pingoptions);
            PingReply SessionServer12Reply = ping.Send(SessionServerIP12, timeout, buffer, pingoptions);
            PingReply SessionServer13Reply = ping.Send(SessionServerIP13, timeout, buffer, pingoptions);
            PingReply SessionServer14Reply = ping.Send(SessionServerIP14, timeout, buffer, pingoptions);
            #endregion
            #region Auth_Server_Ping_Output
            //服务器未超时
            if (AuthServer1Reply.Status == IPStatus.Success)
            {
                long AuthServer1Output = AuthServer1Reply.RoundtripTime; 
                Console.WriteLine($"验证服务器IP\"{AuthServerIP1}\"延迟为{AuthServer1Output}ms");
            }
            if (AuthServer2Reply.Status == IPStatus.Success)
            {
                long AuthServer2Output = AuthServer2Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP2}\"延迟为{AuthServer2Output}ms");
            }
            if (AuthServer3Reply.Status == IPStatus.Success)
            {
                long AuthServer3Output = AuthServer3Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP3}\"延迟为{AuthServer3Output}ms");
            }
            if (AuthServer4Reply.Status == IPStatus.Success)
            {
                long AuthServer4Output = AuthServer4Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP4}\"延迟为{AuthServer4Output}ms");
            }
            if (AuthServer5Reply.Status == IPStatus.Success)
            {
                long AuthServer5Output = AuthServer5Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP5}\"延迟为{AuthServer5Output}ms");
            }
            if (AuthServer6Reply.Status == IPStatus.Success)
            {
                long AuthServer6Output = AuthServer6Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP6}\"延迟为{AuthServer6Output}ms");
            }
            if (AuthServer7Reply.Status == IPStatus.Success)
            {
                long AuthServer7Output = AuthServer7Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP7}\"延迟为{AuthServer7Output}ms");
            }
            if (AuthServer8Reply.Status == IPStatus.Success)
            {
                long AuthServer8Output = AuthServer8Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP8}\"延迟为{AuthServer8Output}ms");
            }
            if (AuthServer9Reply.Status == IPStatus.Success)
            {
                long AuthServer9Output = AuthServer9Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP9}\"延迟为{AuthServer9Output}ms");
            }
            if (AuthServer10Reply.Status == IPStatus.Success)
            {
                long AuthServer10Output = AuthServer10Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP10}\"延迟为{AuthServer10Output}ms");
            }
            if (AuthServer11Reply.Status == IPStatus.Success)
            {
                long AuthServer11Output = AuthServer11Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP11}\"延迟为{AuthServer11Output}ms");
            }
            if (AuthServer12Reply.Status == IPStatus.Success)
            {
                long AuthServer12Output = AuthServer12Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP12}\"延迟为{AuthServer12Output}ms");
            }
            if (AuthServer13Reply.Status == IPStatus.Success)
            {
                long AuthServer13Output = AuthServer13Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP13}\"延迟为{AuthServer13Output}ms");
            }
            if (AuthServer14Reply.Status == IPStatus.Success)
            {
                long AuthServer14Output = AuthServer14Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP14}\"延迟为{AuthServer14Output}ms");
            }
            if (AuthServer15Reply.Status == IPStatus.Success)
            {
                long AuthServer15Output = AuthServer15Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP15}\"延迟为{AuthServer15Output}ms");
            }
            if (AuthServer16Reply.Status == IPStatus.Success)
            {
                long AuthServer16Output = AuthServer16Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP16}\"延迟为{AuthServer16Output}ms");
            }
            if (AuthServer17Reply.Status == IPStatus.Success)
            {
                long AuthServer17Output = AuthServer17Reply.RoundtripTime;
                Console.WriteLine($"验证服务器IP\"{AuthServerIP17}\"延迟为{AuthServer17Output}ms");
            }
            //服务器超时
            if (AuthServer1Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP1}\"超时");
            if (AuthServer2Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP2}\"超时");
            if (AuthServer3Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP3}\"超时");
            if (AuthServer4Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP4}\"超时");
            if (AuthServer5Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP5}\"超时");
            if (AuthServer6Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP6}\"超时");
            if (AuthServer7Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP7}\"超时");
            if (AuthServer8Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP8}\"超时");
            if (AuthServer9Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP9}\"超时");
            if (AuthServer10Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP10}\"超时");
            if (AuthServer11Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP11}\"超时");
            if (AuthServer12Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP12}\"超时");
            if (AuthServer13Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP13}\"超时");
            if (AuthServer14Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP14}\"超时");
            if (AuthServer15Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP15}\"超时");
            if (AuthServer16Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP16}\"超时");
            if (AuthServer17Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{AuthServerIP17}\"超时");
            #endregion
            #region Session_Server_Ping_Output
            //服务器未超时
            if (SessionServer1Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP1}\"延迟为{SessionServer1Reply.RoundtripTime}ms");
            if (SessionServer2Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP2}\"延迟为{SessionServer2Reply.RoundtripTime}ms");
            if (SessionServer3Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP3}\"延迟为{SessionServer3Reply.RoundtripTime}ms");
            if (SessionServer4Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP4}\"延迟为{SessionServer4Reply.RoundtripTime}ms");
            if (SessionServer5Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP5}\"延迟为{SessionServer5Reply.RoundtripTime}ms");
            if (SessionServer6Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP6}\"延迟为{SessionServer6Reply.RoundtripTime}ms");
            if (SessionServer7Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP7}\"延迟为{SessionServer7Reply.RoundtripTime}ms");
            if (SessionServer8Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP8}\"延迟为{SessionServer8Reply.RoundtripTime}ms");
            if (SessionServer9Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP9}\"延迟为{SessionServer9Reply.RoundtripTime}ms");
            if (SessionServer10Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP10}\"延迟为{SessionServer10Reply.RoundtripTime}ms");
            if (SessionServer11Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP11}\"延迟为{SessionServer11Reply.RoundtripTime}ms");
            if (SessionServer12Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP12}\"延迟为{SessionServer12Reply.RoundtripTime}ms");
            if (SessionServer13Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP13}\"延迟为{SessionServer13Reply.RoundtripTime}ms");
            if (SessionServer14Reply.Status == IPStatus.Success) Console.WriteLine($"会话服务器IP\"{SessionServerIP14}\"延迟为{SessionServer14Reply.RoundtripTime}ms");
            //服务器超时
            if (SessionServer1Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP1}\"超时");
            if (SessionServer2Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP2}\"超时");
            if (SessionServer3Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP3}\"超时");
            if (SessionServer4Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP4}\"超时");
            if (SessionServer5Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP5}\"超时");
            if (SessionServer6Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP6}\"超时");
            if (SessionServer7Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP7}\"超时");
            if (SessionServer8Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP8}\"超时");
            if (SessionServer9Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP9}\"超时");
            if (SessionServer10Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP10}\"超时");
            if (SessionServer11Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP11}\"超时");
            if (SessionServer12Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP12}\"超时");
            if (SessionServer13Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP13}\"超时");
            if (SessionServer14Reply.Status == IPStatus.TimedOut) Console.WriteLine($"验证服务器IP\"{SessionServerIP14}\"超时");
            #endregion
            #region Output
            Console.WriteLine("");
            long[] ASRTA = new long[] { AuthServer1Output, AuthServer2Reply.RoundtripTime, AuthServer3Reply.RoundtripTime, AuthServer4Reply.RoundtripTime, AuthServer5Reply.RoundtripTime, AuthServer6Reply.RoundtripTime, AuthServer7Reply.RoundtripTime, AuthServer8Reply.RoundtripTime, AuthServer9Reply.RoundtripTime, AuthServer10Reply.RoundtripTime, AuthServer11Reply.RoundtripTime, AuthServer12Reply.RoundtripTime, AuthServer13Reply.RoundtripTime, AuthServer14Reply.RoundtripTime, AuthServer15Reply.RoundtripTime, AuthServer16Reply.RoundtripTime, AuthServer17Reply.RoundtripTime };
            long[] SSRTA = new long[] { SessionServer1Reply.RoundtripTime, SessionServer2Reply.RoundtripTime, SessionServer3Reply.RoundtripTime, SessionServer4Reply.RoundtripTime, SessionServer5Reply.RoundtripTime, SessionServer6Reply.RoundtripTime, SessionServer7Reply.RoundtripTime, SessionServer8Reply.RoundtripTime, SessionServer9Reply.RoundtripTime, SessionServer10Reply.RoundtripTime, SessionServer11Reply.RoundtripTime, SessionServer12Reply.RoundtripTime, SessionServer13Reply.RoundtripTime, SessionServer14Reply.RoundtripTime, };
            long ASRTAmin = ASRTA.Min();
            long ASRTAmax = ASRTA.Max();
            long SSRTAmin = SSRTA.Min();
            long SSRTAmax = SSRTA.Max();
            Console.WriteLine($"验证服务器最高延迟为{ASRTAmax}ms,最低延迟为{ASRTAmin}ms\n验会话服务器最高延迟为{SSRTAmax}ms,最低延迟为{SSRTAmin}ms");
            #endregion
        }
    }
}
