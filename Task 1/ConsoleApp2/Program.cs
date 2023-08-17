using ConsoleApp2;

MainPrintFile mainPrintFileobj=new MainPrintFile();     
Word wordobj=new Word();
Excel excelobj=new Excel();
PDF pdfobj=new PDF();

mainPrintFileobj.PrintCapture(wordobj);
mainPrintFileobj.PrintCapture(excelobj);                    
mainPrintFileobj.PrintCapture(pdfobj);      