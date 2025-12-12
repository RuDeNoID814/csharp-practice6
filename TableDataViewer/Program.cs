namespace TableDataViewer
{
	class Program
	{
		static void Main(string[] args)
		{
			string folder, file, pagination, columns;
			
			if (args.Length != 4)
			{
				Console.WriteLine("Введите путь до файла: ");
				folder = Console.ReadLine();
			
				Console.WriteLine("Введите имя файла: ");
				file = Console.ReadLine();
			
				Console.WriteLine("Введите пагинацию: ");
				pagination = Console.ReadLine();
			
				Console.WriteLine("Введите столбцы: ");
				columns = Console.ReadLine();
			}
			else
			{
				folder = args[0];
				file = args[1];
				pagination = args[2];
				columns = args[3];
			}
		}
	}
}