using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ct_8
{

    //public class Timer
    //{
    //    public event EventHandler Tick;

    //    private readonly System.Timers.Timer _timer;

    //    public Timer()
    //    {
    //        _timer = new System.Timers.Timer(1000);
    //        _timer.Elapsed += (s, e) => Tick?.Invoke(this, EventArgs.Empty);
    //    }

    //    public void Start() => _timer.Start();
    //    public void Stop() => _timer.Stop();
    //}

    //public class Clock
    //{
    //    public void OnTick(object sender, EventArgs e)
    //    {
    //        Console.WriteLine($"текущее время: {DateTime.Now:T}");
    //    }
    //}

    //public class Counter
    //{
    //    public int Value { get; private set; }

    //    public void OnTick(object sender, EventArgs e)
    //    {
    //        Value++;
    //        Console.WriteLine($"счетчик: {Value}");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        var timer = new Timer();
    //        var clock = new Clock();
    //        var counter = new Counter();

    //        timer.Tick += clock.OnTick;
    //        timer.Tick += counter.OnTick;

    //        Console.WriteLine("нажмите enter для завершения.");
    //        timer.Start();
    //        Console.ReadLine();
    //        timer.Stop();
    //    }
    //}
    //    public class BankAccount
    //    {
    //        public event Action<decimal> BalanceChanged;

    //        private decimal _balance;

    //        public decimal Balance
    //        {
    //            get => _balance;
    //            private set
    //            {
    //                _balance = value;
    //                BalanceChanged?.Invoke(_balance);
    //            }
    //        }

    //        public void Deposit(decimal amount)
    //        {
    //            if (amount <= 0) throw new ArgumentException("сумма должна быть больше нуля");
    //            Balance += amount;
    //        }

    //        public void Withdraw(decimal amount)
    //        {
    //            if (amount <= 0) throw new ArgumentException("сумма должна быть больше нуля");
    //            if (amount > Balance) throw new InvalidOperationException("недостаточно средств");
    //            Balance -= amount;
    //        }
    //    }

    //    public class Logger
    //    {
    //        private readonly string _filePath;

    //        public Logger(string filePath)
    //        {
    //            _filePath = filePath;
    //        }

    //        public void LogBalanceChange(decimal balance)
    //        {
    //            File.AppendAllText(_filePath, $"Баланс изменен: {balance:C}\n");
    //        }
    //    }

    //    class Program
    //    {
    //        static void Main()
    //        {
    //            var account = new BankAccount();
    //            var logger = new Logger("balance_log.txt");

    //            account.BalanceChanged += logger.LogBalanceChange;

    //            account.Deposit(100);
    //            account.Withdraw(30);
    //            account.Deposit(50);

    //            Console.WriteLine("Проверьте файл balance_log.txt.");
    //        }
    //    }

    //}

    //public class Button
    //{
    //    public string Text { get; set; }

    //    private readonly List<EventHandler> _subscribers = new List<EventHandler>();
    //    private const int MaxSubscribers = 3;

    //    public event EventHandler Click
    //    {
    //        add
    //        {
    //            if (_subscribers.Contains(value))
    //            {
    //                Console.WriteLine("подписчик уже добавлен!");
    //                return;
    //            }

    //            if (_subscribers.Count >= MaxSubscribers)
    //            {
    //                Console.WriteLine("превышено максимальное количество подписчиков!");
    //                return;
    //            }

    //            _subscribers.Add(value);
    //        }
    //        remove
    //        {
    //            if (_subscribers.Contains(value))
    //                _subscribers.Remove(value);
    //        }
    //    }

    //    public void OnClick()
    //    {
    //        foreach (var subscriber in _subscribers)
    //        {
    //            if (subscriber != null)
    //                subscriber(this, EventArgs.Empty);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        var button = new Button { Text = "кнопка 1" };

    //        EventHandler handler1 = (s, e) => Console.WriteLine($"обработчик 1: {((Button)s).Text}");
    //        EventHandler handler2 = (s, e) => Console.WriteLine($"обработчик 2: {((Button)s).Text}");
    //        EventHandler handler3 = (s, e) => Console.WriteLine($"обработчик 3: {((Button)s).Text}");
    //        EventHandler handler4 = (s, e) => Console.WriteLine($"обработчик 4: {((Button)s).Text}");

    //        button.Click += handler1;
    //        button.Click += handler2;
    //        button.Click += handler3;
    //        button.Click += handler4; 
    //        button.Click += handler1; 
    //        button.OnClick();
    //    }
    //}
//}
