using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosKernel
{
    public class Kernel : Sys.Kernel
    {
        Sys.FileSystem.CosmosVFS fs;
        
        protected override void BeforeRun()
        {
            fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

            Console.WriteLine("Cosmos booted successfully. Type a 'help' to see commands");
        }

        protected override void Run()
        {
            string curDir = Directory.GetCurrentDirectory();

            string a = Console.ReadLine();

            a = a.ToLower();

            string[] args = a.Split(" ");

            switch (args[0])
            {
                case "help":
                    {
                        Console.WriteLine("ls       -       prints all directories and files in the current directory");
                        Console.WriteLine("pwd      -       prints current directory");
                        Console.WriteLine("cd       -       change directory to the source directory");
                        Console.WriteLine("cd dir   -       change directory to dir");
                        Console.WriteLine("mkdir dir   -    create a new directory named 'dir'");
                        Console.WriteLine("rmdir dir   -    delete directory 'dir' and all its components DOES NOT WORK"); //No idea it just wont delete directories, anytime there would be no errors it just wouldnt delete
                        Console.WriteLine("mv file dir -    moves file 'file' into directory 'dir' DOES NOT WORK"); //no notieable plug that enables move function in Cosmos
                        Console.WriteLine("create file -    creates new file named 'file'");
                        Console.WriteLine("rm file     -    deletes file 'file'");
                        Console.WriteLine("copy file1 file 2   -    copies 'file1' and create a new file named 'file2' with its contents");

                        break;
                    }
                case "ls":
                    {
                        DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

                        foreach (DirectoryInfo d in dir.GetDirectories())
                        {
                            Console.WriteLine("{0, -30}\t directory", d.Name);
                        }

                        foreach (FileInfo f in dir.GetFiles())
                        {
                            Console.WriteLine("{0, -30}\t File", f.Name);
                        }
                        break;
                    }
                case "pwd":
                    {
                        Console.WriteLine(curDir);
                        break;
                    }
                case "cd":
                    {
                        if (args[1] == "home")
                        {
                            Directory.SetCurrentDirectory("0:\\");
                        }
                        else if (Directory.Exists(curDir + "\\" + args[1]))
                        {
                            Directory.SetCurrentDirectory(curDir + "\\" + args[1]);
                        }
                        else
                        {
                            Console.WriteLine("This location does not exist");
                        }

                        break;
                    }
                case "mkdir":
                    {
                        if (!Directory.Exists(curDir + "\\" + args[1]))
                        {
                            Directory.CreateDirectory(curDir + "\\" + args[1]);
                        }
                        else
                        {
                            Console.WriteLine("This Directory already exists");
                        }
                        break;
                    }
                    /*
                case "rmdir":
                    {
                        if (Directory.Exists(curDir + "\\" + args[1]))
                        {
                            Directory.Delete(curDir + "\\" + args[1],true);
                        }
                        else
                        {
                            Console.WriteLine("This Directory doesn't exist");
                        }
                        break;
                    }
                /*  case "mv":
                      {
                          if (!File.Exists(args[1]))
                          {
                              Console.WriteLine("This file doesn't exist");
                          }
                          else if (!Directory.Exists(args[2]))
                          {
                              Console.WriteLine("This Location doesn't exist");
                          }
                          else 
                          {
                              File.Move(args[1], args[2]);
                          }
                          break;
                      }*/
                case "create":
                    {
                        if (!File.Exists(curDir + "\\" + args[1]))
                        {
                            File.Create(curDir + "\\" + args[1]);
                        }
                        else
                        {
                            Console.WriteLine("This File already exists");
                        }
                        break;
                    }
                case "rm":
                    {
                        if (File.Exists(curDir + "\\" + args[1]))
                        {
                            File.Delete(curDir + "\\" + args[1]);
                        }
                        else
                        {
                            Console.WriteLine("This File doesn't exist");
                        }
                        break;
                    }
                case "copy":
                    {
                        if (!File.Exists(curDir + "\\" + args[1]))
                        {
                            Console.WriteLine("First File does not exist");
                        }
                        else if (File.Exists(curDir + "\\" + args[2]))
                        {
                            Console.WriteLine("Second File already exists");
                        }
                        else
                        {
                            File.Copy(args[1], args[2]);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("This Command Doesn't Exist. ");
                        
                        break;
                    }
            }
        }
    }
}
