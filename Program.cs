using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {

        IElectronicDevice TV = TVRemote.GetDevice();

        PowerButton powerButton = new PowerButton(TV);

        powerButton.Execute();
        powerButton.Undo();

    }
}
