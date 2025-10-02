using Lab02;

void SendToPrinter(IPrint printer, string text)
{
    printer.Print(text);
}

void SendToScanner(IScan scanner, string text)
{
    scanner.Scan(text);
}

void SendToCopier(ICopy copier, string text)
{
    copier.Copy(text);
}

void SendToFax(IFax fax, string text)
{
    fax.Fax(text);
}

SendToPrinter(new LaserPrinter(), "Hello world");

var mfd = new MultiFunctionDevice();

SendToPrinter(mfd, "Some text to print");
SendToScanner(mfd, "Some text to scan");
SendToCopier(mfd, "Some text to copy");
SendToFax(mfd, "Some text to fax");