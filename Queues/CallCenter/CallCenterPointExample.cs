using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace DataStructureOverview.Queues.CallCenter
{
    public class CallCenterPointExample
    {
        public void Run()
        {
            Random random = new Random();

            CallCenterPoint callCenter = new CallCenterPoint();
            callCenter.Call(1234);
            callCenter.Call(5678);
            callCenter.Call(1468);
            callCenter.Call(9641);

            while (callCenter.AreWaitingCalls())
            {
                IncomingCall call = callCenter.Answer("Maria");
                Log($"Call #{call.Id} from {call.ClientId} is answered by {call.Consultant}");
                Thread.Sleep(random.Next(1000,10000));
                callCenter.End(call);
                Log($"Call #{call.Id} from {call.ClientId} is ended by {call.Consultant}");
            }
        }

        private static void Log(string text)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] {text}");
        }
    }
}