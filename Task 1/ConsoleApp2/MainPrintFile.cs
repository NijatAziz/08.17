using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MainPrintFile
    {
        public void PrintCapture(object fileobj)
        {
            if (fileobj is Word)
            {
                Console.WriteLine("Word" + ((Word)fileobj).Capture());

            }
            else if(fileobj is Excel)
            {
                Console.WriteLine("PDF" +((Excel)fileobj).Capture());
            }
            else if(fileobj is PDF)
            {
                Console.WriteLine("PDF" + ((PDF)fileobj).Capture());
            }
            else
            {
                Console.WriteLine("Yanlis fayl novu");
            }
        }
        
        }
    }

