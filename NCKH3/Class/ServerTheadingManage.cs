using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NCKH3.Class
{
    class ServerTheadingManage
    {
        // MyClientManage _myClientManage;
        private static ServerTheadingManage _instance = null;
        private static List<Thread> _lThreads;

        private static bool _flagAutoRemove = false;
        int _idAutoRemove = -1;

        private ServerTheadingManage()
        {
            _lThreads = new List<Thread>();
            _flagAutoRemove = true;
            int _idAutoRemove = this.addNewWork(autoRemoveStoppedThread);
                       
        }
        public static ServerTheadingManage getInstance()
        {
            if (_instance == null)
            {
                _instance = new ServerTheadingManage();
            }

            return _instance;
        }
        public void startInstance(int id)
        {
            if (_lThreads.Count > id)
            {
                if (!_lThreads[id].IsAlive)
                    _lThreads[id].Start();
            }
        }
        public void startAll()
        {
            for (int i = 0; i < _lThreads.Count; i++)
            {
                if (!_lThreads[i].IsAlive)
                    _lThreads[i].Start();
            }
        }

        public int addNewWork(ThreadStart function)
        {
            Thread newThread = new System.Threading.Thread(function);
            newThread.Start();
            _lThreads.Add(newThread);
            return _lThreads.Count - 1;
        }
        public void stopInstance(int id)
        {
            //if (_lThreads.Count > id)
            //{
            //    try
            //    {
            //        if (_lThreads[id].IsAlive)
            //            _lThreads[id].Interrupt();
            //            _lThreads[id].Abort();
            //    }
            //    catch
            //    {

            //    }
             
            //    finally { }

            //    _lThreads.RemoveAt(id);
            //}
        }

        public void StopManage()
        {
            _flagAutoRemove = false;
        }

        private void autoRemoveStoppedThread()
        {
            while(_flagAutoRemove)
            {
                for (int i = 0; i < _lThreads.Count; i++)
                {
                    if (_lThreads[i].ThreadState != ThreadState.Running)
                    {
                        _lThreads.Remove(_lThreads[i]);
                    }
                }

                Thread.Sleep(5000);
            }           
        }

    }
}
