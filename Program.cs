using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;

namespace Assignment12_Client.server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IP address");
            string inputIP = Console.ReadLine();
            Console.WriteLine("Port number");
            string inputPort = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("UDP or TCP?");
                string inputServType = Console.ReadLine();

                try
                {
                    if (inputServType == "TCP")
                    {
                        MathServiceTcp mathService = new MathServiceTcp(IPAddress.Parse(inputIP), Convert.ToInt32(inputPort));

                        Console.WriteLine("Command!!! in format 'operator:firstValue: SecondValue' ");

                        string command = Console.ReadLine();

                        command.Trim();

                        try
                        {
                            string operation = command.Substring(0, command.IndexOf(':'));

                            string firstValue = command.Substring(command.IndexOf(':') + 1, command.LastIndexOf(':') - command.IndexOf(':') - 1);

                            string secondValue = command.Substring(command.LastIndexOf(':')+1, command.Length-command.LastIndexOf(':')-1);


                            switch (operation)
                            {
                                case "+":
                                    Console.WriteLine(mathService.Add(Convert.ToDouble(firstValue), Convert.ToDouble(secondValue)));
                                    break;

                                case "-":

                                    Console.WriteLine(mathService.Sub(Convert.ToDouble(firstValue), Convert.ToDouble(secondValue)));
                                    break;

                                case "/":
                                    Console.WriteLine(mathService.Div(Convert.ToDouble(firstValue), Convert.ToDouble(secondValue)));
                                    break;

                                case "*":
                                    Console.WriteLine(mathService.Mult(Convert.ToDouble(firstValue), Convert.ToDouble(secondValue)));
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    
                    else if(inputServType == "UDP")
                    {
                        MathServiceUdp mathService = new MathServiceUdp();


                        Console.WriteLine("Command!!! in format 'operator:firstValue: SecondValue' ");

                        string command = Console.ReadLine();

                        command.Trim();

                        try
                        {
                            string operation = command.Substring(0, command.IndexOf(':'));

                            string firstValue = command.Substring(command.IndexOf(':') + 1, command.LastIndexOf(':')- command.IndexOf(':') - 1 );

                            string secondValue = command.Substring(command.LastIndexOf(':')+1, command.Length- command.LastIndexOf(':')-1);


                            switch (operation)
                            {
                                case "+":
                                    Console.WriteLine(mathService.Add(Convert.ToDouble(firstValue), Convert.ToDouble(secondValue)));
                                    break;

                                case "-":

                                    Console.WriteLine(mathService.Sub(Convert.ToDouble(firstValue), Convert.ToDouble(secondValue)));
                                    break;

                                case "/":
                                    Console.WriteLine(mathService.Div(Convert.ToDouble(firstValue), Convert.ToDouble(secondValue)));
                                    break;

                                case "*":
                                    Console.WriteLine(mathService.Mult(Convert.ToDouble(firstValue), Convert.ToDouble(secondValue)));
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input!" + e);
                }

                Console.ReadLine();
            }

            
        }
    }
}
