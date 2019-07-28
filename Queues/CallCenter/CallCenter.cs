using System;
using System.Collections.Concurrent;

namespace DataStructureOverview.Queues.CallCenter
{
    public class CallCenter
    {
        private int _counter = 0;
        public ConcurrentQueue<IncomingCall> Calls {get; private set; }

        public CallCenter()
        {
            Calls = new ConcurrentQueue<IncomingCall>();
        }

        public void Call(int clientId)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now
            };
            Calls.Enqueue(call);
        }

        public IncomingCall Answer(string consultant)
        {
            var existsCall = Calls.TryDequeue(out IncomingCall call);
            
            if (!existsCall)
                return null;

            call.Consultant = consultant;
            call.StartTime = DateTime.Now;
            return call;
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return Calls.Count > 0;
        }
    }
}