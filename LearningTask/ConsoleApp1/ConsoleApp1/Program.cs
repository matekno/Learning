await TaskTest();
Console.WriteLine("Termine la tarea");
int resultRnd = await RandomNumAsync();
Console.WriteLine(resultRnd);


Console.ReadLine();

async Task TaskTest()
{
    var task = new Task(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Tarea interna del task");
    });
    task.Start();
    await task;
}

async Task<int> RandomNumAsync()
{
    var task = new Task<int>((() => new Random().Next(1000)));
    task.Start();
    int result = await task;
    return result;
}

async Task<int> SquareNum(int num)
{
    var task = new Task<int>(() => num * num);
    task.Start();
    int result = await task;
    return result;
}