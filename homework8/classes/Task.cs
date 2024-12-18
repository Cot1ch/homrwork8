﻿using System;
using System.Collections.Generic;


namespace homework8
{
    internal class Task
    {
        string _Discription;
        DateTime _DeadLine;
        Customer _Customer;
        Executor _Executor;
        TaskStatuses _Status;
        List<Report> _Reports;

        public Task(string discription, DateTime deadLine, Customer customer, Executor executor, TaskStatuses status, List<Report> reports)
        {
            _Discription = discription;
            _DeadLine = deadLine;
            _Customer = customer;
            _Executor = executor;
            _Status = status;
            _Reports = reports;
        }
        public Task()
        {
            _Reports = new List<Report>();
        }
        public string Discription
        {
            get { return _Discription; }
            set { _Discription = value; }
        }
        public DateTime DeadLine
        {
            get { return _DeadLine; }
            set { _DeadLine = value; }
        }
        public Customer Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        }
        public Executor Executor
        {
            get { return _Executor; }
            set { _Executor = value; }
        }
        public TaskStatuses Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public List<Report> Reports
        {
            get { return _Reports; }
            set { _Reports = value; }
        }
        public override string ToString()
        {
            string retStr = String.Empty;

            retStr += $"\nОписание:\n{Discription}\n";
            retStr += $"Дедлайн: {DeadLine}\n";
            retStr += $"Заказчик: {Customer.Name}\n";
            retStr += $"Исполнитель: {Executor.Name}\n";
            retStr += $"Статус задачи: {Status}\n";
            retStr += $"Отчеты: {Reports}";

            return retStr;
        }


        static public DateTime EnterDate()
        {
            DateTime date = DateTime.Now;
            bool flag = true;
            Console.WriteLine("Введите дату в формате dd.MM.yyyy");
            do
            {
                if (DateTime.TryParse(Console.ReadLine(), out DateTime resultDate) && resultDate >= DateTime.Now)
                {
                    date = resultDate;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Введите реальную дату в формате dd.MM.yyyy");
                }
            }
            while (flag);
            return date;
        }
    }
}