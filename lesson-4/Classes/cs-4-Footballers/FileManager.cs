﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nojes.Managers
{
    class FileManager
    {
        string path;
        string name;
        string data;

        /// <summary>
        ///     Initializes a new instance of the File with path and name.
        /// </summary>
        /// <param name="path"> Path to file </param>
        /// <param name="name"> Name of file </param>
        public FileManager(string path, string name)
        {
            this.path = path;
            this.name = name;
        }

        //  Getters & Setters 
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        ///     Reading all data from file.
        /// </summary>
        /// <returns> Returns false if file not found </returns>
        public bool Read()
        {
            try
            {
                FileStream fs = new FileStream(path + name, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                data = sr.ReadToEnd();

                sr.Close();
                fs.Close();

                return true;
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n [ERROR]: {0}", err.Message);
                return false;
            }
            
        }

        /// <summary>
        ///     Overwrites data in file.
        /// </summary>
        /// <param name="new_data"> New file data. </param>
        public void Write(string new_data)
        {
            try
            {
                FileStream fs;
                if(!File.Exists(path + name))
                {
                    Directory.CreateDirectory(path);
                    fs = File.Create(path + name);
                    fs.Close();
                }
                fs = new FileStream(path + name, FileMode.Open, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                data = new_data;
                sw.Write(data);

                sw.Close();
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n [ERROR]: {0}", err.Message);
            }
        }

        public void Create()
        {
            FileStream fs = new FileStream(path + name, FileMode.OpenOrCreate);
            fs.Close();
        }

        /// <summary>
        ///     Format fields into a string (for console).
        /// </summary>
        /// <returns> Returns formatted string. </returns>
        public string toString()
        {
            string line = "--------------------------------------------------------------------------------";
            return String.Format("\n{3} File: {0}{1} \n Data: \n{2} \n{3}", path, name, data, line);
        }
    }
}
