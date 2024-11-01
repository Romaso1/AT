using System;
using System.Threading;

class Program
{
    static readonly object lockObj = new object();

    static void Main()
    {
        // Створення та запуск потоків
        Thread waitingThread = new Thread(WaitForSignal);
        waitingThread.Start();

        Thread signalingThread = new Thread(SendSignal);
        signalingThread.Start();
    }

    static void WaitForSignal()
    {
        lock (lockObj)
        {
            Console.WriteLine("Очікую сигналу...");
            Monitor.Wait(lockObj);  
            Console.WriteLine("Сигнал отримано!");
        }
    }

    static void SendSignal()
    {
        Thread.Sleep(1000);  
        lock (lockObj)
        {
            Console.WriteLine("Надсилаємо сигнал...");
            Monitor.Pulse(lockObj);  // Відправка сигналу
        }
    }
}
