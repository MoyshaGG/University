using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        struct MyTime
        {
            public int hour;
            public int minute;
            public int second;

            public MyTime(int h, int m, int s)
            {
                hour = h;
                minute = m;
                second = s;
            }

            public override string ToString()
            {
                string timeString = "";
                timeString += hour.ToString() + ":" + minute.ToString("00") + ":" + second.ToString("00");
                return timeString;
            }
        }
        static int TimeSinceMidnight(MyTime myTime)
        {
            int time = (myTime.hour * 3600) + (myTime.minute * 60) + myTime.second;
            return time;
        }
        static MyTime TimeSinceMidnight(int time)
        {
            int secPerDay = 60 * 60 * 24;
            time = ((time % secPerDay) + secPerDay) % secPerDay;
            int h = time / 3600;
            int m = (time / 60) % 60;
            int s = time % 60;
            return new MyTime(h, m, s);
        }
        static MyTime AddOneSecond(MyTime myTime)
        {
            int time = TimeSinceMidnight(myTime);
            int sec = time + 1;
            MyTime time3 = new MyTime();
            time3 = TimeSinceMidnight(sec);
            return time3;
        }
        static MyTime AddOneMinute(MyTime myTime)
        {
            int time = TimeSinceMidnight(myTime);
            int min = time + 60;
            MyTime time4 = new MyTime();
            time4 = TimeSinceMidnight(min);
            return time4;
        }
        static MyTime AddOneHour(MyTime myTime)
        {
            int time = TimeSinceMidnight(myTime);
            int hou = time + 3600;
            MyTime time5 = new MyTime();
            time5 = TimeSinceMidnight(hou);
            return time5;
        }
        static MyTime AddSeconds(MyTime myTime, int secToPlus)
        {
            int time = TimeSinceMidnight(myTime);
            int diff = time + secToPlus;
            MyTime time6 = new MyTime();
            time6 = TimeSinceMidnight(diff);
            return time6;
        }
        static int Difference(MyTime myTime, MyTime myTime2)
        {
            int time1 = TimeSinceMidnight(myTime);
            int time2 = TimeSinceMidnight(myTime2);
            int diff = time1 - time2;
            return diff;
        }
        static void WhatLesson(MyTime myTime3)
        {
            int time = TimeSinceMidnight(myTime3);
            if (time > 63600 || time < 28800)
            {
                Console.WriteLine("Пари ще не розпочалися");
            }
            else
            {
                int pererva = 1200;
                int para = 28800;
                int paraTime = 4800;
                for (int i = 1; i < 7; i++)
                {
                    if (time > para && time < para + paraTime)
                    {
                        Console.WriteLine("Зараз {0} Пара", i);
                        break;
                    }
                    else if (time > para + paraTime && time < para + pererva + paraTime)
                    {
                        Console.WriteLine("Перерва між {0} та {1} парами", i, i + 1);
                        break;
                    }
                    para = para + paraTime + pererva;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть час: ");
            string input = Console.ReadLine();
            int[] inputParams = input.Split(' ').Select(int.Parse).ToArray();
            MyTime myTime = new MyTime(inputParams[0], inputParams[1], inputParams[2]);
            int time = TimeSinceMidnight(myTime);
            TimeSinceMidnight(myTime);
            Console.WriteLine("{0} секунд з початку дня", time);
            MyTime myTimeTable = new MyTime(inputParams[0], inputParams[1], inputParams[2]);
            TimeSinceMidnight(time);
            Console.WriteLine("Зараз {0} ", myTimeTable);
            Console.WriteLine("Час через:");
            MyTime myTimeWithSecond = AddOneSecond(myTime);
            AddOneSecond(myTime);
            Console.WriteLine("-одну секунду: {0}", myTimeWithSecond);
            MyTime myTimeWithMinute = AddOneMinute(myTime);
            AddOneMinute(myTime);
            Console.WriteLine("-одну хвилину: {0}", myTimeWithMinute);
            MyTime myTimeWithHour = AddOneHour(myTime);
            AddOneHour(myTime);
            Console.WriteLine("-одну годину: {0}", myTimeWithHour);
            Console.WriteLine("Скiльки секунд додати?");
            int secToPlus = Int32.Parse(Console.ReadLine());
            MyTime withSeconds = AddSeconds(myTime, secToPlus);
            AddSeconds(myTime, secToPlus);
            Console.WriteLine("Час з {0} секундами {1}", secToPlus, withSeconds);
            Console.Write("Введiть час для знаходженння рiзницi: ");
            string input2 = Console.ReadLine();
            int[] inputParams2 = input2.Split(' ').Select(int.Parse).ToArray();
            MyTime myTime2 = new MyTime(inputParams2[0], inputParams2[1], inputParams2[2]);
            Difference(myTime, myTime2);
            Console.WriteLine("Рiзниця {0} в секундах", Difference(myTime, myTime2));
            Console.Write("Введiть час щоб дiзнатись яка пара:");
            string input3 = Console.ReadLine();
            int[] inputParams3 = input3.Split(' ').Select(int.Parse).ToArray();
            MyTime myTime3 = new MyTime(inputParams3[0], inputParams3[1], inputParams3[2]);
            WhatLesson(myTime3);
            Console.ReadKey();
        }
    }
}
