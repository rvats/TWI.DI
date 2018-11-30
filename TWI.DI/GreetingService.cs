using System;

namespace TWI.DI
{
    public class GreetingService: IGreetingService
    {

        public void WelcomeGreeting()
        {
            TwiConsole.WriteGeneralMessage("Hello Universe From Rahul Vats", animation: true, newLine: true);
            TwiConsole.WriteErrorMessage("Hello Universe From Rahul Vats", animation: true, newLine: true);
            var asterisk = "";
            for (int i = 0; i <= 10; i++)
            {
                asterisk += "*";
                TwiConsole.WriteHighlightMessage(asterisk, animation: true);
            }
            TwiConsole.WriteGeneralMessage("", newLine: true);
            TwiConsole.WriteSuccessMessage("Have A Good Day", animation: true, newLine: true);
        }
    }
}
