// Дано уравнение: ((4-2)*(1+3))/10
// Разобьем его на бинарное дерево и пронумеруем действия:
//                               / [1]
//                   * [2]             10 [3]
//        - [4]            + [5]   [6]        [7]
//      4 [8]  2 [9]   1 [10]  3 [11]
// 
// То есть для бинарного дерева справедлива такая связь:
//        А(i)
// A(2i)       A(2i+1)  
// 
// Переведём запись этого дерева в однострочный массив:
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                 0    1    2     3    4    5    6    7    8    9    10   11

void InOrderTraversal(int pos =1)
{
    if(pos<tree.Length)
    {
        int left=2*pos;
        int right = 2*pos+1;
        if(left<tree.Length&& !String.IsNullOrEmpty(tree[left])) 
        InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if(right<tree.Length && !String.IsNullOrEmpty(tree[right]))
        InOrderTraversal(right);
    }
}

InOrderTraversal();