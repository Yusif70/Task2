
#region roman to integer

//string roman = "MMXC";

//int[] arr = new int[roman.Length];

//for (int i = 0; i < roman.Length; i++)
//{
//	switch (roman[i])
//	{
//		case 'I':
//			arr[i] = 1;
//			break;
//		case 'V':
//			arr[i] = 5;
//			break;
//		case 'X':
//			arr[i] = 10;
//			break;
//		case 'L':
//			arr[i] = 50;
//			break;
//		case 'C':
//			arr[i] = 100;
//			break;
//		case 'D':
//			arr[i] = 500;
//			break;
//		case 'M':
//			arr[i] = 1000;
//			break;
//	}
//}

//int result = 0;

//for (int i = 0; i < arr.Length; i++)
//{

//	if (i == arr.Length - 1)
//	{
//		result += arr[i];
//	}
//	else
//	{
//		if (arr[i] >= arr[i + 1])
//		{
//			result += arr[i];
//		}
//		else
//		{
//			arr[i] = arr[i + 1] - arr[i];
//			result += arr[i];
//			i++;
//		}
//	}
//}

//Console.WriteLine(result);

#endregion

#region divide to numbers

//Console.Write("bolunen daxil edin: ");
//int bolunen = int.Parse(Console.ReadLine());
//Console.Write("bolen daxil edin: ");
//int bolen = int.Parse(Console.ReadLine());

//tamHisseniHesabla(bolunen, bolen);

//static void tamHisseniHesabla(int bolunen, int bolen)
//{
//	int result = 0;
//	int bolunen2 = bolunen;

//	if (bolen > 0)
//	{
//		if (bolunen > 0)
//		{
//			while (bolunen2 >= bolen)
//			{
//				bolunen2 -= bolen;
//				result++;
//			}
//		}
//		else
//		{
//			while (-bolunen2 >= bolen)
//			{
//				bolunen2 += bolen;
//				result--;
//			}
//		}
//		Console.WriteLine($"{bolunen}/{bolen} = {result}");
//	}
//	else if (bolen < 0)
//	{
//		if (bolunen > 0)
//		{
//			while (bolunen2 >= -bolen)
//			{
//				bolunen2 += bolen;
//				result--;
//			}
//		}
//		else
//		{
//			while (bolunen2 <= bolen)
//			{
//				bolunen2 -= bolen;
//				result++;
//			}
//		}
//		Console.WriteLine($"{bolunen}/{bolen} = {result}");
//	}
//	else
//	{
//		Console.WriteLine("bolen 0 ola bilmez");
//	}
//}

#endregion