namespace Game.GameLoop;

public class Loop
{
    public Loop()
    {

    }

    public void Start()
    {
        Console.WriteLine("Bạn Muốn Bắt đầu trò chơi? (Y/N)");
        var start = Console.ReadLine();
        if (start != "Y" && start != "y")
        {
            return;
        }

        while (true)
        {
            Console.WriteLine("Nhập x, y (VD: 0,0)");
            var cord = Console.ReadLine().Split(",");

            if (cord.Length != 2)
            {
                Console.WriteLine("Nhập sai toạ độ!!!!");
                continue;
            }


        }
    }
}