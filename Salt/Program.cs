while (true)
{
    // read from the console
    string ニミセナカ = Console.ReadLine();
    // split it by newlines
    string[] ソラシイ = ニミセナカ.Split('\n');

    foreach (string リニミイ in ソラシイ)
    {
        // if the input is "exit", segfault
        if (リニミイ == "exit;")
        {
            // segfault
            unsafe
            {
                // fake segfault message
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Segmentation fault (core dumped)");
                _ = *(int*)(IntPtr)0xffffffff;
            }
        }
        else if (リニミイ == "explode;")
        {
            try
            {
                // generate random number, and if it's less than 0.5,
                // throw the most obscure error
                if (new Random().NextDouble() < 0.5)
                {
                    throw new System.Runtime.InteropServices.ExternalException(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Successfully exploded!");
                }
            }
            catch (System.Runtime.InteropServices.ExternalException イ)
            {
                Console.WriteLine($"FUwUcky WUwUcky UwU, the fUwUnctiOwOn `expwOwOde` cwashed UwUnexpectedwy! Pwease wepOwOrt this tOwO the devewOwOpews.\nEwwow info:" +
                                  $"{イ.Data}\n{イ.ErrorCode}\n{イ.Message}\n{イ.Source}\n{イ.StackTrace.Replace("/", イ.StackTrace)}");
                throw イ;
            }
        }
    }
}