using ListManagerLib;
using System.Collections;



//Описать функцию, которая заменяет в списке все вхождения элемента E1, значение которого введено с клавиатуры, 
//на элемент E2, значение которого также введено с клавиатуры.

var list1 = new List<int>(8);

for (int i = 0; i < list1.Capacity; i++)
{
    list1.Add(int.Parse(Console.ReadLine()));
}

static List<int> ReplaceEl1(List<int> list1)
{
    var num1 = int.Parse(Console.ReadLine());
    var num2 = int.Parse(Console.ReadLine());
    return list1.Select(x => x == num1 ? x = num2 : x).ToList();
}


var list2 = new ArrayList(list1);
for (int i = 0; i < 4; i++)
{
    list2.Add(Console.ReadLine());
}

static ArrayList ReplaceEl2(ArrayList list2)
{
    var num1 = Console.ReadLine();
    var num2 = Console.ReadLine();
    var num3 = int.Parse(Console.ReadLine());
    for (int i = 0; i < list2.Count; i++)
    {
        if (list2[i].ToString() == num1)
            list2[i] = num2;

        if (list2[i].ToString() == num3.ToString())
            list2[i] = num2;
    }
    return list2;

}


//var list1 = ListManager.LoadList<int>("resultList.txt");

//foreach (var item in list1)
//    Console.Write(item + " ");
//Console.WriteLine();
//var list2 = ListManager.LoadList("resultArrayList.txt");
//foreach (var item in list2)
//    Console.Write(item + " ");


//Описать функцию, которая формирует список Common,
//включив в него элементы, которые входят одновременно в список М1 и М2.

static List<T> NewList2<T>(List<T> list1, List<T> list2)
{
    return list1.Intersect(list2).ToList();
}

//Описать функцию, которая включает в упорядоченный по убыванию список новое значение,
//введенное с клавиатуры, таким образом, чтобы не нарушать упорядоченность.(не используя сортировок!)

var list3 = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
static List<int> NewList3(List<int> list, int num)
{
    var addVar = 0;
    for (int i = 0; i < list.Count ; i++)
    {
        if (list[i] > num && list[++i] <= num)
        {
            if (list[i] == num)
            {
                addVar = list[++i];
                list.Insert(i, num);
                list[++i] = addVar;
                i -= 2;
            }
            else
            {
                addVar = list[i];
                list.Insert(i, num);
                list[++i] = addVar;
                i -= 2;
            }

        }

    }
    return list;
}
var res3 =  NewList3(list3 , 7);

foreach (var item in res3)
    Console.Write(item + " ");










