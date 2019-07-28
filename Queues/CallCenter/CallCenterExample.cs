using System;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructureOverview.Queues.CallCenter
{
    public class CallCenterExample
    {
        public void Run()
        {
            CallCenter callCenter = new CallCenter();
            Parallel.Invoke(
                () => CallersAction(callCenter),
                () => ConsultantAction(callCenter, "Maria", ConsoleColor.Red),
                () => ConsultantAction(callCenter, "Joao", ConsoleColor.Green),
                () => ConsultantAction(callCenter, "Pedro", ConsoleColor.Blue));
        }

        private static void CallersAction(CallCenter callCenter)
        {
            Random random = new Random();
            
            // TODO: change while true
            while (true)
            {
                int clientId = random.Next(1, 10000);
                callCenter.Call(clientId);
                Log($"Incoming call from {clientId}.");
                Thread.Sleep(random.Next(1000,5000));
            }
        }

        private static void ConsultantAction(CallCenter callCenter, string name, ConsoleColor color)
        {
            Random random = new Random();
            
            // TODO: change while true
            while (true)
            {
                IncomingCall call = callCenter.Answer(name);
                if (call == null)
                {
                    Thread.Sleep(100);
                    continue;
                }

                Console.ForegroundColor = color;
                Log($"Call #{call.Id} from {call.ClientId} is answered by {call.Consultant}");
                Console.ForegroundColor = ConsoleColor.Gray;

                Thread.Sleep(random.Next(1000,10000));
                
                callCenter.End(call);
                Console.ForegroundColor = color;
                Log($"Call #{call.Id} from {call.ClientId} is ended by {call.Consultant}");
                Console.ForegroundColor = ConsoleColor.Gray;

                Thread.Sleep(random.Next(500,1000));
            }
        }

        private static void Log(string text)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] {text}");
        }
    }
}